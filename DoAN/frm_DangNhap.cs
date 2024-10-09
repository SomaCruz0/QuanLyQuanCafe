using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DoAN
{
    public partial class frm_DangNhap : Form
    {

        public frm_DangNhap()
        {
            InitializeComponent();
            //this.BackColor = Color.LimeGreen;
            //this.TransparencyKey = Color.LimeGreen;

        }
        lopdungchung lopchung = new lopdungchung();

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
          

        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng không", "Xác nhận đóng", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string sql = "Select COUNT(*)from TAIKHOAN WHERE TENDN = '" + txt_dangnhap.Text + "'and MATKHAU ='" + txt_matkhau.Text + "'";
            int kq = lopchung.dangnhap(sql);
            if (kq == 1)
            {
                MessageBox.Show("Đăng Nhập Thành Công");
                frm_DanhMuc frm_DanhMuc = new frm_DanhMuc();
                frm_DanhMuc.Show(); 

            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_matkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_matkhau.UseSystemPasswordChar = true;
            }
        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
