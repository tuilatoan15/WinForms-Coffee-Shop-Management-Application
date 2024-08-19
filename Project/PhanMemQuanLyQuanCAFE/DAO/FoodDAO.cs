using PhanMemQuanLyQuanCAFE.DTO;
using System.Collections.Generic;
using System.Data;

namespace PhanMemQuanLyQuanCAFE.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return instance; }
            private set { FoodDAO.instance = value; }
        }

        private FoodDAO() { }

        // Lấy danh sách Food từ idCategory truyền vào
        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();

            string query = "SELECT * FROM Food WHERE idCategory = " +id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        // Lấy ra danh sách thức ăn
        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();

            string query = "SELECT id AS [ID], name AS [Name], idCategory AS [IDCategory], price AS [Price] FROM Food";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        // Các hàm thêm, sửa, xóa thức ăn
        public bool InsertFood(string name, int id, float price)
        {
            string query = string.Format("INSERT Food (name, idCategory, price) VALUES (N'{0}', {1}, {2})", name, id, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateFood(int idFood, string name, int idCategory, float price)
        {
            string query = string.Format("UPDATE Food SET name = N'{0}', idCategory = {1}, price = {2} WHERE id = {3} ", name, idCategory, price, idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteFood(int idFood)
        {
            BillInfoDAO.Instance.DeleteBillInfoByFoodID(idFood);

            string query = string.Format("DELETE Food WHERE id = {0}", idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // Tìm kiếm thức ăn từ tên thức ăn truyền vào
        public List<Food> SearchFoodByName(string name)
        {
            List<Food> list = new List<Food>();

            string query = string.Format("SELECT * FROM Food WHERE [dbo].[fuConvertToUnsign1] (name) LIKE N'%' + [dbo].[fuConvertToUnsign1](N'{0}') + '%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        } 

        // Xóa các món có cùng Category
        public void DeteleFoodByCategoryID(int categoryID)
        {
            DataProvider.Instance.ExecuteQuery("DELETE Food WHERE Food.idCategory = " +categoryID);
        }
    }
}
