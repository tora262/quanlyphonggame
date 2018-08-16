namespace ADMIN_Control
{
    partial class frmNapTien
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
            this.TxtTenTK = new System.Windows.Forms.TextBox();
            this.LbTenTK = new System.Windows.Forms.Label();
            this.TxtSoLuong = new System.Windows.Forms.TextBox();
            this.LbSluong = new System.Windows.Forms.Label();
            this.BtnNapTien = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtTenTK);
            this.panel1.Controls.Add(this.LbTenTK);
            this.panel1.Controls.Add(this.TxtSoLuong);
            this.panel1.Controls.Add(this.LbSluong);
            this.panel1.Controls.Add(this.BtnNapTien);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 110);
            this.panel1.TabIndex = 0;
            // 
            // TxtTenTK
            // 
            this.TxtTenTK.Location = new System.Drawing.Point(80, 12);
            this.TxtTenTK.Name = "TxtTenTK";
            this.TxtTenTK.ReadOnly = true;
            this.TxtTenTK.Size = new System.Drawing.Size(182, 20);
            this.TxtTenTK.TabIndex = 4;
            // 
            // LbTenTK
            // 
            this.LbTenTK.AutoSize = true;
            this.LbTenTK.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbTenTK.Location = new System.Drawing.Point(11, 14);
            this.LbTenTK.Name = "LbTenTK";
            this.LbTenTK.Size = new System.Drawing.Size(31, 15);
            this.LbTenTK.TabIndex = 3;
            this.LbTenTK.Text = "Tên:";
            // 
            // TxtSoLuong
            // 
            this.TxtSoLuong.Location = new System.Drawing.Point(80, 66);
            this.TxtSoLuong.Name = "TxtSoLuong";
            this.TxtSoLuong.Size = new System.Drawing.Size(92, 20);
            this.TxtSoLuong.TabIndex = 2;
            this.TxtSoLuong.TextChanged += new System.EventHandler(this.TxtSoLuong_TextChanged);
            // 
            // LbSluong
            // 
            this.LbSluong.AutoSize = true;
            this.LbSluong.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbSluong.Location = new System.Drawing.Point(11, 68);
            this.LbSluong.Name = "LbSluong";
            this.LbSluong.Size = new System.Drawing.Size(63, 15);
            this.LbSluong.TabIndex = 1;
            this.LbSluong.Text = "Số lương:";
            // 
            // BtnNapTien
            // 
            this.BtnNapTien.Enabled = false;
            this.BtnNapTien.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnNapTien.Location = new System.Drawing.Point(187, 60);
            this.BtnNapTien.Name = "BtnNapTien";
            this.BtnNapTien.Size = new System.Drawing.Size(75, 30);
            this.BtnNapTien.TabIndex = 0;
            this.BtnNapTien.Text = "Nạp";
            this.BtnNapTien.UseVisualStyleBackColor = true;
            this.BtnNapTien.Click += new System.EventHandler(this.BtnNapTien_Click);
            // 
            // frmNapTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 134);
            this.Controls.Add(this.panel1);
            this.Name = "frmNapTien";
            this.Text = "Nạp tiền";
            this.Load += new System.EventHandler(this.frmNapTien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtSoLuong;
        private System.Windows.Forms.Label LbSluong;
        private System.Windows.Forms.Button BtnNapTien;
        private System.Windows.Forms.TextBox TxtTenTK;
        private System.Windows.Forms.Label LbTenTK;
    }
}