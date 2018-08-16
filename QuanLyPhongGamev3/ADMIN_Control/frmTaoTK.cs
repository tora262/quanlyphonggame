using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ADMIN_Control
{
    public partial class frmTaoTK : Form
    {
        TaiKhoan tk = new TaiKhoan();
        public static string connectionString = @"Data Source=SINGSING\SQLEXPRESS;Initial Catalog=QuanLyPhongGame;Integrated Security=True";
        public frmTaoTK()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            TxtChuThich.Clear();
            TxtChuThich.Text = "Yêu cầu chữ IN HOA từ 6-18 ký tự";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            TxtChuThich.Clear();
            TxtChuThich.Text = "Yêu cầu 1-50 ký tự";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            TxtChuThich.Clear();
            TxtChuThich.Text = "Sử dụng khi xảy ra tranh chấp tài khoản";
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            TxtChuThich.Clear();
            TxtChuThich.Text = "Số tiền nạp đầu tiên";
        }

        private void TxtMK2_Click(object sender, EventArgs e)
        {
            TxtChuThich.Clear();
            TxtChuThich.Text = "Mật khẩu cần được nhập lại để đảm bảo sự chắc chắn";
        }

        void Clear()
        {
            TxtTenTK.Text = "";
            TxtMK.Text = "";
            TxtMK2.Text = "";
            TxtTenKH.Text = "";
            cbGioiTinh.Text = "";
            dTPNgaySinh.Text = "";
            TxtSoDT.Text = "";
            TxtNap.Text = "";
            BtnTaoTK.Enabled = false;
        }

        private void BtnTaoTK_Click(object sender, EventArgs e)
        {                      
            if (TxtMK.Text == TxtMK2.Text)
            {
                tk.TenTk = TxtTenTK.Text;
                tk.MatKhau = TxtMK.Text;
                tk.ChuTK = TxtTenKH.Text;
                tk.GioiTinh = cbGioiTinh.Text;
                tk.NgaySinh = dTPNgaySinh.Value;
                tk.SoDienThoai = TxtSoDT.Text;
                tk.SoDuTaiKhoan = Convert.ToInt32(TxtNap.Text);
                using (QuanLyPhongGameEntities1 db = new QuanLyPhongGameEntities1())   
                {
                    db.Entry(tk).State = EntityState.Added;
                    db.SaveChanges();
                }
                Clear();
                MessageBox.Show("Tạo Tài khoản thành công");
            }
            else TxtChuThich.Text = "Xác nhận mật khẩu không đúng!";
         
        }

        private void TxtTenTK_TextChanged(object sender, EventArgs e)
        {
            if ((TxtTenTK.Text != "") && (TxtMK.Text != "") && (TxtMK2.Text != "") && (TxtNap.Text != "")) BtnTaoTK.Enabled = true;
            else BtnTaoTK.Enabled = false;
        }

        private void TxtMK_TextChanged(object sender, EventArgs e)
        {
            if ((TxtTenTK.Text != "") && (TxtMK.Text != "") && (TxtMK2.Text != "") && (TxtNap.Text != "")) BtnTaoTK.Enabled = true;
            else BtnTaoTK.Enabled = false;
        }

        private void TxtMK2_TextChanged(object sender, EventArgs e)
        {
            if ((TxtTenTK.Text != "") && (TxtMK.Text != "") && (TxtMK2.Text != "") && (TxtNap.Text != "")) BtnTaoTK.Enabled = true;
            else BtnTaoTK.Enabled = false;
        }

        private void TxtNap_TextChanged(object sender, EventArgs e)
        {
            if ((TxtTenTK.Text != "") && (TxtMK.Text != "") && (TxtMK2.Text != "") && (TxtNap.Text != "")) BtnTaoTK.Enabled = true;
            else BtnTaoTK.Enabled = false;
        }
    }
}
