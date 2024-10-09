using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAN.DTO;

namespace DoAN.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }

        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "SELECT f.TENTHUCDON, bi.SOLUONG, f.GIA, f.GIA*bi.SOLUONG AS TONGTIEN FROM dbo.CTHD AS bi, dbo.HOADON AS b, dbo.THUCDON AS f WHERE bi.MACTHD = b.MAHOADON AND bi.MATHUCDON = f.MATHUCDON AND b.TRANGTHAI = 0 AND b.BAN = " + id;
            DataTable data = lopdungchung.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
