using DoAN.DAO;
using DoAN.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoAN
{
    public partial class frm_BanAn : Form
    {

        lopdungchung lopchung = new lopdungchung();
        public frm_BanAn()
        {
            InitializeComponent();
        }
        private void frm_BanAn_Load(object sender, EventArgs e)
        {
            LoadBan();
            LoadMonAn();
            LoadComboboxTable();
        }
        void LoadBan()
        {
            flpTable.Controls.Clear();

            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }

                flpTable.Controls.Add(btn);
            }
        }
        void LoadMonAn()
        {
            string sqlLoai = "Select * from THUCDON";
            cbMonAn.DataSource = lopchung.LoadLD(sqlLoai);
            cbMonAn.ValueMember = "MATHUCDON";
            cbMonAn.DisplayMember = "TENTHUCDON";

        }

        void LoadComboboxTable()
        {
            string sqlBan = "Select * from BAN";
            cbSwitchTable.DataSource = lopchung.LoadLD(sqlBan);
            cbSwitchTable.ValueMember = "MABAN";
            cbSwitchTable.DisplayMember = "TENBAN";
        }

        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lv_HoaDon.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        void ShowBill(int id)
        {
            lv_HoaDon.Items.Clear();
            List<DoAN.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (DoAN.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lv_HoaDon.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            txbTotalPrice.Text = totalPrice.ToString("c", culture);
        }


        private void btnSwitchTable_Click(object sender, EventArgs e)
        {

            int id1 = (lv_HoaDon.Tag as Table).ID;

            int id2 = int.Parse(cbSwitchTable.SelectedValue.ToString());
            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lv_HoaDon.Tag as Table).Name, cbSwitchTable.SelectedValue.ToString()), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            { 
                TableDAO.Instance.SwitchTable(id1, id2);

                LoadBan();
            }

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lv_HoaDon.Tag as Table;

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)nmDisCount.Value;

            double totalPrice = Convert.ToDouble(txbTotalPrice.Text.Split(',')[0]);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\nTổng tiền - (Tổng tiền / 100) x Giảm giá\n=> {1} - ({1} / 100) x {2} = {3}", table.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                    ShowBill(table.ID);

                    LoadBan();
                }
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string sqlHD = "insert into HOADON values((select MAX(MAHOADON) + 1 from HOADON),GetDate(),'0','"+ (lv_HoaDon.Tag as Table).ID + "',0)";
            lopchung.ThemXoaSua(sqlHD);

            string sqlCTHD = "insert into CTHD values((select MAX(MACTHD) + 1 from CTHD),(select MAX(MAHOADON) from HOADON),'"+cbMonAn.SelectedValue+"','"+nmFoodCount.Value+"')";
            lopchung.ThemXoaSua(sqlCTHD);

            LoadBan();

        }
    }
}
