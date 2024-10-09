using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoAN
{
    public partial class frm_ThucDon : Form
    {
        public frm_ThucDon()
        {
            InitializeComponent();
        }
        lopdungchung lopchung = new lopdungchung();
        public void LoadGrid()
        {
            String sqlGrid = "select * from THUCDON";
            dataGridViewthucdon.DataSource = lopchung.LoadLD(sqlGrid);
        }

        private void frm_ThucDon_Load(object sender, EventArgs e)
        {
            string sql = "Select * from THUCDON";
            dataGridViewthucdon.DataSource = lopchung.LoadLD(sql);
            string sqltd = "Select * from GHICHU";
            cbb_ghichu.DataSource = lopchung.LoadLD(sqltd);
            cbb_ghichu.ValueMember = "MAGHICHU";
            cbb_ghichu.DisplayMember = "TENGHICHU";
        }

        private void btn_dem_Click(object sender, EventArgs e)
        {
            string sqldem = "Select COUNT (*) from THUCDON";
            int sothucdon = (int)lopchung.laygt(sqldem);
            txt_dem.Text = sothucdon.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sqlxoa = "Delete from THUCDON WHERE MATHUCDON = " + txt_mathucdon.Text;
            LoadGrid();
            File.Delete(duongdan + txt_tenHinh.Text);
            int kq = lopchung.ThemXoaSua(sqlxoa);
            if (kq >= 1)
            {
                MessageBox.Show("Xóa Thực Đơn thành Công");

            }
            else
            {
                MessageBox.Show("Xóa Thực Đơn thất bại");
            }
        }
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HINHANH\\";


        private void btn_them_Click(object sender, EventArgs e)
        {
            pictureBox.Image.Save(duongdan + txt_tenHinh.Text);
            string sqlthem = "Insert into THUCDON values ('" + txt_mathucdon.Text + "', N'" + txt_tenthucdon.Text + "', '" + txt_soluong.Text + "', N'" + cbb_ghichu.SelectedValue + "', '" + txt_tenHinh.Text + "')";
            int kq = lopchung.ThemXoaSua(sqlthem);
            LoadGrid();
            if (kq >= 1)
            {
                MessageBox.Show("Thêm Thực Đơn Thành Công");
            }
            else
            {
                MessageBox.Show("Thêm Thực Đơn Thất Bại");
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE THUCDON SET " +
                             "TENTHUCDON = N'" + txt_tenthucdon.Text + "', " +
                             "SOLUONG = '" + txt_soluong.Text + "', " +
                             "GHICHU = N'" + cbb_ghichu.SelectedValue + "', " +
                             "TENHINH = '" + txt_tenHinh.Text + "' " +
                             "WHERE MATHUCDON = '" + txt_mathucdon.Text + "'";
                int kq = lopchung.ThemXoaSua(sql);

                if (kq >= 1)
                {
                    MessageBox.Show("Sửa Thực Đơn thành công");
                }
                else
                {
                    MessageBox.Show("Sửa Thực Đơn thất bại");
                }
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewthucdon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mathucdon.Text = dataGridViewthucdon.CurrentRow.Cells["MATHUCDON"].Value.ToString();
            txt_tenthucdon.Text = dataGridViewthucdon.CurrentRow.Cells["TENTHUCDON"].Value.ToString();
            txt_soluong.Text = dataGridViewthucdon.CurrentRow.Cells["SOLUONG"].Value.ToString();
            cbb_ghichu.SelectedValue = dataGridViewthucdon.CurrentRow.Cells["GHICHU"].Value.ToString();
            txt_tenHinh.Text = dataGridViewthucdon.CurrentRow.Cells["TENHINH"].Value.ToString();
            pictureBox.ImageLocation = duongdan + txt_tenHinh.Text;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Hãy chọn hình";
            ofd.Filter = "Tất cả đuôi|*.*|Đuôi JPG|*.jpg|Đuôi png|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            pictureBox.Image = Image.FromFile(ofd.FileName);
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            String sqlTim = "select * from THUCDON where" +
                " MATHUCDON like '%" + txt_tim.Text + "%' or TENTHUCDON like '%" + txt_tim.Text + "%' ";
            dataGridViewthucdon.DataSource = lopchung.LoadLD(sqlTim);
        }
    }
}
