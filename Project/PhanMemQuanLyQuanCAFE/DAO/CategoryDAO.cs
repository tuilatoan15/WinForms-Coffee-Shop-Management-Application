using PhanMemQuanLyQuanCAFE.DTO;
using System.Collections.Generic;
using System.Data;

namespace PhanMemQuanLyQuanCAFE.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance {
            get { if (instance == null) instance = new CategoryDAO(); return instance; }
            private set { CategoryDAO.instance = value; }
        }

        private CategoryDAO() { }

        // Lấy ra danh sách Category 
        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();

            string query = "SELECT id AS [ID], name AS [Name] FROM FoodCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);

                list.Add(category);
            }

            return list;
        }

        // Lấy ra Category từ idCategory truyền vào
        public Category GetCategoryByID(int id)
        {
            Category category = null;

            string query = "SELECT * FROM FoodCategory WHERE id = " +id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }

            return category;
        }

        // Các hàm thêm, sửa, xóa Category 
        public bool InsertCategory(string name)
        {
            string query = string.Format("INSERT FoodCategory (name) VALUES (N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateCategory(int id, string name)
        {
            string query = string.Format("UPDATE FoodCategory SET name = N'{0}' WHERE id = {1} ", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteCategory(int idCategory)
        {
            List<Food> foodList = FoodDAO.Instance.GetFoodByCategoryID(idCategory);

            foreach (Food item in foodList)
            {
                BillInfoDAO.Instance.DeleteBillInfoByFoodID(item.ID);
            }

            FoodDAO.Instance.DeteleFoodByCategoryID(idCategory);

            string query = string.Format("DELETE FoodCategory WHERE id = {0}", idCategory);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
