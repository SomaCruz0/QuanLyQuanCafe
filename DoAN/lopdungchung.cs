using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace DoAN
{
    internal class lopdungchung
    {
        SqlConnection conn = new SqlConnection();
        public lopdungchung() {
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\study\UngDungDotNet\DoAn\DoAN\DoAN\QuanLyQuanCF.mdf;Integrated Security=True";
        }
        public int ThemXoaSua(string sql)
        {
            try
            {
                SqlCommand command = new SqlCommand(sql, conn);
                conn.Open();
                int kq = command.ExecuteNonQuery();
                conn.Close();
                return kq;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public object laygt(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            object kq = cmd.ExecuteScalar();
            conn.Close();
            return kq;


        }
        public int dangnhap(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            int kq = (int)cmd.ExecuteScalar();
            conn.Close();
            return kq;
        }
        public DataTable LoadLD(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
