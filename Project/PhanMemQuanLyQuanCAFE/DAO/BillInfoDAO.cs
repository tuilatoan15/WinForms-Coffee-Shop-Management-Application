using PhanMemQuanLyQuanCAFE.DTO;
using System.Collections.Generic;
using System.Data;

namespace PhanMemQuanLyQuanCAFE.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance { 
            get { if (instance == null) instance = new BillInfoDAO(); return instance; }
            private set {  BillInfoDAO.instance = value; } 
        }

        public BillInfoDAO() { }

        // Lấy danh sách BillInfo từ idBill truyền vào
        public List<BillInfo> GetBillInfos(int id)
        {
            List<BillInfo> listBillInfor = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM BillInfo WHERE idBill = " +id);

            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfor.Add(info);
            }

            return listBillInfor;
        }

        // Kiểm tra món ăn có tồn tại trong hóa đơn không
        public bool IsFoodExistsInBill(int idBill, int foodID)
        {
            string query = "SELECT COUNT(*) FROM BillInfo WHERE idBill = @idBill AND idFood = @idFood ";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { idBill, foodID });
            return (int)result > 0;
        }

        // Thêm BillInfo mới
        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteQuery("USP_InsertBillInfo @idBill , @idFood , @count ", new object[] {idBill, idFood, count});
        }

        // Xóa BillInfo từ idFood truyền vào
        public void DeleteBillInfoByFoodID(int id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE BillInfo WHERE idFood = " + id);
        }
    }
}
