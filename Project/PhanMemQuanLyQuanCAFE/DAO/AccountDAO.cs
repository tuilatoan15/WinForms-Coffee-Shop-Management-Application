using PhanMemQuanLyQuanCAFE.DTO;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace PhanMemQuanLyQuanCAFE.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        private AccountDAO() { }

        public static AccountDAO Instance { 
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

         // Kiểm tra tài khoản, mật khẩu nhập vào
        public bool Login(string userName, string passWord)
        {
            //byte[] temp = Encoding.ASCII.GetBytes(passWord);
            //byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            //string hasPass = "";

            //foreach (byte item in hasData)
            //{
            //    hasPass += item;
            //}

            //Mã hóa đảo ngược code (nếu muốn)
            //var list = hasData.ToString();
            //list.Reverse();


            string query = "USP_Login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {userName, passWord /**/});

            return result.Rows.Count > 0;
        }

        // Hàm Update Account dùng cho - Thông tin tài khoản
        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            string query = "EXEC USP_UpdateAccount @userName , @displayName , @password , @newPassword ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, displayName, pass, newPass });
            
            return result > 0;
        }

        // Lấy danh sách tài khoản 
        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT UserName, DisplayName, Type FROM Account");
        }

        // Lấy ra tài khoản từ UserName 
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM ACCOUNT WHERE userName = '" +userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }

        // Các hàm thêm, sửa, xóa Account dùng cho - Tài khoản
        public bool InsertAccount(string userName, string displayName, int type)
        {
            string query = string.Format("INSERT Account (userName, displayName, type, passWord) VALUES (N'{0}', N'{1}', {2}, N'{3}')", userName, displayName, type, "0");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateAccount(string userName, string displayName, int type)
        {
            string query = string.Format("UPDATE Account SET displayName = N'{1}', type = {2} WHERE UserName = N'{0}' ", userName, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteAccount(string name)
        {
            string query = string.Format("DELETE Account WHERE UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // Reset passWord về 1
        public bool ResetPassword(string name)
        {
            string query = string.Format("Update Account SET passWord = N'0' WHERE userName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
