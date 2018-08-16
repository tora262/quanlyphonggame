namespace ADMIN_Control
{
    partial class frmTaoTK
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dTPNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.TxtSoDT = new System.Windows.Forms.TextBox();
            this.LbSDT = new System.Windows.Forms.Label();
            this.LbNgaySinh = new System.Windows.Forms.Label();
            this.LbGioiTinh = new System.Windows.Forms.Label();
            this.LbTenKH = new System.Windows.Forms.Label();
            this.TxtTenKH = new System.Windows.Forms.TextBox();
            this.TxtMK2 = new System.Windows.Forms.TextBox();
            this.LbMK2 = new System.Windows.Forms.Label();
            this.TxtNap = new System.Windows.Forms.TextBox();
            this.TxtMK = new System.Windows.Forms.TextBox();
            this.TxtTenTK = new System.Windows.Forms.TextBox();
            this.LbNap = new System.Windows.Forms.Label();
            this.LbMK = new System.Windows.Forms.Label();
            this.LbTenTk = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtChuThich = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnTaoTK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dTPNgaySinh);
            this.panel1.Controls.Add(this.cbGioiTinh);
            this.panel1.Controls.Add(this.TxtSoDT);
            this.panel1.Controls.Add(this.LbSDT);
            this.panel1.Controls.Add(this.LbNgaySinh);
            this.panel1.Controls.Add(this.LbGioiTinh);
            this.panel1.Controls.Add(this.LbTenKH);
            this.panel1.Controls.Add(this.TxtTenKH);
            this.panel1.Controls.Add(this.TxtMK2);
            this.panel1.Controls.Add(this.LbMK2);
            this.panel1.Controls.Add(this.TxtNap);
            this.panel1.Controls.Add(this.TxtMK);
            this.panel1.Controls.Add(this.TxtTenTK);
            this.panel1.Controls.Add(this.LbNap);
            this.panel1.Controls.Add(this.LbMK);
            this.panel1.Controls.Add(this.LbTenTk);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 339);
            this.panel1.TabIndex = 0;
            // 
            // dTPNgaySinh
            // 
            this.dTPNgaySinh.Location = new System.Drawing.Point(101, 216);
            this.dTPNgaySinh.Name = "dTPNgaySinh";
            this.dTPNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dTPNgaySinh.TabIndex = 19;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Không xác định"});
            this.cbGioiTinh.Location = new System.Drawing.Point(101, 182);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(121, 21);
            this.cbGioiTinh.TabIndex = 18;
            // 
            // TxtSoDT
            // 
            this.TxtSoDT.Location = new System.Drawing.Point(101, 255);
            this.TxtSoDT.Name = "TxtSoDT";
            this.TxtSoDT.Size = new System.Drawing.Size(173, 20);
            this.TxtSoDT.TabIndex = 17;
            // 
            // LbSDT
            // 
            this.LbSDT.AutoSize = true;
            this.LbSDT.Location = new System.Drawing.Point(3, 258);
            this.LbSDT.Name = "LbSDT";
            this.LbSDT.Size = new System.Drawing.Size(73, 13);
            this.LbSDT.TabIndex = 16;
            this.LbSDT.Text = "Số điện thoại:";
            // 
            // LbNgaySinh
            // 
            this.LbNgaySinh.AutoSize = true;
            this.LbNgaySinh.Location = new System.Drawing.Point(3, 222);
            this.LbNgaySinh.Name = "LbNgaySinh";
            this.LbNgaySinh.Size = new System.Drawing.Size(59, 13);
            this.LbNgaySinh.TabIndex = 15;
            this.LbNgaySinh.Text = "Ngày Sinh:";
            // 
            // LbGioiTinh
            // 
            this.LbGioiTinh.AutoSize = true;
            this.LbGioiTinh.Location = new System.Drawing.Point(3, 185);
            this.LbGioiTinh.Name = "LbGioiTinh";
            this.LbGioiTinh.Size = new System.Drawing.Size(54, 13);
            this.LbGioiTinh.TabIndex = 14;
            this.LbGioiTinh.Text = "Giới Tính:";
            // 
            // LbTenKH
            // 
            this.LbTenKH.AutoSize = true;
            this.LbTenKH.Location = new System.Drawing.Point(3, 146);
            this.LbTenKH.Name = "LbTenKH";
            this.LbTenKH.Size = new System.Drawing.Size(92, 13);
            this.LbTenKH.TabIndex = 13;
            this.LbTenKH.Text = "Tên Khách Hàng:";
            // 
            // TxtTenKH
            // 
            this.TxtTenKH.Location = new System.Drawing.Point(101, 143);
            this.TxtTenKH.Name = "TxtTenKH";
            this.TxtTenKH.Size = new System.Drawing.Size(173, 20);
            this.TxtTenKH.TabIndex = 10;
            // 
            // TxtMK2
            // 
            this.TxtMK2.Location = new System.Drawing.Point(101, 104);
            this.TxtMK2.Name = "TxtMK2";
            this.TxtMK2.Size = new System.Drawing.Size(173, 20);
            this.TxtMK2.TabIndex = 9;
            this.TxtMK2.UseSystemPasswordChar = true;
            this.TxtMK2.Click += new System.EventHandler(this.TxtMK2_Click);
            this.TxtMK2.TextChanged += new System.EventHandler(this.TxtMK2_TextChanged);
            // 
            // LbMK2
            // 
            this.LbMK2.AutoSize = true;
            this.LbMK2.Location = new System.Drawing.Point(3, 107);
            this.LbMK2.Name = "LbMK2";
            this.LbMK2.Size = new System.Drawing.Size(72, 13);
            this.LbMK2.TabIndex = 8;
            this.LbMK2.Text = "Nhập lại MK*:";
            // 
            // TxtNap
            // 
            this.TxtNap.Location = new System.Drawing.Point(101, 300);
            this.TxtNap.Name = "TxtNap";
            this.TxtNap.Size = new System.Drawing.Size(73, 20);
            this.TxtNap.TabIndex = 7;
            this.TxtNap.Click += new System.EventHandler(this.textBox4_Click);
            this.TxtNap.TextChanged += new System.EventHandler(this.TxtNap_TextChanged);
            // 
            // TxtMK
            // 
            this.TxtMK.Location = new System.Drawing.Point(101, 66);
            this.TxtMK.Name = "TxtMK";
            this.TxtMK.Size = new System.Drawing.Size(173, 20);
            this.TxtMK.TabIndex = 5;
            this.TxtMK.UseSystemPasswordChar = true;
            this.TxtMK.Click += new System.EventHandler(this.textBox2_Click);
            this.TxtMK.TextChanged += new System.EventHandler(this.TxtMK_TextChanged);
            // 
            // TxtTenTK
            // 
            this.TxtTenTK.Location = new System.Drawing.Point(101, 27);
            this.TxtTenTK.Name = "TxtTenTK";
            this.TxtTenTK.Size = new System.Drawing.Size(173, 20);
            this.TxtTenTK.TabIndex = 4;
            this.TxtTenTK.Click += new System.EventHandler(this.textBox1_Click);
            this.TxtTenTK.TextChanged += new System.EventHandler(this.TxtTenTK_TextChanged);
            // 
            // LbNap
            // 
            this.LbNap.AutoSize = true;
            this.LbNap.Location = new System.Drawing.Point(5, 303);
            this.LbNap.Name = "LbNap";
            this.LbNap.Size = new System.Drawing.Size(58, 13);
            this.LbNap.TabIndex = 3;
            this.LbNap.Text = "Tiền Nạp*:";
            // 
            // LbMK
            // 
            this.LbMK.AutoSize = true;
            this.LbMK.Location = new System.Drawing.Point(3, 69);
            this.LbMK.Name = "LbMK";
            this.LbMK.Size = new System.Drawing.Size(60, 13);
            this.LbMK.TabIndex = 1;
            this.LbMK.Text = "Mật Khẩu*:";
            // 
            // LbTenTk
            // 
            this.LbTenTk.AutoSize = true;
            this.LbTenTk.Location = new System.Drawing.Point(3, 30);
            this.LbTenTk.Name = "LbTenTk";
            this.LbTenTk.Size = new System.Drawing.Size(85, 13);
            this.LbTenTk.TabIndex = 0;
            this.LbTenTk.Text = "Tên Tài Khoản*:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TxtChuThich);
            this.panel2.Location = new System.Drawing.Point(340, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 125);
            this.panel2.TabIndex = 1;
            // 
            // TxtChuThich
            // 
            this.TxtChuThich.Location = new System.Drawing.Point(3, 3);
            this.TxtChuThich.Multiline = true;
            this.TxtChuThich.Name = "TxtChuThich";
            this.TxtChuThich.ReadOnly = true;
            this.TxtChuThich.Size = new System.Drawing.Size(194, 119);
            this.TxtChuThich.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnTaoTK);
            this.panel3.Location = new System.Drawing.Point(386, 292);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(121, 59);
            this.panel3.TabIndex = 2;
            // 
            // BtnTaoTK
            // 
            this.BtnTaoTK.Enabled = false;
            this.BtnTaoTK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnTaoTK.Location = new System.Drawing.Point(3, 3);
            this.BtnTaoTK.Name = "BtnTaoTK";
            this.BtnTaoTK.Size = new System.Drawing.Size(115, 53);
            this.BtnTaoTK.TabIndex = 0;
            this.BtnTaoTK.Text = "Tạo Tài Khoản";
            this.BtnTaoTK.UseVisualStyleBackColor = true;
            this.BtnTaoTK.Click += new System.EventHandler(this.BtnTaoTK_Click);
            // 
            // frmTaoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 363);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmTaoTK";
            this.Text = "TaoTK";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbNap;
        private System.Windows.Forms.Label LbMK;
        private System.Windows.Forms.Label LbTenTk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtNap;
        private System.Windows.Forms.TextBox TxtMK;
        private System.Windows.Forms.TextBox TxtTenTK;
        private System.Windows.Forms.TextBox TxtChuThich;
        private System.Windows.Forms.Button BtnTaoTK;
        private System.Windows.Forms.TextBox TxtMK2;
        private System.Windows.Forms.Label LbMK2;
        private System.Windows.Forms.TextBox TxtSoDT;
        private System.Windows.Forms.Label LbSDT;
        private System.Windows.Forms.Label LbNgaySinh;
        private System.Windows.Forms.Label LbGioiTinh;
        private System.Windows.Forms.Label LbTenKH;
        private System.Windows.Forms.TextBox TxtTenKH;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.DateTimePicker dTPNgaySinh;
    }
}