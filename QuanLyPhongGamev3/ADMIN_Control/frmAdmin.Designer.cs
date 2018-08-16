namespace ADMIN_Control
{
    partial class Admin
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
            this.tbAdmin = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.LbTenTk = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewAd1 = new System.Windows.Forms.DataGridView();
            this.TenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDuTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnNap = new System.Windows.Forms.DataGridViewButtonColumn();
            this.XoaTaiKhoan = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewAd2 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtMaHD = new System.Windows.Forms.TextBox();
            this.LbMaHD = new System.Windows.Forms.Label();
            this.dataGridViewAd3 = new System.Windows.Forms.DataGridView();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.TxtReceived = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridViewAd4 = new System.Windows.Forms.DataGridView();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbAdmin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAd1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAd2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAd3)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAd4)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAdmin
            // 
            this.tbAdmin.Controls.Add(this.tabPage1);
            this.tbAdmin.Controls.Add(this.tabPage2);
            this.tbAdmin.Controls.Add(this.tabPage3);
            this.tbAdmin.Controls.Add(this.tabPage4);
            this.tbAdmin.Controls.Add(this.tabPage5);
            this.tbAdmin.Location = new System.Drawing.Point(0, 1);
            this.tbAdmin.Name = "tbAdmin";
            this.tbAdmin.SelectedIndex = 0;
            this.tbAdmin.Size = new System.Drawing.Size(767, 397);
            this.tbAdmin.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.LbTenTk);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.BtnCreate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(759, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý Tài khoản";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(549, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 23);
            this.panel1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 20);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // LbTenTk
            // 
            this.LbTenTk.AutoSize = true;
            this.LbTenTk.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.LbTenTk.Location = new System.Drawing.Point(16, 24);
            this.LbTenTk.Name = "LbTenTk";
            this.LbTenTk.Size = new System.Drawing.Size(103, 16);
            this.LbTenTk.TabIndex = 2;
            this.LbTenTk.Text = "Tên Tài khoản:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewAd1);
            this.panel2.Location = new System.Drawing.Point(-4, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 302);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewAd1
            // 
            this.dataGridViewAd1.AllowUserToAddRows = false;
            this.dataGridViewAd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAd1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenTaiKhoan,
            this.MatKhau,
            this.TenKhachHang,
            this.GioiTinh,
            this.NgaySinh,
            this.SoDienThoai,
            this.SoDuTK,
            this.BtnNap,
            this.XoaTaiKhoan});
            this.dataGridViewAd1.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewAd1.Name = "dataGridViewAd1";
            this.dataGridViewAd1.ReadOnly = true;
            this.dataGridViewAd1.Size = new System.Drawing.Size(756, 299);
            this.dataGridViewAd1.TabIndex = 0;
            this.dataGridViewAd1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAd1_CellContentClick);
            // 
            // TenTaiKhoan
            // 
            this.TenTaiKhoan.DataPropertyName = "TenTk";
            this.TenTaiKhoan.HeaderText = "Tên tài khoản";
            this.TenTaiKhoan.Name = "TenTaiKhoan";
            this.TenTaiKhoan.ReadOnly = true;
            this.TenTaiKhoan.Width = 150;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mat Khau";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            this.MatKhau.Width = 50;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "ChuTK";
            this.TenKhachHang.HeaderText = "Tên Khách Hàng";
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 50;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            this.NgaySinh.Width = 80;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // SoDuTK
            // 
            this.SoDuTK.DataPropertyName = "SoDuTaiKhoan";
            this.SoDuTK.HeaderText = "Số dư tài khoản";
            this.SoDuTK.Name = "SoDuTK";
            this.SoDuTK.ReadOnly = true;
            this.SoDuTK.Width = 80;
            // 
            // BtnNap
            // 
            this.BtnNap.HeaderText = "";
            this.BtnNap.Name = "BtnNap";
            this.BtnNap.ReadOnly = true;
            this.BtnNap.Text = "Nạp tiền";
            this.BtnNap.Width = 51;
            // 
            // XoaTaiKhoan
            // 
            this.XoaTaiKhoan.HeaderText = "";
            this.XoaTaiKhoan.Name = "XoaTaiKhoan";
            this.XoaTaiKhoan.ReadOnly = true;
            this.XoaTaiKhoan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.XoaTaiKhoan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.XoaTaiKhoan.Text = "Xóa ";
            this.XoaTaiKhoan.Width = 51;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnCreate.Location = new System.Drawing.Point(373, 13);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(121, 34);
            this.BtnCreate.TabIndex = 0;
            this.BtnCreate.Text = "Tạo Tài Khoản";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(759, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dịch vụ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewAd2);
            this.panel3.Location = new System.Drawing.Point(3, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(631, 283);
            this.panel3.TabIndex = 0;
            // 
            // dataGridViewAd2
            // 
            this.dataGridViewAd2.AllowUserToAddRows = false;
            this.dataGridViewAd2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAd2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridViewAd2.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewAd2.Name = "dataGridViewAd2";
            this.dataGridViewAd2.Size = new System.Drawing.Size(626, 278);
            this.dataGridViewAd2.TabIndex = 0;
            this.dataGridViewAd2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAd2_CellContentClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Thời gian";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Tên tài khoản";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Giá trị";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column9.Width = 60;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column10.Width = 60;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column11.Width = 60;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(759, 371);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lịch sử giao dịch";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TxtMaHD);
            this.panel4.Controls.Add(this.LbMaHD);
            this.panel4.Controls.Add(this.dataGridViewAd3);
            this.panel4.Location = new System.Drawing.Point(3, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(756, 362);
            this.panel4.TabIndex = 0;
            // 
            // TxtMaHD
            // 
            this.TxtMaHD.Location = new System.Drawing.Point(118, 19);
            this.TxtMaHD.Name = "TxtMaHD";
            this.TxtMaHD.Size = new System.Drawing.Size(151, 20);
            this.TxtMaHD.TabIndex = 2;
            this.TxtMaHD.TextChanged += new System.EventHandler(this.TxtMaHD_TextChanged);
            // 
            // LbMaHD
            // 
            this.LbMaHD.AutoSize = true;
            this.LbMaHD.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbMaHD.Location = new System.Drawing.Point(32, 21);
            this.LbMaHD.Name = "LbMaHD";
            this.LbMaHD.Size = new System.Drawing.Size(80, 15);
            this.LbMaHD.TabIndex = 1;
            this.LbMaHD.Text = "Mã Hóa Đơn:";
            // 
            // dataGridViewAd3
            // 
            this.dataGridViewAd3.AllowUserToAddRows = false;
            this.dataGridViewAd3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAd3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column15,
            this.TenTK,
            this.Column17,
            this.Column18,
            this.Ngay,
            this.Column19});
            this.dataGridViewAd3.Location = new System.Drawing.Point(0, 45);
            this.dataGridViewAd3.Name = "dataGridViewAd3";
            this.dataGridViewAd3.Size = new System.Drawing.Size(756, 317);
            this.dataGridViewAd3.TabIndex = 0;
            this.dataGridViewAd3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAd3_CellContentClick_1);
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "MaHD";
            this.Column15.HeaderText = "Mã Hóa Đơn";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 130;
            // 
            // TenTK
            // 
            this.TenTK.DataPropertyName = "TenTk";
            this.TenTK.HeaderText = "Tên tài khoản";
            this.TenTK.Name = "TenTK";
            this.TenTK.ReadOnly = true;
            this.TenTK.Width = 120;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "Loai";
            this.Column17.HeaderText = "Loại";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 50;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "GiaTri";
            this.Column18.HeaderText = "Giá trị";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Width = 70;
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngaygio";
            this.Ngay.HeaderText = "Ngày Giờ";
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            this.Ngay.Width = 150;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "ChiTiet";
            this.Column19.HeaderText = "Chi tiết";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column19.Text = "";
            this.Column19.Width = 190;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.TxtReceived);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(759, 371);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Thống kê";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // TxtReceived
            // 
            this.TxtReceived.Location = new System.Drawing.Point(75, 65);
            this.TxtReceived.Multiline = true;
            this.TxtReceived.Name = "TxtReceived";
            this.TxtReceived.Size = new System.Drawing.Size(443, 185);
            this.TxtReceived.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.BtnAdd);
            this.tabPage5.Controls.Add(this.panel5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(759, 371);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Kho hàng";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Enter += new System.EventHandler(this.tabPage5_Enter);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnAdd.Location = new System.Drawing.Point(6, 6);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(89, 34);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Nhập kho";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridViewAd4);
            this.panel5.Location = new System.Drawing.Point(2, 46);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(647, 322);
            this.panel5.TabIndex = 2;
            // 
            // dataGridViewAd4
            // 
            this.dataGridViewAd4.AllowUserToAddRows = false;
            this.dataGridViewAd4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAd4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.TenMatHang,
            this.Soluong,
            this.Column14,
            this.Column1});
            this.dataGridViewAd4.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAd4.Name = "dataGridViewAd4";
            this.dataGridViewAd4.ReadOnly = true;
            this.dataGridViewAd4.Size = new System.Drawing.Size(645, 319);
            this.dataGridViewAd4.TabIndex = 0;
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "Mã hàng";
            this.MaHang.Name = "MaHang";
            this.MaHang.ReadOnly = true;
            // 
            // TenMatHang
            // 
            this.TenMatHang.DataPropertyName = "TenHang";
            this.TenMatHang.HeaderText = "Tên mặt hàng";
            this.TenMatHang.Name = "TenMatHang";
            this.TenMatHang.ReadOnly = true;
            this.TenMatHang.Width = 200;
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "SoLuong";
            this.Soluong.HeaderText = "Số lượng còn lại";
            this.Soluong.Name = "Soluong";
            this.Soluong.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "GiaNhap";
            this.Column14.HeaderText = "Đơn giá nhập";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "GiaBan";
            this.Column1.HeaderText = "Đơn giá bán";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 396);
            this.Controls.Add(this.tbAdmin);
            this.Name = "Admin";
            this.Text = "AdminView";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tbAdmin.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAd1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAd2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAd3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAd4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbAdmin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label LbTenTk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewAd1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewAd2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridViewAd3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox TxtReceived;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView dataGridViewAd4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDuTK;
        private System.Windows.Forms.DataGridViewButtonColumn BtnNap;
        private System.Windows.Forms.DataGridViewButtonColumn XoaTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Column9;
        private System.Windows.Forms.DataGridViewButtonColumn Column10;
        private System.Windows.Forms.DataGridViewButtonColumn Column11;
        private System.Windows.Forms.TextBox TxtMaHD;
        private System.Windows.Forms.Label LbMaHD;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewButtonColumn Column19;
    }
}

