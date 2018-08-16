namespace ADMIN_Control
{
    partial class frmNhapKho
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
            this.dataGridViewNhap1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LbTong = new System.Windows.Forms.Label();
            this.TxtTong = new System.Windows.Forms.TextBox();
            this.BtnNhap = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbMathang = new System.Windows.Forms.ComboBox();
            this.BtnChon = new System.Windows.Forms.Button();
            this.TxtSoluong = new System.Windows.Forms.TextBox();
            this.TxtDongiaNhap = new System.Windows.Forms.TextBox();
            this.LbSoLuong = new System.Windows.Forms.Label();
            this.LbDongiaNhap = new System.Windows.Forms.Label();
            this.LbMatHang = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhap1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewNhap1);
            this.panel1.Location = new System.Drawing.Point(274, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 243);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewNhap1
            // 
            this.dataGridViewNhap1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhap1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewNhap1.Location = new System.Drawing.Point(3, 23);
            this.dataGridViewNhap1.Name = "dataGridViewNhap1";
            this.dataGridViewNhap1.Size = new System.Drawing.Size(403, 220);
            this.dataGridViewNhap1.TabIndex = 0;
            this.dataGridViewNhap1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNhap1_CellContentClick);
            this.dataGridViewNhap1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewNhap1_CellMouseClick);
            this.dataGridViewNhap1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewNhap1_RowStateChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên mặt hàng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 140;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Số lượng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Đơn giá nhập";
            this.Column3.Name = "Column3";
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Thành tiền";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // LbTong
            // 
            this.LbTong.AutoSize = true;
            this.LbTong.Location = new System.Drawing.Point(539, 252);
            this.LbTong.Name = "LbTong";
            this.LbTong.Size = new System.Drawing.Size(35, 13);
            this.LbTong.TabIndex = 1;
            this.LbTong.Text = "Tổng:";
            // 
            // TxtTong
            // 
            this.TxtTong.Location = new System.Drawing.Point(580, 249);
            this.TxtTong.Name = "TxtTong";
            this.TxtTong.ReadOnly = true;
            this.TxtTong.Size = new System.Drawing.Size(100, 20);
            this.TxtTong.TabIndex = 2;
            // 
            // BtnNhap
            // 
            this.BtnNhap.Enabled = false;
            this.BtnNhap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnNhap.Location = new System.Drawing.Point(594, 275);
            this.BtnNhap.Name = "BtnNhap";
            this.BtnNhap.Size = new System.Drawing.Size(86, 33);
            this.BtnNhap.TabIndex = 3;
            this.BtnNhap.Text = "Xác Nhận";
            this.BtnNhap.UseVisualStyleBackColor = true;
            this.BtnNhap.Click += new System.EventHandler(this.BtnNhap_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbMathang);
            this.panel2.Controls.Add(this.BtnChon);
            this.panel2.Controls.Add(this.TxtSoluong);
            this.panel2.Controls.Add(this.TxtDongiaNhap);
            this.panel2.Controls.Add(this.LbSoLuong);
            this.panel2.Controls.Add(this.LbDongiaNhap);
            this.panel2.Controls.Add(this.LbMatHang);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 243);
            this.panel2.TabIndex = 4;
            // 
            // cbMathang
            // 
            this.cbMathang.FormattingEnabled = true;
            this.cbMathang.Items.AddRange(new object[] {
            "1. Pepsi",
            "2. Coca",
            "3. Moutain Dew",
            "4. Sting <Đỏ>",
            "5. Sting <Vàng>",
            "6. Thuốc Lá Thăng Long",
            "7. Thuốc Lá 555 ",
            "8. Bánh mỳ trứng"});
            this.cbMathang.Location = new System.Drawing.Point(112, 49);
            this.cbMathang.Name = "cbMathang";
            this.cbMathang.Size = new System.Drawing.Size(151, 21);
            this.cbMathang.TabIndex = 7;
            this.cbMathang.SelectedIndexChanged += new System.EventHandler(this.cbMathang_SelectedIndexChanged);
            // 
            // BtnChon
            // 
            this.BtnChon.Enabled = false;
            this.BtnChon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnChon.Location = new System.Drawing.Point(167, 176);
            this.BtnChon.Name = "BtnChon";
            this.BtnChon.Size = new System.Drawing.Size(75, 23);
            this.BtnChon.TabIndex = 6;
            this.BtnChon.Text = "Nhập";
            this.BtnChon.UseVisualStyleBackColor = true;
            this.BtnChon.Click += new System.EventHandler(this.BtnChon_Click);
            // 
            // TxtSoluong
            // 
            this.TxtSoluong.Location = new System.Drawing.Point(115, 138);
            this.TxtSoluong.Name = "TxtSoluong";
            this.TxtSoluong.Size = new System.Drawing.Size(53, 20);
            this.TxtSoluong.TabIndex = 5;
            this.TxtSoluong.TextChanged += new System.EventHandler(this.TxtSoluong_TextChanged);
            // 
            // TxtDongiaNhap
            // 
            this.TxtDongiaNhap.Location = new System.Drawing.Point(115, 92);
            this.TxtDongiaNhap.Name = "TxtDongiaNhap";
            this.TxtDongiaNhap.ReadOnly = true;
            this.TxtDongiaNhap.Size = new System.Drawing.Size(71, 20);
            this.TxtDongiaNhap.TabIndex = 4;
            // 
            // LbSoLuong
            // 
            this.LbSoLuong.AutoSize = true;
            this.LbSoLuong.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbSoLuong.Location = new System.Drawing.Point(10, 141);
            this.LbSoLuong.Name = "LbSoLuong";
            this.LbSoLuong.Size = new System.Drawing.Size(71, 16);
            this.LbSoLuong.TabIndex = 2;
            this.LbSoLuong.Text = "Số lượng:";
            // 
            // LbDongiaNhap
            // 
            this.LbDongiaNhap.AutoSize = true;
            this.LbDongiaNhap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbDongiaNhap.Location = new System.Drawing.Point(10, 96);
            this.LbDongiaNhap.Name = "LbDongiaNhap";
            this.LbDongiaNhap.Size = new System.Drawing.Size(98, 16);
            this.LbDongiaNhap.TabIndex = 1;
            this.LbDongiaNhap.Text = "Đơn giá nhập:";
            // 
            // LbMatHang
            // 
            this.LbMatHang.AutoSize = true;
            this.LbMatHang.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbMatHang.Location = new System.Drawing.Point(10, 50);
            this.LbMatHang.Name = "LbMatHang";
            this.LbMatHang.Size = new System.Drawing.Size(71, 16);
            this.LbMatHang.TabIndex = 0;
            this.LbMatHang.Text = "Mặt hàng:";
            // 
            // BtnClear
            // 
            this.BtnClear.Enabled = false;
            this.BtnClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnClear.Location = new System.Drawing.Point(488, 275);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(86, 32);
            this.BtnClear.TabIndex = 5;
            this.BtnClear.Text = "Xóa";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // frmNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 310);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnNhap);
            this.Controls.Add(this.TxtTong);
            this.Controls.Add(this.LbTong);
            this.Controls.Add(this.panel1);
            this.Name = "frmNhapKho";
            this.Text = "Nhập kho";
            this.Load += new System.EventHandler(this.frmNhapKho_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhap1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewNhap1;
        private System.Windows.Forms.Label LbTong;
        private System.Windows.Forms.TextBox TxtTong;
        private System.Windows.Forms.Button BtnNhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox cbMathang;
        private System.Windows.Forms.Button BtnChon;
        private System.Windows.Forms.TextBox TxtSoluong;
        private System.Windows.Forms.TextBox TxtDongiaNhap;
        private System.Windows.Forms.Label LbSoLuong;
        private System.Windows.Forms.Label LbDongiaNhap;
        private System.Windows.Forms.Label LbMatHang;
        private System.Windows.Forms.Button BtnClear;
    }
}