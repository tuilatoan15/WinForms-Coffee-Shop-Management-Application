namespace PhanMemQuanLyQuanCAFE
{
    partial class fAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdmin));
            this.tabTaiKhoan = new System.Windows.Forms.TabPage();
            this.panel23 = new System.Windows.Forms.Panel();
            this.btnResetPassWord = new System.Windows.Forms.Button();
            this.panel25 = new System.Windows.Forms.Panel();
            this.nmAccountType = new System.Windows.Forms.NumericUpDown();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.txbAccountName = new System.Windows.Forms.TextBox();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.panel28 = new System.Windows.Forms.Panel();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnDelAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.panel29 = new System.Windows.Forms.Panel();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.tabBanAn = new System.Windows.Forms.TabPage();
            this.panel20 = new System.Windows.Forms.Panel();
            this.dtgvTable = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.btnEditTable = new System.Windows.Forms.Button();
            this.btnDelTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblTrangThaiTable = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txbTenBan = new System.Windows.Forms.TextBox();
            this.lblTenBan = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.txbIDTable = new System.Windows.Forms.TextBox();
            this.lblIDTable = new System.Windows.Forms.Label();
            this.tabDanhMuc = new System.Windows.Forms.TabPage();
            this.panel18 = new System.Windows.Forms.Panel();
            this.dtgvCategory = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnShowCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnDelCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txbTenDanhMuc = new System.Windows.Forms.TextBox();
            this.lblTenDanhMuc = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txbIDDanhMuc = new System.Windows.Forms.TextBox();
            this.lblIDDanhMuc = new System.Windows.Forms.Label();
            this.tabDoanhThu = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.plDoanhthu = new System.Windows.Forms.Panel();
            this.txbNumPage = new System.Windows.Forms.TextBox();
            this.btnPreviousBillsPage = new System.Windows.Forms.Button();
            this.btnLastBillsPage = new System.Windows.Forms.Button();
            this.btnFirstBillsPage = new System.Windows.Forms.Button();
            this.dtgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.rpViewer = new System.Windows.Forms.TabControl();
            this.tabFood = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.lblGia = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txbFoodName = new System.Windows.Forms.TextBox();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbFoodID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnXemFood = new System.Windows.Forms.Button();
            this.btnSuaFood = new System.Windows.Forms.Button();
            this.btnXoaFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.report = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quanLyQuanCaPheDataSet1 = new PhanMemQuanLyQuanCAFE.QuanLyQuanCaPheDataSet1();
            this.uSPGetListBillByDateForReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_GetListBillByDateForReportTableAdapter = new PhanMemQuanLyQuanCAFE.QuanLyQuanCaPheDataSet1TableAdapters.USP_GetListBillByDateForReportTableAdapter();
            this.tabTaiKhoan.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAccountType)).BeginInit();
            this.panel26.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.tabBanAn.SuspendLayout();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel19.SuspendLayout();
            this.tabDanhMuc.SuspendLayout();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.tabDoanhThu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.plDoanhthu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoanhThu)).BeginInit();
            this.rpViewer.SuspendLayout();
            this.tabFood.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPheDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateForReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabTaiKhoan
            // 
            this.tabTaiKhoan.Controls.Add(this.panel23);
            this.tabTaiKhoan.Controls.Add(this.panel28);
            this.tabTaiKhoan.Controls.Add(this.panel29);
            this.tabTaiKhoan.Location = new System.Drawing.Point(4, 22);
            this.tabTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.tabTaiKhoan.Name = "tabTaiKhoan";
            this.tabTaiKhoan.Padding = new System.Windows.Forms.Padding(2);
            this.tabTaiKhoan.Size = new System.Drawing.Size(558, 386);
            this.tabTaiKhoan.TabIndex = 4;
            this.tabTaiKhoan.Text = "Tài khoản";
            this.tabTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.btnResetPassWord);
            this.panel23.Controls.Add(this.panel25);
            this.panel23.Controls.Add(this.panel26);
            this.panel23.Controls.Add(this.panel27);
            this.panel23.Location = new System.Drawing.Point(317, 61);
            this.panel23.Margin = new System.Windows.Forms.Padding(2);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(240, 323);
            this.panel23.TabIndex = 6;
            // 
            // btnResetPassWord
            // 
            this.btnResetPassWord.Location = new System.Drawing.Point(132, 162);
            this.btnResetPassWord.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetPassWord.Name = "btnResetPassWord";
            this.btnResetPassWord.Size = new System.Drawing.Size(104, 46);
            this.btnResetPassWord.TabIndex = 4;
            this.btnResetPassWord.Text = "Đặt lại mật khẩu";
            this.btnResetPassWord.UseVisualStyleBackColor = true;
            this.btnResetPassWord.Click += new System.EventHandler(this.btnResetPassWord_Click);
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.nmAccountType);
            this.panel25.Controls.Add(this.lblAccountType);
            this.panel25.Location = new System.Drawing.Point(5, 109);
            this.panel25.Margin = new System.Windows.Forms.Padding(2);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(235, 48);
            this.panel25.TabIndex = 3;
            // 
            // nmAccountType
            // 
            this.nmAccountType.Location = new System.Drawing.Point(127, 12);
            this.nmAccountType.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmAccountType.Name = "nmAccountType";
            this.nmAccountType.Size = new System.Drawing.Size(104, 20);
            this.nmAccountType.TabIndex = 1;
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.Location = new System.Drawing.Point(3, 15);
            this.lblAccountType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(116, 17);
            this.lblAccountType.TabIndex = 0;
            this.lblAccountType.Text = "Loại tài khoản:";
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.txbDisplayName);
            this.panel26.Controls.Add(this.lblDisplayName);
            this.panel26.Location = new System.Drawing.Point(5, 56);
            this.panel26.Margin = new System.Windows.Forms.Padding(2);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(235, 48);
            this.panel26.TabIndex = 2;
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.Location = new System.Drawing.Point(127, 13);
            this.txbDisplayName.Margin = new System.Windows.Forms.Padding(2);
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(104, 20);
            this.txbDisplayName.TabIndex = 1;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.Location = new System.Drawing.Point(3, 15);
            this.lblDisplayName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(100, 17);
            this.lblDisplayName.TabIndex = 0;
            this.lblDisplayName.Text = "Tên hiển thị:";
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.txbAccountName);
            this.panel27.Controls.Add(this.lblAccountName);
            this.panel27.Location = new System.Drawing.Point(3, 3);
            this.panel27.Margin = new System.Windows.Forms.Padding(2);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(235, 48);
            this.panel27.TabIndex = 0;
            // 
            // txbAccountName
            // 
            this.txbAccountName.Location = new System.Drawing.Point(129, 12);
            this.txbAccountName.Margin = new System.Windows.Forms.Padding(2);
            this.txbAccountName.Name = "txbAccountName";
            this.txbAccountName.Size = new System.Drawing.Size(104, 20);
            this.txbAccountName.TabIndex = 1;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.Location = new System.Drawing.Point(3, 15);
            this.lblAccountName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(113, 17);
            this.lblAccountName.TabIndex = 0;
            this.lblAccountName.Text = "Tên tài khoản:";
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.btnShowAccount);
            this.panel28.Controls.Add(this.btnEditAccount);
            this.panel28.Controls.Add(this.btnDelAccount);
            this.panel28.Controls.Add(this.btnAddAccount);
            this.panel28.Location = new System.Drawing.Point(4, 5);
            this.panel28.Margin = new System.Windows.Forms.Padding(2);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(308, 51);
            this.panel28.TabIndex = 4;
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.Location = new System.Drawing.Point(238, 2);
            this.btnShowAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(68, 46);
            this.btnShowAccount.TabIndex = 3;
            this.btnShowAccount.Text = "Xem";
            this.btnShowAccount.UseVisualStyleBackColor = true;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(163, 2);
            this.btnEditAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(70, 46);
            this.btnEditAccount.TabIndex = 2;
            this.btnEditAccount.Text = "Sửa";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnDelAccount
            // 
            this.btnDelAccount.Location = new System.Drawing.Point(83, 2);
            this.btnDelAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelAccount.Name = "btnDelAccount";
            this.btnDelAccount.Size = new System.Drawing.Size(75, 46);
            this.btnDelAccount.TabIndex = 1;
            this.btnDelAccount.Text = "Xóa";
            this.btnDelAccount.UseVisualStyleBackColor = true;
            this.btnDelAccount.Click += new System.EventHandler(this.btnDelAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(2, 2);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(76, 46);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Thêm ";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.dtgvAccount);
            this.panel29.Location = new System.Drawing.Point(3, 61);
            this.panel29.Margin = new System.Windows.Forms.Padding(2);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(310, 323);
            this.panel29.TabIndex = 3;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AllowUserToAddRows = false;
            this.dtgvAccount.AllowUserToDeleteRows = false;
            this.dtgvAccount.AllowUserToResizeColumns = false;
            this.dtgvAccount.AllowUserToResizeRows = false;
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(2, 3);
            this.dtgvAccount.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.RowHeadersWidth = 51;
            this.dtgvAccount.RowTemplate.Height = 24;
            this.dtgvAccount.Size = new System.Drawing.Size(305, 317);
            this.dtgvAccount.TabIndex = 0;
            // 
            // tabBanAn
            // 
            this.tabBanAn.Controls.Add(this.panel20);
            this.tabBanAn.Controls.Add(this.panel11);
            this.tabBanAn.Controls.Add(this.panel14);
            this.tabBanAn.Location = new System.Drawing.Point(4, 22);
            this.tabBanAn.Margin = new System.Windows.Forms.Padding(2);
            this.tabBanAn.Name = "tabBanAn";
            this.tabBanAn.Padding = new System.Windows.Forms.Padding(2);
            this.tabBanAn.Size = new System.Drawing.Size(558, 386);
            this.tabBanAn.TabIndex = 3;
            this.tabBanAn.Text = "Bàn ăn";
            this.tabBanAn.UseVisualStyleBackColor = true;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.dtgvTable);
            this.panel20.Location = new System.Drawing.Point(5, 60);
            this.panel20.Margin = new System.Windows.Forms.Padding(2);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(308, 325);
            this.panel20.TabIndex = 10;
            // 
            // dtgvTable
            // 
            this.dtgvTable.AllowUserToAddRows = false;
            this.dtgvTable.AllowUserToDeleteRows = false;
            this.dtgvTable.AllowUserToResizeColumns = false;
            this.dtgvTable.AllowUserToResizeRows = false;
            this.dtgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTable.Location = new System.Drawing.Point(2, 4);
            this.dtgvTable.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.RowHeadersWidth = 51;
            this.dtgvTable.RowTemplate.Height = 24;
            this.dtgvTable.Size = new System.Drawing.Size(302, 319);
            this.dtgvTable.TabIndex = 7;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnShowTable);
            this.panel11.Controls.Add(this.btnEditTable);
            this.panel11.Controls.Add(this.btnDelTable);
            this.panel11.Controls.Add(this.btnAddTable);
            this.panel11.Location = new System.Drawing.Point(4, 5);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(308, 51);
            this.panel11.TabIndex = 8;
            // 
            // btnShowTable
            // 
            this.btnShowTable.Location = new System.Drawing.Point(238, 2);
            this.btnShowTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(68, 46);
            this.btnShowTable.TabIndex = 3;
            this.btnShowTable.Text = "Xem";
            this.btnShowTable.UseVisualStyleBackColor = true;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // btnEditTable
            // 
            this.btnEditTable.Location = new System.Drawing.Point(163, 2);
            this.btnEditTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(70, 46);
            this.btnEditTable.TabIndex = 2;
            this.btnEditTable.Text = "Sửa";
            this.btnEditTable.UseVisualStyleBackColor = true;
            this.btnEditTable.Click += new System.EventHandler(this.btnEditTable_Click);
            // 
            // btnDelTable
            // 
            this.btnDelTable.Location = new System.Drawing.Point(83, 2);
            this.btnDelTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelTable.Name = "btnDelTable";
            this.btnDelTable.Size = new System.Drawing.Size(75, 46);
            this.btnDelTable.TabIndex = 1;
            this.btnDelTable.Text = "Xóa";
            this.btnDelTable.UseVisualStyleBackColor = true;
            this.btnDelTable.Click += new System.EventHandler(this.btnDelTable_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(2, 2);
            this.btnAddTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(76, 46);
            this.btnAddTable.TabIndex = 0;
            this.btnAddTable.Text = "Thêm ";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.panel21);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Controls.Add(this.panel19);
            this.panel14.Location = new System.Drawing.Point(317, 61);
            this.panel14.Margin = new System.Windows.Forms.Padding(2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(240, 323);
            this.panel14.TabIndex = 9;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.cbStatus);
            this.panel21.Controls.Add(this.lblTrangThaiTable);
            this.panel21.Location = new System.Drawing.Point(2, 109);
            this.panel21.Margin = new System.Windows.Forms.Padding(2);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(238, 48);
            this.panel21.TabIndex = 3;
            // 
            // cbStatus
            // 
            this.cbStatus.Enabled = false;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(107, 11);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(124, 21);
            this.cbStatus.TabIndex = 1;
            // 
            // lblTrangThaiTable
            // 
            this.lblTrangThaiTable.AutoSize = true;
            this.lblTrangThaiTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThaiTable.Location = new System.Drawing.Point(3, 15);
            this.lblTrangThaiTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrangThaiTable.Name = "lblTrangThaiTable";
            this.lblTrangThaiTable.Size = new System.Drawing.Size(88, 17);
            this.lblTrangThaiTable.TabIndex = 0;
            this.lblTrangThaiTable.Text = "Trạng thái:";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txbTenBan);
            this.panel15.Controls.Add(this.lblTenBan);
            this.panel15.Location = new System.Drawing.Point(2, 56);
            this.panel15.Margin = new System.Windows.Forms.Padding(2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(238, 48);
            this.panel15.TabIndex = 2;
            // 
            // txbTenBan
            // 
            this.txbTenBan.Location = new System.Drawing.Point(107, 13);
            this.txbTenBan.Margin = new System.Windows.Forms.Padding(2);
            this.txbTenBan.Name = "txbTenBan";
            this.txbTenBan.Size = new System.Drawing.Size(124, 20);
            this.txbTenBan.TabIndex = 1;
            // 
            // lblTenBan
            // 
            this.lblTenBan.AutoSize = true;
            this.lblTenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBan.Location = new System.Drawing.Point(3, 15);
            this.lblTenBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenBan.Name = "lblTenBan";
            this.lblTenBan.Size = new System.Drawing.Size(73, 17);
            this.lblTenBan.TabIndex = 0;
            this.lblTenBan.Text = "Tên bàn:";
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.txbIDTable);
            this.panel19.Controls.Add(this.lblIDTable);
            this.panel19.Location = new System.Drawing.Point(3, 3);
            this.panel19.Margin = new System.Windows.Forms.Padding(2);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(235, 48);
            this.panel19.TabIndex = 0;
            // 
            // txbIDTable
            // 
            this.txbIDTable.Enabled = false;
            this.txbIDTable.Location = new System.Drawing.Point(110, 12);
            this.txbIDTable.Margin = new System.Windows.Forms.Padding(2);
            this.txbIDTable.Name = "txbIDTable";
            this.txbIDTable.Size = new System.Drawing.Size(124, 20);
            this.txbIDTable.TabIndex = 1;
            // 
            // lblIDTable
            // 
            this.lblIDTable.AutoSize = true;
            this.lblIDTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDTable.Location = new System.Drawing.Point(3, 15);
            this.lblIDTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDTable.Name = "lblIDTable";
            this.lblIDTable.Size = new System.Drawing.Size(28, 17);
            this.lblIDTable.TabIndex = 0;
            this.lblIDTable.Text = "ID:";
            // 
            // tabDanhMuc
            // 
            this.tabDanhMuc.Controls.Add(this.panel18);
            this.tabDanhMuc.Controls.Add(this.panel12);
            this.tabDanhMuc.Controls.Add(this.panel13);
            this.tabDanhMuc.Location = new System.Drawing.Point(4, 22);
            this.tabDanhMuc.Margin = new System.Windows.Forms.Padding(2);
            this.tabDanhMuc.Name = "tabDanhMuc";
            this.tabDanhMuc.Padding = new System.Windows.Forms.Padding(2);
            this.tabDanhMuc.Size = new System.Drawing.Size(558, 386);
            this.tabDanhMuc.TabIndex = 2;
            this.tabDanhMuc.Text = "Danh mục";
            this.tabDanhMuc.UseVisualStyleBackColor = true;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.dtgvCategory);
            this.panel18.Location = new System.Drawing.Point(4, 60);
            this.panel18.Margin = new System.Windows.Forms.Padding(2);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(308, 323);
            this.panel18.TabIndex = 7;
            // 
            // dtgvCategory
            // 
            this.dtgvCategory.AllowUserToAddRows = false;
            this.dtgvCategory.AllowUserToDeleteRows = false;
            this.dtgvCategory.AllowUserToResizeColumns = false;
            this.dtgvCategory.AllowUserToResizeRows = false;
            this.dtgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategory.Location = new System.Drawing.Point(3, 3);
            this.dtgvCategory.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvCategory.Name = "dtgvCategory";
            this.dtgvCategory.RowHeadersWidth = 51;
            this.dtgvCategory.RowTemplate.Height = 24;
            this.dtgvCategory.Size = new System.Drawing.Size(303, 318);
            this.dtgvCategory.TabIndex = 3;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnShowCategory);
            this.panel12.Controls.Add(this.btnEditCategory);
            this.panel12.Controls.Add(this.btnDelCategory);
            this.panel12.Controls.Add(this.btnAddCategory);
            this.panel12.Location = new System.Drawing.Point(4, 5);
            this.panel12.Margin = new System.Windows.Forms.Padding(2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(308, 51);
            this.panel12.TabIndex = 4;
            // 
            // btnShowCategory
            // 
            this.btnShowCategory.Location = new System.Drawing.Point(238, 2);
            this.btnShowCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowCategory.Name = "btnShowCategory";
            this.btnShowCategory.Size = new System.Drawing.Size(68, 46);
            this.btnShowCategory.TabIndex = 3;
            this.btnShowCategory.Text = "Xem";
            this.btnShowCategory.UseVisualStyleBackColor = true;
            this.btnShowCategory.Click += new System.EventHandler(this.btnShowCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(163, 2);
            this.btnEditCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(70, 46);
            this.btnEditCategory.TabIndex = 2;
            this.btnEditCategory.Text = "Sửa";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnDelCategory
            // 
            this.btnDelCategory.Location = new System.Drawing.Point(83, 2);
            this.btnDelCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelCategory.Name = "btnDelCategory";
            this.btnDelCategory.Size = new System.Drawing.Size(75, 46);
            this.btnDelCategory.TabIndex = 1;
            this.btnDelCategory.Text = "Xóa";
            this.btnDelCategory.UseVisualStyleBackColor = true;
            this.btnDelCategory.Click += new System.EventHandler(this.btnDelCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(2, 2);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(76, 46);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "Thêm ";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.panel16);
            this.panel13.Controls.Add(this.panel17);
            this.panel13.Location = new System.Drawing.Point(317, 60);
            this.panel13.Margin = new System.Windows.Forms.Padding(2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(240, 325);
            this.panel13.TabIndex = 6;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.txbTenDanhMuc);
            this.panel16.Controls.Add(this.lblTenDanhMuc);
            this.panel16.Location = new System.Drawing.Point(3, 56);
            this.panel16.Margin = new System.Windows.Forms.Padding(2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(237, 48);
            this.panel16.TabIndex = 2;
            // 
            // txbTenDanhMuc
            // 
            this.txbTenDanhMuc.Location = new System.Drawing.Point(116, 13);
            this.txbTenDanhMuc.Margin = new System.Windows.Forms.Padding(2);
            this.txbTenDanhMuc.Name = "txbTenDanhMuc";
            this.txbTenDanhMuc.Size = new System.Drawing.Size(116, 20);
            this.txbTenDanhMuc.TabIndex = 1;
            // 
            // lblTenDanhMuc
            // 
            this.lblTenDanhMuc.AutoSize = true;
            this.lblTenDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDanhMuc.Location = new System.Drawing.Point(3, 15);
            this.lblTenDanhMuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenDanhMuc.Name = "lblTenDanhMuc";
            this.lblTenDanhMuc.Size = new System.Drawing.Size(116, 17);
            this.lblTenDanhMuc.TabIndex = 0;
            this.lblTenDanhMuc.Text = "Tên danh mục:";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.txbIDDanhMuc);
            this.panel17.Controls.Add(this.lblIDDanhMuc);
            this.panel17.Location = new System.Drawing.Point(3, 3);
            this.panel17.Margin = new System.Windows.Forms.Padding(2);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(235, 48);
            this.panel17.TabIndex = 0;
            // 
            // txbIDDanhMuc
            // 
            this.txbIDDanhMuc.Enabled = false;
            this.txbIDDanhMuc.Location = new System.Drawing.Point(116, 12);
            this.txbIDDanhMuc.Margin = new System.Windows.Forms.Padding(2);
            this.txbIDDanhMuc.Name = "txbIDDanhMuc";
            this.txbIDDanhMuc.Size = new System.Drawing.Size(118, 20);
            this.txbIDDanhMuc.TabIndex = 1;
            // 
            // lblIDDanhMuc
            // 
            this.lblIDDanhMuc.AutoSize = true;
            this.lblIDDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDDanhMuc.Location = new System.Drawing.Point(3, 15);
            this.lblIDDanhMuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDDanhMuc.Name = "lblIDDanhMuc";
            this.lblIDDanhMuc.Size = new System.Drawing.Size(28, 17);
            this.lblIDDanhMuc.TabIndex = 0;
            this.lblIDDanhMuc.Text = "ID:";
            // 
            // tabDoanhThu
            // 
            this.tabDoanhThu.Controls.Add(this.panel2);
            this.tabDoanhThu.Controls.Add(this.plDoanhthu);
            this.tabDoanhThu.Location = new System.Drawing.Point(4, 22);
            this.tabDoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.tabDoanhThu.Name = "tabDoanhThu";
            this.tabDoanhThu.Padding = new System.Windows.Forms.Padding(2);
            this.tabDoanhThu.Size = new System.Drawing.Size(558, 386);
            this.tabDoanhThu.TabIndex = 0;
            this.tabDoanhThu.Text = "Doanh thu";
            this.tabDoanhThu.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThongKe);
            this.panel2.Controls.Add(this.dtpkToDate);
            this.panel2.Controls.Add(this.dtpkFromDate);
            this.panel2.Location = new System.Drawing.Point(5, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 40);
            this.panel2.TabIndex = 3;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(238, 11);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(76, 19);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Location = new System.Drawing.Point(357, 11);
            this.dtpkToDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(180, 20);
            this.dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.CustomFormat = "";
            this.dtpkFromDate.Location = new System.Drawing.Point(12, 10);
            this.dtpkFromDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(180, 20);
            this.dtpkFromDate.TabIndex = 0;
            // 
            // plDoanhthu
            // 
            this.plDoanhthu.Controls.Add(this.txbNumPage);
            this.plDoanhthu.Controls.Add(this.btnPreviousBillsPage);
            this.plDoanhthu.Controls.Add(this.btnLastBillsPage);
            this.plDoanhthu.Controls.Add(this.btnFirstBillsPage);
            this.plDoanhthu.Controls.Add(this.dtgvDoanhThu);
            this.plDoanhthu.Location = new System.Drawing.Point(4, 49);
            this.plDoanhthu.Margin = new System.Windows.Forms.Padding(2);
            this.plDoanhthu.Name = "plDoanhthu";
            this.plDoanhthu.Size = new System.Drawing.Size(550, 336);
            this.plDoanhthu.TabIndex = 2;
            // 
            // txbNumPage
            // 
            this.txbNumPage.Location = new System.Drawing.Point(239, 309);
            this.txbNumPage.Name = "txbNumPage";
            this.txbNumPage.ReadOnly = true;
            this.txbNumPage.Size = new System.Drawing.Size(76, 20);
            this.txbNumPage.TabIndex = 5;
            this.txbNumPage.Text = "0";
            this.txbNumPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbNumPage.TextChanged += new System.EventHandler(this.txbNumPage_TextChanged);
            // 
            // btnPreviousBillsPage
            // 
            this.btnPreviousBillsPage.Location = new System.Drawing.Point(84, 309);
            this.btnPreviousBillsPage.Name = "btnPreviousBillsPage";
            this.btnPreviousBillsPage.Size = new System.Drawing.Size(75, 23);
            this.btnPreviousBillsPage.TabIndex = 3;
            this.btnPreviousBillsPage.Text = "Previous";
            this.btnPreviousBillsPage.UseVisualStyleBackColor = true;
            this.btnPreviousBillsPage.Click += new System.EventHandler(this.btnPreviousBillsPage_Click);
            // 
            // btnLastBillsPage
            // 
            this.btnLastBillsPage.Location = new System.Drawing.Point(472, 309);
            this.btnLastBillsPage.Name = "btnLastBillsPage";
            this.btnLastBillsPage.Size = new System.Drawing.Size(75, 23);
            this.btnLastBillsPage.TabIndex = 2;
            this.btnLastBillsPage.Text = "Last";
            this.btnLastBillsPage.UseVisualStyleBackColor = true;
            this.btnLastBillsPage.Click += new System.EventHandler(this.btnLastBillsPage_Click);
            // 
            // btnFirstBillsPage
            // 
            this.btnFirstBillsPage.Location = new System.Drawing.Point(3, 309);
            this.btnFirstBillsPage.Name = "btnFirstBillsPage";
            this.btnFirstBillsPage.Size = new System.Drawing.Size(75, 23);
            this.btnFirstBillsPage.TabIndex = 1;
            this.btnFirstBillsPage.Text = "First";
            this.btnFirstBillsPage.UseVisualStyleBackColor = true;
            this.btnFirstBillsPage.Click += new System.EventHandler(this.btnFirstBillsPage_Click);
            // 
            // dtgvDoanhThu
            // 
            this.dtgvDoanhThu.AllowUserToAddRows = false;
            this.dtgvDoanhThu.AllowUserToDeleteRows = false;
            this.dtgvDoanhThu.AllowUserToResizeColumns = false;
            this.dtgvDoanhThu.AllowUserToResizeRows = false;
            this.dtgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDoanhThu.Location = new System.Drawing.Point(2, 2);
            this.dtgvDoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvDoanhThu.Name = "dtgvDoanhThu";
            this.dtgvDoanhThu.RowHeadersWidth = 51;
            this.dtgvDoanhThu.RowTemplate.Height = 24;
            this.dtgvDoanhThu.Size = new System.Drawing.Size(548, 303);
            this.dtgvDoanhThu.TabIndex = 0;
            // 
            // rpViewer
            // 
            this.rpViewer.Controls.Add(this.tabDoanhThu);
            this.rpViewer.Controls.Add(this.tabFood);
            this.rpViewer.Controls.Add(this.tabDanhMuc);
            this.rpViewer.Controls.Add(this.tabBanAn);
            this.rpViewer.Controls.Add(this.tabTaiKhoan);
            this.rpViewer.Controls.Add(this.report);
            this.rpViewer.Location = new System.Drawing.Point(10, 11);
            this.rpViewer.Margin = new System.Windows.Forms.Padding(2);
            this.rpViewer.Name = "rpViewer";
            this.rpViewer.SelectedIndex = 0;
            this.rpViewer.Size = new System.Drawing.Size(566, 412);
            this.rpViewer.TabIndex = 0;
            // 
            // tabFood
            // 
            this.tabFood.Controls.Add(this.panel6);
            this.tabFood.Controls.Add(this.panel5);
            this.tabFood.Controls.Add(this.panel4);
            this.tabFood.Controls.Add(this.panel3);
            this.tabFood.Location = new System.Drawing.Point(4, 22);
            this.tabFood.Margin = new System.Windows.Forms.Padding(2);
            this.tabFood.Name = "tabFood";
            this.tabFood.Padding = new System.Windows.Forms.Padding(2);
            this.tabFood.Size = new System.Drawing.Size(558, 386);
            this.tabFood.TabIndex = 1;
            this.tabFood.Text = "Thức ăn";
            this.tabFood.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbSearch);
            this.panel6.Controls.Add(this.btnTim);
            this.panel6.Location = new System.Drawing.Point(317, 5);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 51);
            this.panel6.TabIndex = 2;
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(11, 18);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(147, 20);
            this.txbSearch.TabIndex = 5;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(162, 2);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(76, 46);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(317, 61);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 323);
            this.panel5.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.nmFoodPrice);
            this.panel10.Controls.Add(this.lblGia);
            this.panel10.Location = new System.Drawing.Point(5, 162);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(235, 48);
            this.panel10.TabIndex = 3;
            // 
            // nmFoodPrice
            // 
            this.nmFoodPrice.Location = new System.Drawing.Point(101, 12);
            this.nmFoodPrice.Margin = new System.Windows.Forms.Padding(2);
            this.nmFoodPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmFoodPrice.Name = "nmFoodPrice";
            this.nmFoodPrice.Size = new System.Drawing.Size(129, 20);
            this.nmFoodPrice.TabIndex = 1;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(3, 15);
            this.lblGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(38, 17);
            this.lblGia.TabIndex = 0;
            this.lblGia.Text = "Giá:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbFoodCategory);
            this.panel9.Controls.Add(this.lblDanhMuc);
            this.panel9.Location = new System.Drawing.Point(5, 109);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(235, 48);
            this.panel9.TabIndex = 3;
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(101, 11);
            this.cbFoodCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(130, 21);
            this.cbFoodCategory.TabIndex = 1;
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhMuc.Location = new System.Drawing.Point(3, 15);
            this.lblDanhMuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(85, 17);
            this.lblDanhMuc.TabIndex = 0;
            this.lblDanhMuc.Text = "Danh mục:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txbFoodName);
            this.panel8.Controls.Add(this.lblTenMon);
            this.panel8.Location = new System.Drawing.Point(5, 56);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(235, 48);
            this.panel8.TabIndex = 2;
            // 
            // txbFoodName
            // 
            this.txbFoodName.Location = new System.Drawing.Point(101, 13);
            this.txbFoodName.Margin = new System.Windows.Forms.Padding(2);
            this.txbFoodName.Name = "txbFoodName";
            this.txbFoodName.Size = new System.Drawing.Size(130, 20);
            this.txbFoodName.TabIndex = 1;
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMon.Location = new System.Drawing.Point(3, 15);
            this.lblTenMon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(76, 17);
            this.lblTenMon.TabIndex = 0;
            this.lblTenMon.Text = "Tên món:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbFoodID);
            this.panel7.Controls.Add(this.lblID);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(235, 48);
            this.panel7.TabIndex = 0;
            // 
            // txbFoodID
            // 
            this.txbFoodID.Enabled = false;
            this.txbFoodID.Location = new System.Drawing.Point(104, 12);
            this.txbFoodID.Margin = new System.Windows.Forms.Padding(2);
            this.txbFoodID.Name = "txbFoodID";
            this.txbFoodID.Size = new System.Drawing.Size(130, 20);
            this.txbFoodID.TabIndex = 1;
            this.txbFoodID.TextChanged += new System.EventHandler(this.txbFoodID_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(3, 15);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnXemFood);
            this.panel4.Controls.Add(this.btnSuaFood);
            this.panel4.Controls.Add(this.btnXoaFood);
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Location = new System.Drawing.Point(4, 5);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(308, 51);
            this.panel4.TabIndex = 1;
            // 
            // btnXemFood
            // 
            this.btnXemFood.Location = new System.Drawing.Point(238, 2);
            this.btnXemFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnXemFood.Name = "btnXemFood";
            this.btnXemFood.Size = new System.Drawing.Size(68, 46);
            this.btnXemFood.TabIndex = 3;
            this.btnXemFood.Text = "Xem";
            this.btnXemFood.UseVisualStyleBackColor = true;
            this.btnXemFood.Click += new System.EventHandler(this.btnXemFood_Click);
            // 
            // btnSuaFood
            // 
            this.btnSuaFood.Location = new System.Drawing.Point(163, 2);
            this.btnSuaFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaFood.Name = "btnSuaFood";
            this.btnSuaFood.Size = new System.Drawing.Size(70, 46);
            this.btnSuaFood.TabIndex = 2;
            this.btnSuaFood.Text = "Sửa";
            this.btnSuaFood.UseVisualStyleBackColor = true;
            this.btnSuaFood.Click += new System.EventHandler(this.btnSuaFood_Click);
            // 
            // btnXoaFood
            // 
            this.btnXoaFood.Location = new System.Drawing.Point(83, 2);
            this.btnXoaFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaFood.Name = "btnXoaFood";
            this.btnXoaFood.Size = new System.Drawing.Size(75, 46);
            this.btnXoaFood.TabIndex = 1;
            this.btnXoaFood.Text = "Xóa";
            this.btnXoaFood.UseVisualStyleBackColor = true;
            this.btnXoaFood.Click += new System.EventHandler(this.btnXoaFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(2, 2);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(76, 46);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Thêm ";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvFood);
            this.panel3.Location = new System.Drawing.Point(3, 61);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 323);
            this.panel3.TabIndex = 0;
            // 
            // dtgvFood
            // 
            this.dtgvFood.AllowUserToAddRows = false;
            this.dtgvFood.AllowUserToDeleteRows = false;
            this.dtgvFood.AllowUserToResizeColumns = false;
            this.dtgvFood.AllowUserToResizeRows = false;
            this.dtgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(3, 2);
            this.dtgvFood.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.RowHeadersWidth = 51;
            this.dtgvFood.RowTemplate.Height = 24;
            this.dtgvFood.Size = new System.Drawing.Size(303, 318);
            this.dtgvFood.TabIndex = 4;
            // 
            // report
            // 
            this.report.Controls.Add(this.reportViewer1);
            this.report.Location = new System.Drawing.Point(4, 22);
            this.report.Name = "report";
            this.report.Padding = new System.Windows.Forms.Padding(3);
            this.report.Size = new System.Drawing.Size(558, 386);
            this.report.TabIndex = 5;
            this.report.Text = "Report";
            this.report.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uSPGetListBillByDateForReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PhanMemQuanLyQuanCAFE.Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(552, 380);
            this.reportViewer1.TabIndex = 0;
            // 
            // quanLyQuanCaPheDataSet1
            // 
            this.quanLyQuanCaPheDataSet1.DataSetName = "QuanLyQuanCaPheDataSet1";
            this.quanLyQuanCaPheDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPGetListBillByDateForReportBindingSource
            // 
            this.uSPGetListBillByDateForReportBindingSource.DataMember = "USP_GetListBillByDateForReport";
            this.uSPGetListBillByDateForReportBindingSource.DataSource = this.quanLyQuanCaPheDataSet1;
            // 
            // uSP_GetListBillByDateForReportTableAdapter
            // 
            this.uSP_GetListBillByDateForReportTableAdapter.ClearBeforeFill = true;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 432);
            this.Controls.Add(this.rpViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao diện Admin";
            this.Load += new System.EventHandler(this.fAdmin_Load_1);
            this.tabTaiKhoan.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAccountType)).EndInit();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.panel28.ResumeLayout(false);
            this.panel29.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.tabBanAn.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.tabDanhMuc.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.tabDoanhThu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.plDoanhthu.ResumeLayout(false);
            this.plDoanhthu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoanhThu)).EndInit();
            this.rpViewer.ResumeLayout(false);
            this.tabFood.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.report.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyQuanCaPheDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateForReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabTaiKhoan;
        private System.Windows.Forms.TabPage tabBanAn;
        private System.Windows.Forms.TabPage tabDanhMuc;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnShowCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnDelCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.DataGridView dtgvCategory;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox txbIDDanhMuc;
        private System.Windows.Forms.Label lblIDDanhMuc;
        private System.Windows.Forms.TabPage tabDoanhThu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.Panel plDoanhthu;
        private System.Windows.Forms.DataGridView dtgvDoanhThu;
        private System.Windows.Forms.TabControl rpViewer;
        private System.Windows.Forms.TabPage tabFood;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.NumericUpDown nmFoodPrice;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txbFoodName;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txbFoodID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnXemFood;
        private System.Windows.Forms.Button btnSuaFood;
        private System.Windows.Forms.Button btnXoaFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.DataGridView dtgvTable;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnShowTable;
        private System.Windows.Forms.Button btnEditTable;
        private System.Windows.Forms.Button btnDelTable;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblTrangThaiTable;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txbTenBan;
        private System.Windows.Forms.Label lblTenBan;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.TextBox txbIDTable;
        private System.Windows.Forms.Label lblIDTable;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.TextBox txbAccountName;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnDelAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Button btnResetPassWord;
        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.TextBox txbTenDanhMuc;
        private System.Windows.Forms.Label lblTenDanhMuc;
        private System.Windows.Forms.NumericUpDown nmAccountType;
        private System.Windows.Forms.Button btnPreviousBillsPage;
        private System.Windows.Forms.Button btnLastBillsPage;
        private System.Windows.Forms.Button btnFirstBillsPage;
        private System.Windows.Forms.TextBox txbNumPage;
        private System.Windows.Forms.TabPage report;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPGetListBillByDateForReportBindingSource;
        private QuanLyQuanCaPheDataSet1 quanLyQuanCaPheDataSet1;
        private QuanLyQuanCaPheDataSet1TableAdapters.USP_GetListBillByDateForReportTableAdapter uSP_GetListBillByDateForReportTableAdapter;
    }
}