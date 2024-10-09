using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DoAN.DAO;

namespace DoAN
{
    public class lopdungchung
    {
        private static lopdungchung instance;
        public static lopdungchung Instance
        {
            get { if (instance == null) instance = new lopdungchung(); return lopdungchung.instance; }
            private set { lopdungchung.instance = value; }
        }
        SqlConnection conn = new SqlConnection();
        private string connectionSTR = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\study\\UngDungDotNet\\DoAn\\DoAN\\DoAN\\QuanLyQuanCF.mdf;Integrated Security=True";

        public lopdungchung()
        {
            conn.ConnectionString = connectionSTR;
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
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            try
            {
                DataTable data = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(data);

                    connection.Close();
                }

                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
    }
}
