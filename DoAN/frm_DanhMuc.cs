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
    public partial class frm_DanhMuc : Form
    {
        public frm_DanhMuc()
        {
            InitializeComponent();
        }

        

        private void frm_DanhMuc_Load(object sender, EventArgs e)
        {
           

        }

       
        private void đóngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ThucDon thucdon = new frm_ThucDon();
            thucdon.MdiParent = this;
            thucdon.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NhanVien nhanvien = new frm_NhanVien();
            nhanvien.MdiParent = this;
            nhanvien.Show();
        }

        private void BanAnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_BanAn"] == null)
            {
                frm_BanAn f = new frm_BanAn();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                Application.OpenForms["frm_BanAn"].Activate();
            }
        }
    }
}
