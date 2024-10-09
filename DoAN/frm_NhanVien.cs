using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAN
{
    public partial class frm_NhanVien : Form
    {
        public frm_NhanVien()
        {
            InitializeComponent();
        } 
        lopdungchung lopchung = new lopdungchung();

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            string sql = "Select * from NHANVIEN";
            dataGridView1.DataSource = lopchung.LoadLD(sql);
            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sqlxoa = "Delete from NHANVIEN WHERE MANHANVIEN = " + txt_manhanvien.Text;
            int kq = lopchung.ThemXoaSua(sqlxoa);
            if (kq >= 1)
            {
                MessageBox.Show("Xóa Nhân Viên thành Công");

            }
            else
            {
                MessageBox.Show("Xóa Nhân Viên thất bại");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_manhanvien.Text = dataGridView1.CurrentRow.Cells["MANHANVIEN"].Value.ToString();
            txt_tennhanvien.Text = dataGridView1.CurrentRow.Cells["TENNHANVIEN"].Value.ToString();
            txt_sodienthoai.Text = dataGridView1.CurrentRow.Cells["DIENTHOAI"].Value.ToString();
            datetime_ngay.Text = dataGridView1.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            txt_gioitinh.Text = dataGridView1.CurrentRow.Cells["GIOITINH"].Value.ToString();
        }
    }
}
