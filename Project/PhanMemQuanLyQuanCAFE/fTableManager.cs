using PhanMemQuanLyQuanCAFE.DAO;
using PhanMemQuanLyQuanCAFE.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace PhanMemQuanLyQuanCAFE
{
    public partial class fTableManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount {
            get { return loginAccount; }
            set {  loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        public fTableManager(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;

            LoadfTable();
        }

        #region Methods

        // Load các table lên Form
        public void LoadfTable()
        {
            LoadTable();
            LoadCategory();
            LoadComboBoxTable(cbSwitchTable);
        }

        // Không cho Người dùng sử dụng Menu Admin
        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinTàiKhoảnToolStripMenuItem.Text += " (" + LoginAccount.DisPlayName + ")";
        }

        // Laod danh sách Category vào comboBox
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }

        // Load ListFood vào comboBox
        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
        }

        // Load danh sách bàn
        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.tableWidth, Height = TableDAO.tableHeight};

                btn.Text = item.Name + Environment.NewLine + item.Status;

                btn.Click += Btn_Click;
                btn.Tag = item;

                if (item.Status == "Trong")
                {
                    btn.BackColor = Color.Aqua;
                }
                else
                {
                    btn.BackColor = Color.LightPink;
                }

                flpTable.Controls.Add(btn);
            }
        }

        // Load lại bàn vừa checkOut hoặc Thêm món
        void LoadTableCheckOutORAddFood(Table table)
        {
            Button btn = flpTable.Controls
                        .OfType<Button>()
                        .FirstOrDefault(b => (b.Tag as Table)?.ID == table.ID);

            if (table.Status == "Trong")
            {
                table.Status = "Co nguoi";
                btn.Text = table.Name + Environment.NewLine + table.Status;
                btn.BackColor= Color.LightPink;
            }
            else if (table.Status == "Co nguoi")
            {
                table.Status = "Trong";
                btn.Text = table.Name + Environment.NewLine + table.Status;
                btn.BackColor= Color.Aqua;
            }
        }
        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            float totalPrice = 0;
            List<DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            foreach (DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());

                totalPrice += item.TotalPrice;

                lsvBill.Items.Add(lsvItem);
                
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            //Thread.CurrentThread.CurrentCulture = culture;

            txbTotalPrice.Text = totalPrice.ToString("c", culture);
        }

        // Load tên bàn vào comboBox
        void LoadComboBoxTable(ComboBox cb)
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            cb.DataSource = tableList;
            cb.DisplayMember = "Name";
        }

        #endregion

        #region Các Event dành cho Form Admin
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.loginAccount = LoginAccount;

            f.InsertFood += F_InsertFood;
            f.DeleteFood += F_DeleteFood;
            f.UpdateFood += F_UpdateFood;

            f.InsertCategory += F_InsertCategory;
            f.DeleteCategory += F_DeleteCategory;
            f.UpdateCategory += F_UpdateCategory;

            f.InsertTable += F_InsertTable;
            f.DeleteTable += F_DeleteTable;
            f.UpdateTable += F_UpdateTable;

            f.ShowDialog();
        }

        // Thêm, sửa, xóa Bàn
        private void F_UpdateTable(object sender, EventArgs e)
        {
            LoadTable();
            LoadComboBoxTable(cbSwitchTable);
        }

        private void F_DeleteTable(object sender, EventArgs e)
        {
            LoadTable();
            LoadComboBoxTable(cbSwitchTable);
        }

        private void F_InsertTable(object sender, EventArgs e)
        {
            LoadTable();
            LoadComboBoxTable(cbSwitchTable);
        }

        // Thêm, sửa, xóa Danh mục
        private void F_UpdateCategory(object sender, EventArgs e)
        {
            LoadCategory();
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }

        private void F_DeleteCategory(object sender, EventArgs e)
        {
            LoadCategory();
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
            LoadTable();
        }

        private void F_InsertCategory(object sender, EventArgs e)
        {
            LoadCategory();
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }

        // Thêm, sửa, xóa Thức ăn
        private void F_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).Id);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }

        private void F_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).Id);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
            LoadTable();
        }

        private void F_InsertFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).Id);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }

        #endregion 

        #region Events

        // Thóat Form
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Vào Form Thông tin cá nhân
        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(LoginAccount);
            f.E_UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }

        // Event thực hiện sau khi Update Account
        private void f_UpdateAccount(object sender, AccountEven e)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisPlayName + ")";
        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.Id;

            LoadFoodListByCategoryID(id);
        }

        // Event khi click vào 1 bàn 
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;

            ShowBill(tableID);
        }

        // Event khi click vào Thêm món
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            if (table == null) 
                return;

            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = (int)nmFoodCount.Value;
            bool foodExistsInBill = BillInfoDAO.Instance.IsFoodExistsInBill(idBill, foodID);

            if (foodExistsInBill == false && count <= 0)
                return;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }
            ShowBill(table.ID);

            if (table.Status == "Trong")
                LoadTableCheckOutORAddFood(table);
        }

        // Event khi click Thanh toán
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            if (txbTotalPrice.Text == "0,00 ₫") 
                return;

            if (table == null) 
                return;

            int iddBill = BillDAO.Instance.GetUnCheckBillIDByTableID((int)table.ID);
            int discount = (int)nmDiscount.Value;
            string priceText = txbTotalPrice.Text;
            string cleanedText = priceText.Replace(" ₫", "").Replace(".", "").Replace(",", ".");
            double totalPrice = Convert.ToDouble(cleanedText);
            double discountPrice = totalPrice * discount / 100;
            bool boolDiscount  = (discount != 0) ? true : false;
            double finalTotalPrice = (totalPrice - discountPrice);

            if (iddBill != -1)
            {
                if (boolDiscount)
                {
                    if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn: " + table.Name + "\nTổng tiền cần trả: {0} - {1} = {2}", totalPrice, discountPrice, finalTotalPrice + ",00 đ"),
                                    "Thong bao", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        BillDAO.Instance.CheckOut(iddBill, discount, (float)finalTotalPrice);
                        ShowBill(table.ID);
                        LoadTableCheckOutORAddFood(table);
                    }
                }
                else if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn: " + table.Name + "\nTổng tiền cần trả: {0}", totalPrice + ",00 đ"),
                                    "Thong bao", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(iddBill, discount, (float)finalTotalPrice);
                    ShowBill(table.ID);
                    LoadTableCheckOutORAddFood(table);
                }
            }
            nmDiscount.Text = "0";
        }

        // Event khi click Chuyển bàn
        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            Table table1 = (lsvBill.Tag as Table);
            if (table1 == null)
            {
                MessageBox.Show("Vui lòng chọn bàn để Thực hiện thao tác này!", "Thông báo");
                return;
            }
            int id1 = table1.ID;

            Table table2 = (cbSwitchTable.SelectedItem as Table);
            int id2 = table2.ID;

            if (id1 == id2)
                return;

            if (MessageBox.Show(string.Format("Bạn có thật sự muốn Chuyển bàn {0} qua bàn {1}", (lsvBill.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(id1, id2);
                ShowBill(table1.ID);              
            }
            LoadTable();
        }

        // Xử lý nhấn vào nút Thanh toán
        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCheckOut_Click(this, new EventArgs());
        }

        // Xử lý nhấn vào nút Thêm món
        private void thêmMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddFood_Click(this, new EventArgs());
        }

        #endregion

        #region Thông tin chủ sở hữu

        private void emailToannguyenxyz60gmailcomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = @"https://mail.google.com/mail/u/0/#inbox?compose=CllgCJvlqmtgfjxDCxZJPlvkrQTjxkdmqhmNHkBKbsmCZGvHDFbSMPfwtkSKsWfrFhJKjsWSjnq";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi mở liên kết: " + ex.Message);
            }
        }

        private void fBHttpswwwfacebookcomprofilephpid100039999038475ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = @"https://www.facebook.com/profile.php?id=100039999038475";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi mở liên kết: " + ex.Message);
            }
        }

        private void githubHttpsgithubcomtuilatoan15ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = @"https://github.com/tuilatoan15";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi mở liên kết: " + ex.Message);
            }
        }

        private void youtubeHttpswwwyoutubecomToanNguyenew6nfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = @"https://www.youtube.com/@ToanNguyen-ew6nf";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi mở liên kết: " + ex.Message);
            }
        }

        #endregion
    }
}
