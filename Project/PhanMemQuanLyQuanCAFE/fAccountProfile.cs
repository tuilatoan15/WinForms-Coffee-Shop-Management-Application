using PhanMemQuanLyQuanCAFE.DAO;
using PhanMemQuanLyQuanCAFE.DTO;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PhanMemQuanLyQuanCAFE
{
    public partial class fAccountProfile : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangAccount(loginAccount); }
        }

        public fAccountProfile(Account acc)
        {
            InitializeComponent();

            LoginAccount = acc;
        }

        #region Methods

        // Lấy Thông tin truyền vào Form
        void ChangAccount(Account acc)
        {
            txbUserName.Text = LoginAccount.UserName;
            txbDisplayName.Text = LoginAccount.DisPlayName;
        }

        // Cập nhật mật khẩu, tên hiển thị cho Account
        void UpdateAccount()
        {
            string displayName = txbDisplayName.Text;

            string password = txbPassword.Text;
            //byte[] temp = Encoding.ASCII.GetBytes(password);
            //byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            //string hasPass = "";

            //foreach (byte item in hasData)
            //{
            //    hasPass += item;
            //}

            string newpass = txbNewPassword.Text;
            string reenterPass = txbRePassword.Text;
            string userName = txbUserName.Text;

            if (!newpass.Equals(reenterPass))
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp!");
            }
            else
            {
                //byte[] tempNewpass = Encoding.ASCII.GetBytes(newpass);
                //byte[] hasDataNewpass = new MD5CryptoServiceProvider().ComputeHash(tempNewpass);

                //string hasPassNewpass = "";

                //foreach (byte item in hasDataNewpass)
                //{
                //    hasPassNewpass += item;
                //}

                bool result = AccountDAO.Instance.UpdateAccount(userName, displayName, password, newpass);
                if (result)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    if (updateAccount != null)
                        updateAccount(this, new AccountEven(AccountDAO.Instance.GetAccountByUserName(userName)));
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu!");
                }
            }
        }

        #endregion

        #region Event

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }

        private event EventHandler<AccountEven> updateAccount;
        public event EventHandler<AccountEven> E_UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
        #endregion
    }

    // Class cho Account
    public class AccountEven : EventArgs
    {
        private Account acc;

        public Account Acc { get => acc; set => acc = value; }

        public AccountEven(Account acc)
        {
            this.Acc = acc;
        }
    }
}
