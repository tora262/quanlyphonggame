using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMIN_Control
{
    public partial class frmNapTien : Form
    {
        TaiKhoan tk = new TaiKhoan();
        HoaDon hd = new HoaDon();
        public frmNapTien()
        {
            InitializeComponent();
        }

        private void frmNapTien_Load(object sender, EventArgs e)
        {
            TxtTenTK.Text = this.Text;
        }

        private void BtnNapTien_Click(object sender, EventArgs e)
        {
            // Update số tiền mới của Tài Khoản vào  DATABASE
            using (QuanLyPhongGameEntities1 db = new QuanLyPhongGameEntities1())
            {
                for (int i = 0; i < db.TaiKhoans.Count(); i ++)
                {
                    tk = db.TaiKhoans.ToArray<TaiKhoan>()[i];
                    if (tk.TenTk == this.Text) break;
                }
                tk.SoDuTaiKhoan += Convert.ToInt32(TxtSoLuong.Text);
                db.Entry(tk).State = EntityState.Modified;
                // Tạo Hóa Đơn và Nhập và DataBase
                hd.MaHD = Convert.ToString(db.HoaDons.Count() + 1);
                hd.TenTK = "ADMIN";
                hd.Loai = true;
                hd.GiaTri = Convert.ToInt32(TxtSoLuong.Text);
                hd.ChiTiet = "Nạp tiền vào TK :" + this.Text;
                DateTimePicker dtp = new DateTimePicker();
                hd.Ngaygio = dtp.Value;
                db.Entry(hd).State = EntityState.Added;
                db.SaveChanges(); 
            }
            
            TxtSoLuong.Text = "";

            // Tạo MessageBox thông báo xác nhận nạp thành công
            MessageBox.Show("Nạp tiền thành công !");

            

        }

        private void TxtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (TxtSoLuong.Text != "") BtnNapTien.Enabled = true;
            else BtnNapTien.Enabled = false;
        }
    }
}
