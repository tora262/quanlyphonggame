namespace ADMIN_Control
{
    partial class frmCTHD
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
            this.dGVCTHD = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCloseCTHD = new System.Windows.Forms.Button();
            this.TxtTongCTHD = new System.Windows.Forms.TextBox();
            this.LbTongCTHD = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dGVCTHD);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 186);
            this.panel1.TabIndex = 0;
            // 
            // dGVCTHD
            // 
            this.dGVCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dGVCTHD.Location = new System.Drawing.Point(3, 3);
            this.dGVCTHD.Name = "dGVCTHD";
            this.dGVCTHD.Size = new System.Drawing.Size(428, 180);
            this.dGVCTHD.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
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
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 83;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Thành Tiền";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // BtnCloseCTHD
            // 
            this.BtnCloseCTHD.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnCloseCTHD.Location = new System.Drawing.Point(184, 231);
            this.BtnCloseCTHD.Name = "BtnCloseCTHD";
            this.BtnCloseCTHD.Size = new System.Drawing.Size(83, 33);
            this.BtnCloseCTHD.TabIndex = 1;
            this.BtnCloseCTHD.Text = "Đóng";
            this.BtnCloseCTHD.UseVisualStyleBackColor = true;
            this.BtnCloseCTHD.Click += new System.EventHandler(this.BtnCloseCTHD_Click);
            // 
            // TxtTongCTHD
            // 
            this.TxtTongCTHD.Location = new System.Drawing.Point(346, 204);
            this.TxtTongCTHD.Name = "TxtTongCTHD";
            this.TxtTongCTHD.ReadOnly = true;
            this.TxtTongCTHD.Size = new System.Drawing.Size(100, 20);
            this.TxtTongCTHD.TabIndex = 2;
            // 
            // LbTongCTHD
            // 
            this.LbTongCTHD.AutoSize = true;
            this.LbTongCTHD.Location = new System.Drawing.Point(295, 207);
            this.LbTongCTHD.Name = "LbTongCTHD";
            this.LbTongCTHD.Size = new System.Drawing.Size(35, 13);
            this.LbTongCTHD.TabIndex = 3;
            this.LbTongCTHD.Text = "Tổng:";
            // 
            // frmCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 276);
            this.Controls.Add(this.LbTongCTHD);
            this.Controls.Add(this.TxtTongCTHD);
            this.Controls.Add(this.BtnCloseCTHD);
            this.Controls.Add(this.panel1);
            this.Name = "frmCTHD";
            this.Text = "Chi tiết hóa đơn";
            this.Load += new System.EventHandler(this.frmCTHD_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVCTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGVCTHD;
        private System.Windows.Forms.Button BtnCloseCTHD;
        private System.Windows.Forms.TextBox TxtTongCTHD;
        private System.Windows.Forms.Label LbTongCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}