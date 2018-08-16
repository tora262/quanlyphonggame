using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ADMIN_Control
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        TaiKhoan tk = new TaiKhoan();
        HoaDon hd = new HoaDon();
        SimpleTcpServer server;
        private void Admin_Load(object sender, EventArgs e)
        {

            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            System.Net.IPAddress ip = System.Net.IPAddress.Parse("127.0.0.1");
            server.Start(ip, 8088);
            server.DataReceived += server_DataReceived;
        }

        private void server_DataReceived(object sender, SimpleTCP.Message e)
        {
            TxtReceived.Invoke((MethodInvoker)delegate ()
            {
                TxtReceived.Text += e.MessageString;
            });
            //DateTime dt = new DateTime();
            //dt = GetLifetimeService;
            string Time = Convert.ToString(GetLifetimeService()) ;
            string Name = "";
            for (int i = 0; e.MessageString[i] != '-'; i++)
                Name = Name.Insert(Name.Length, Convert.ToString(e.MessageString[i]));
            string giatri  = "";
            for (int j = e.MessageString.IndexOf('-') + 1; e.MessageString[j] != '\r'; j++)
                giatri = giatri.Insert(giatri.Length, Convert.ToString(e.MessageString[j]));
            dataGridViewAd2.Invoke((MethodInvoker)delegate ()
            {
                dataGridViewAd2.AllowUserToAddRows = false;
                dataGridViewAd2.Rows.Add(Time, Name, giatri, "Chi tiết", "Xác nhận", "Hủy");
            });
            MessageBox.Show("Có yêu cầu mới");          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTaoTK Tao_TK = new frmTaoTK();
            Tao_TK.Show();
        }       

        private void button2_Click(object sender, EventArgs e)
        {
            frmNhapKho frm_NhapKho = new frmNhapKho();
            frm_NhapKho.Text = "ADMIN";
            frm_NhapKho.Show();
        }

        private void dataGridViewAd3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewAd2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                frmCTHD frm_CTHD = new frmCTHD();
                frm_CTHD.Show(); 

            }
            if (e.ColumnIndex == 4)
            {
                Console.WriteLine("Xac Nhan Dich Vu + Tao hoa don trong DATABASE");
                // Actions with DataBase
            } 
            if (e.ColumnIndex == 5)
            {
                if (e.RowIndex >= 0) dataGridViewAd2.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dataGridViewAd1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          if(e.ColumnIndex == 7)
            {
                frmNapTien frm_NapTien = new frmNapTien();
                frm_NapTien.Text = dataGridViewAd1.Rows[e.RowIndex].Cells[0].Value.ToString();
                //frm_NapTien.Text = dataGridViewAd1;
                frm_NapTien.Show();
            }
            
            if (e.ColumnIndex == 8)
            {
                using (QuanLyPhongGameEntities1 db = new QuanLyPhongGameEntities1())
                {
                   
                    // Tạo messagebox xác nhận chắc chắn việc xóa
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa tài khoản này ?","Xóa Tài Khoản",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                            for (int i = 0; i < db.TaiKhoans.Count(); i++)
                            {
                                tk = db.TaiKhoans.ToArray<TaiKhoan>()[i];
                                if (tk.TenTk == dataGridViewAd1.SelectedCells[0].ToString()) break;
                            }
                            // Xóa Tài khoản đang được chọn trong DATABASE
                            var entry = db.Entry(tk);
                            if (entry.State == EntityState.Detached)
                                db.TaiKhoans.Attach(tk);
                            db.TaiKhoans.Remove(tk);
                            db.SaveChanges();                 
                        
                        // Tạo messagebox thông báo việc xóa thành công
                        MessageBox.Show("Đã Xóa Tài Khoản Được Chọn ");
                        // Xóa tài khoản được chọn trong datagridvView
                        if (e.RowIndex >= 0) dataGridViewAd1.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            GetTaiKhoan();         
        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            GetKhoHang();
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            GetHoaDon();
        }

        private void TxtMaHD_TextChanged(object sender, EventArgs e)
        {
            GetHoaDon();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            GetTaiKhoan();
        }
        
        private void GetHoaDon()
        {
            dataGridViewAd3.Rows.Clear();
            using (QuanLyPhongGameEntities1 db = new QuanLyPhongGameEntities1())
            {
                for (int i = 0; i < db.HoaDons.Count(); i++)
                {
                    int check = 0;
                    hd = db.HoaDons.ToArray<HoaDon>()[i];
                    for (int j = 0; j < TxtMaHD.Text.Length; j++)
                    {
                        if (hd.MaHD[j] == TxtMaHD.Text[j]) check++;
                        else break;
                    }
                    if (check == TxtMaHD.Text.Length)
                    {
                        dataGridViewAd3.Rows.Add(hd.MaHD, hd.TenTK, hd.Loai, hd.GiaTri, hd.Ngaygio, hd.ChiTiet);
                        
                    }
                        
                }

            }
        }

        private void GetKhoHang()
        {
            dataGridViewAd4.AutoGenerateColumns = false;
            using (QuanLyPhongGameEntities1 db = new QuanLyPhongGameEntities1())
            {
                dataGridViewAd4.DataSource = db.KhoHangs.ToList<KhoHang>();
            }
        }

        private void GetTaiKhoan()
        {

            dataGridViewAd1.Rows.Clear();
            using (QuanLyPhongGameEntities1 db = new QuanLyPhongGameEntities1())
            {
                for (int i = 0; i < db.TaiKhoans.Count(); i++)
                {
                    int check = 0;
                    tk = db.TaiKhoans.ToArray<TaiKhoan>()[i];
                    for (int j = 0; j < txtName.Text.Length; j++)
                    {
                        if (tk.TenTk[j] == txtName.Text[j]) check++;
                        else break;
                    }
                    if (check == txtName.Text.Length)
                    {
                        dataGridViewAd1.Rows.Add(tk.TenTk, tk.MatKhau, tk.ChuTK, tk.GioiTinh, tk.NgaySinh, tk.SoDienThoai, tk.SoDuTaiKhoan, "Nạp", "Xóa");
                    }
                }

            }
        }

        private void dataGridViewAd3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {        
            MessageBox.Show(dataGridViewAd3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(),"Chi tiết");
        }
    }
}
