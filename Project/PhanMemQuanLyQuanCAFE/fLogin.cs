using PhanMemQuanLyQuanCAFE.DAO;
using PhanMemQuanLyQuanCAFE.DTO;
using System;
using System.Windows.Forms;

namespace PhanMemQuanLyQuanCAFE
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();

        }
        
        // Hàm kiểm tra đăng nhập
        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        // Event khi click vào btnThoat
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Event khi click vào btnDangNhap
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;

            if (Login(userName, passWord))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                fTableManager f = new fTableManager(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }

        // Event khi đóng chương trình
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
