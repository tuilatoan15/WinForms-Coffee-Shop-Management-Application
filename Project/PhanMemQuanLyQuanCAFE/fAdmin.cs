using PhanMemQuanLyQuanCAFE.DAO;
using PhanMemQuanLyQuanCAFE.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace PhanMemQuanLyQuanCAFE
{
    public partial class fAdmin : Form
    {   
        BindingSource foodList = new BindingSource();
        BindingSource accountList = new BindingSource();
        BindingSource categoryList = new BindingSource();
        BindingSource tableList = new BindingSource();

        public Account loginAccount;

        public fAdmin()
        {
            InitializeComponent();
            LoadFAdmin();
        }

        #region Methods

        // Load tất cả dữ liệu lên Form
        void LoadFAdmin()
        {
            dtgvFood.DataSource = foodList;
            dtgvAccount.DataSource = accountList;
            dtgvCategory.DataSource = categoryList;
            dtgvTable.DataSource = tableList;

            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadListFood();
            LoadListCategory();
            LoadListTable();
            LoadAccount();
            AddFoodBinding();
            AddAccountBinding();
            AddCategoryBinding();
            AddTableBinding();
            LoadCategoryIntoCombobox(cbFoodCategory);
            LoadStatusTableIntoComboBox(cbStatus);
        }

        // Tìm thức ăn gần đúng theo tên
        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);
            
            return listFood;
        }
        
        // Đặt lại mật khẩu về 1
        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại tài khoản thành công!");
            }
            else
            {
                MessageBox.Show("Đặt lại tài khoản thất bại!");
            }
        }

        // ------------------------------------------------------------------------------------------ Thêm, sửa, xóa tài khoản ------------------------------------------------------------------------------------------
        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công!");
            }
            else
            {
                MessageBox.Show("Thêm tài khỏan thất bại!");
            }
            LoadAccount();
        }

        void EditAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khỏan thất bại!");
            }
            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Không thể xóa tài khoản hiện đang đăng nhập!");

                return;
            }

            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công!");
            }
            else
            {
                MessageBox.Show("Xóa tài khỏan thất bại!");
            }
            LoadAccount();
        }

        // ------------------------------------------------------------------------------------------ Binding Category, Account, Table, Food ------------------------------------------------------------------------------------------
        void AddCategoryBinding()
        {
            txbIDDanhMuc.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbTenDanhMuc.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));

        }

        void AddAccountBinding()
        {
            txbAccountName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txbDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nmAccountType.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }

        void AddTableBinding()
        {
            txbIDTable.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbTenBan.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Name", true, DataSourceUpdateMode.Never));
            cbStatus.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }
        void AddFoodBinding()
        {
            txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));

        }

        // ------------------------------------------------------------------------------------------ Load dữ liệu lên Form ------------------------------------------------------------------------------------------
        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);

            // Đặt định dạng hiển thị cho DateTimePicker
            dtpkFromDate.Format = DateTimePickerFormat.Custom;
            dtpkFromDate.CustomFormat = "dddd dd/MM/yyyy";
            dtpkToDate.Format = DateTimePickerFormat.Custom;
            dtpkToDate.CustomFormat = "dddd dd/MM/yyyy";
        }

        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvDoanhThu.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }
        
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        void LoadStatusTableIntoComboBox(ComboBox cb)
        {
            List<string> list = new List<string>() { "Trong", " Co nguoi"};
            cb.DataSource = list;
        }

        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }
        void LoadListCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
        }

        void LoadListTable()
        {
            tableList.DataSource = TableDAO.Instance.LoadTableList();
        }

        #endregion

        #region Events

        // ------------------------------------------------------------------------------------------ Các Event cho Form ------------------------------------------------------------------------------------------
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        private void btnXemFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txbSearch.Text);
        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            LoadListCategory();
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            LoadListTable();
        }

        // Cập nhật thông tin danh mục thực phẩm trong cbFoodCategory dựa trên thông tin từ dtgvFood. 
        private void txbFoodID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvFood.SelectedCells.Count > 0)
                {
                    var selectedRow = dtgvFood.SelectedCells[0].OwningRow;
                    if (selectedRow.Cells["IDcategory"].Value != null)
                    {
                        int id = (int)selectedRow.Cells["IDcategory"].Value;

                        Category category = CategoryDAO.Instance.GetCategoryByID(id);
                        cbFoodCategory.SelectedItem = category;

                        int index = -1;
                        int i = 0;

                        foreach (Category item in cbFoodCategory.Items)
                        {
                            if (item.Id == category.Id)
                            {
                                index = i;
                                break;
                            }
                            i++;
                        }

                        cbFoodCategory.SelectedIndex = index;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        // -------------------------------------------------------------------------------- Thêm, sửa, xóa Food, Category, Table, Account và hàm ResetPassWord --------------------------------------------------------------------------------
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int CategoryID = (cbFoodCategory.SelectedItem as Category).Id;
            float price = (float)nmFoodPrice.Value;

            if (FoodDAO.Instance.InsertFood(name, CategoryID, price))
            {
                MessageBox.Show("Thêm món thành công!");
                LoadListFood();
                if (insertFood != null)
                {
                    insertFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn!");
            }
        }

        private void btnSuaFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int CategoryID = (cbFoodCategory.SelectedItem as Category).Id;
            float price = (float)nmFoodPrice.Value;
            int idFood = Convert.ToInt32(txbFoodID.Text);

            if (FoodDAO.Instance.UpdateFood(idFood, name, CategoryID, price))
            {
                MessageBox.Show("Sửa món thành công!");
                LoadListFood();
                if (updateFood != null)
                {
                    updateFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn!");
            }
        }

        private void btnXoaFood_Click(object sender, EventArgs e)
        {
            int idFood = Convert.ToInt32(txbFoodID.Text);

            if (FoodDAO.Instance.DeleteFood(idFood))
            {
                MessageBox.Show("Xóa món thành công!");
                LoadListFood();
                if (deleteFood != null)
                {
                    deleteFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn!");
            }
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txbTenDanhMuc.Text;

            if (CategoryDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm danh mục thành công!");
                LoadListCategory();
                LoadCategoryIntoCombobox(cbFoodCategory);
                
                if (insertCategory != null)
                {
                    insertCategory(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm danh mục!");
            }
        }

        private void btnDelCategory_Click(object sender, EventArgs e)
        {
            int idCategory = Convert.ToInt32(txbIDDanhMuc.Text);

            if (CategoryDAO.Instance.DeleteCategory(idCategory))
            {
                MessageBox.Show("Xóa danh mục thành công!");
                LoadListCategory();
                LoadCategoryIntoCombobox(cbFoodCategory);
                if (deleteCategory != null)
                {
                    deleteCategory(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa danh mục!");
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            int idCategory = Convert.ToInt32(txbIDDanhMuc.Text);
            string name = txbTenDanhMuc.Text;

            if (CategoryDAO.Instance.UpdateCategory(idCategory, name))
            {
                MessageBox.Show("Sửa danh mục thành công!");
                LoadListCategory();
                LoadCategoryIntoCombobox(cbFoodCategory);
                if (updateCategory != null)
                {
                    updateCategory(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa danh mục!");
            }
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string name = txbTenBan.Text;
            string status = "Trong";

            if (TableDAO.Instance.InsertTable(name, status))
            {
                MessageBox.Show("Thêm bàn thành công!");
                LoadListTable();
                if (insertTable != null)
                {
                    insertTable(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm bàn!");
            }
        }

        private void btnDelTable_Click(object sender, EventArgs e)
        {
            int idTable = Convert.ToInt32(txbIDTable.Text);

            if (TableDAO.Instance.DeleteTable(idTable))
            {
                MessageBox.Show("Xóa bàn thành công!");
                LoadListTable();
                LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
                if (deleteTable != null)
                {
                    deleteTable(this, new EventArgs());
                }
            }
            else
            {
                //MessageBox.Show("Có lỗi khi xóa bàn!");
            }
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            string name = txbTenBan.Text;
            int idTable = Convert.ToInt32(txbIDTable.Text);

            if (TableDAO.Instance.UpdateTable(name, idTable))
            {
                MessageBox.Show("Sửa bàn thành công!");
                LoadListTable();
                if (updateTable != null)
                {
                    updateTable(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa bàn!");
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userName = txbAccountName.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)nmAccountType.Value;

            AddAccount(userName, displayName, type);
        }

        private void btnDelAccount_Click(object sender, EventArgs e)
        {            
            string userName = txbAccountName.Text;

            DeleteAccount(userName);
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string userName = txbAccountName.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)nmAccountType.Value;

            EditAccount(userName, displayName, type);
        }

        // Event khi click vào btnResetPassWord
        private void btnResetPassWord_Click(object sender, EventArgs e)
        {
            string userName = txbAccountName.Text;

            ResetPass(userName);
        }

        // ------------------------------------------------------------------------------------------ Định nghĩa và quản lý các sự kiện trong From ------------------------------------------------------------------------------------------
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        private event EventHandler insertCategory;
        public event EventHandler InsertCategory
        {
            add { insertCategory += value; }
            remove { insertCategory -= value; }
        }

        private event EventHandler deleteCategory;
        public event EventHandler DeleteCategory
        {
            add { deleteCategory += value; }
            remove { deleteCategory -= value; }
        }

        private event EventHandler updateCategory;
        public event EventHandler UpdateCategory
        {
            add { updateCategory += value; }
            remove { updateCategory -= value; }
        }

        private event EventHandler insertTable;
        public event EventHandler InsertTable
        {
            add { insertTable += value; }
            remove { insertTable -= value; }
        }

        private event EventHandler deleteTable;
        public event EventHandler DeleteTable
        {
            add { deleteTable += value; }
            remove { deleteTable -= value; }
        }

        private event EventHandler updateTable;
        public event EventHandler UpdateTable
        {
            add { updateTable += value; }
            remove { updateTable -= value; }
        }

        // ------------------------------------------------------------------------------------------ Xử lí phân trang ------------------------------------------------------------------------------------------
        private void btnFirstBillsPage_Click(object sender, EventArgs e)
        {
            txbNumPage.Text = "1";
        }

        private void btnLastBillsPage_Click(object sender, EventArgs e)
        {
            int sumRecord = BillDAO.Instance.GetNumBillListByDate(dtpkFromDate.Value, dtpkToDate.Value);

            int lastPage = sumRecord / 10;

            if (sumRecord % 10 != 0)
            {
                lastPage++;
            }
            
            txbNumPage.Text = lastPage.ToString();
        }

        private void txbNumPage_TextChanged(object sender, EventArgs e)
        {
            dtgvDoanhThu.DataSource = BillDAO.Instance.GetBillListByDateAndPage(dtpkFromDate.Value, dtpkToDate.Value, Convert.ToInt32(txbNumPage.Text));
        }

        private void btnPreviousBillsPage_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txbNumPage.Text);

            if (page > 1)
            { 
                page--; 
            }

            txbNumPage.Text = page.ToString();
        }

        private void btnNextBillsPage_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txbNumPage.Text);

            double sumRecord = BillDAO.Instance.GetNumBillListByDate(dtpkFromDate.Value, dtpkToDate.Value);

            if (page < sumRecord / 10)
            {
                page++;
            }

            txbNumPage.Text = page.ToString();
        }

        #endregion


        private void fAdmin_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'xDataSet.USP_GetTableList' table. You can move, or remove it, as needed.
            this.uSP_GetListBillByDateForReportTableAdapter.Fill(this.quanLyQuanCaPheDataSet1.USP_GetListBillByDateForReport, dtpkFromDate.Value, dtpkToDate.Value);
            this.reportViewer1.RefreshReport();       
        }
    }
}

