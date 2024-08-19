using System.Collections.Generic;
using System.Data;

namespace PhanMemQuanLyQuanCAFE.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance { 
            get { if (instance == null) instance = new MenuDAO(); return instance; }
            private set { MenuDAO.instance = value; }
        }
        private MenuDAO() { }

        // Lấy ra danh sách gồm: tên thức ăn, số lượng, đơn giá, thành tiền của món ăn đó 
        public List<DTO.Menu> GetListMenuByTable(int id)
        {
            List<DTO.Menu> listMenu  = new List<DTO.Menu>();

            string query = "SELECT f.name, bi.count, f.price, f.price*bi.count AS TotalPrice FROM BillInfo AS bi, Bill AS b, Food AS f WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.status = 0 AND b.idTable = " +id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO.Menu menu = new DTO.Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
