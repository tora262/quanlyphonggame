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
    public partial class frmNhapKho : Form
    {
        KhoHang kh = new KhoHang();
        HoaDon hd = new HoaDon();
        public frmNhapKho()
        {
            InitializeComponent();
        }
        int tong = 0;

        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewNhap1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                                  
        }

        private void dataGridViewNhap1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (e.ColumnIndex == 3)
            {
                
                tong = tong + Convert.ToInt32(dataGridViewNhap1.Rows[e.RowIndex].Cells[3].Value.ToString()) * Convert.ToInt32(dataGridViewNhap1.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
            
        }
        int checkdGvNhap1Status = 0;
        private void BtnChon_Click(object sender, EventArgs e)
        {
            dataGridViewNhap1.AllowUserToAddRows = false;
            string name = cbMathang.Text;
            string number = TxtSoluong.Text;
            string cost = TxtDongiaNhap.Text;
            string sum = Convert.ToString(Convert.ToInt32(TxtDongiaNhap.Text) * Convert.ToInt32(TxtSoluong.Text));
            dataGridViewNhap1.Rows.Add(name, number, cost, sum);
            int tong = 0;
            for (int i = 0; i <= dataGridViewNhap1.Rows.Count - 1; i++)
                tong = tong + Convert.ToInt32(dataGridViewNhap1.Rows[i].Cells[3].Value.ToString());
            
            TxtTong.Text = tong.ToString();
            checkdGvNhap1Status++;
            if(checkdGvNhap1Status > 0)
            {
                BtnClear.Enabled = true;
                BtnNhap.Enabled = true;
            }
            else
            {
                BtnClear.Enabled = false;
                BtnNhap.Enabled = false;
            }
        }

        private void BtnNhap_Click(object sender, EventArgs e)
        {
            // Nhập đơn hàng vào kho
            using (QuanLyPhongGameEntities1 db = new QuanLyPhongGameEntities1())
            {
                for (int i = 0; i < dataGridViewNhap1.Rows.Count; i++)
                {
                    for (int j = 0; j < db.TaiKhoans.Count(); j++)
                    {
                        kh = db.KhoHangs.ToArray<KhoHang>()[j];
                        if (kh.MaHang == Convert.ToString(dataGridViewNhap1.Rows[i].Cells[0].Value.ToString()[0]))
                        {
                            kh.SoLuong += Convert.ToInt32(dataGridViewNhap1.Rows[i].Cells[1].Value.ToString());
                            db.Entry(kh).State = EntityState.Modified;
                            db.SaveChanges();                        
                            
                        }

                    }
                    // Tạo hóa đơn và đưa và Database
                                       
                    hd.MaHD =  Convert.ToString(db.HoaDons.Count() + 1);
                    hd.TenTK = this.Text;
                    hd.Loai = false;
                    hd.GiaTri = Convert.ToInt32(TxtTong.Text);
                    DateTimePicker dtp = new DateTimePicker();
                    hd.Ngaygio = dtp.Value;

                    string tmp = "";
                    for (int k = dataGridViewNhap1.Rows.Count - 1; k >= 0; k--)
                    {
                        tmp = tmp.Insert(0, "\r\n");
                        tmp = tmp.Insert(0, dataGridViewNhap1.Rows[k].Cells[3].Value.ToString());
                        tmp = tmp.Insert(0, "- Thành Tiền:");
                        tmp = tmp.Insert(0, dataGridViewNhap1.Rows[k].Cells[2].Value.ToString());
                        tmp = tmp.Insert(0, "- Đơn giá:");
                        tmp = tmp.Insert(0, dataGridViewNhap1.Rows[k].Cells[1].Value.ToString());
                        tmp = tmp.Insert(0, "- Số lượng:");
                        tmp = tmp.Insert(0, Convert.ToString(dataGridViewNhap1.Rows[k].Cells[0].Value.ToString()));
                    }
                    hd.ChiTiet = tmp; 
                }
                db.Entry(hd).State = EntityState.Added;
                db.SaveChanges();
                MessageBox.Show("Nhập vào kho hàng thành công");
            }

            // Clear 
            dataGridViewNhap1.Rows.Clear();
            BtnNhap.Enabled = false;
            BtnClear.Enabled = false;  
        }

        private void cbMathang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbMathang.Text != "") && (TxtDongiaNhap.Text != "") && (TxtSoluong.Text != "")) BtnChon.Enabled = true;
            else BtnChon.Enabled = false;
            using (QuanLyPhongGameEntities1 db = new QuanLyPhongGameEntities1())
            {
                // Tim theo ten dich vu trong DataBase
                for (int i = 0; i < db.TaiKhoans.Count(); i++)
                {
                    kh = db.KhoHangs.ToArray<KhoHang>()[i];
                    if (kh.MaHang == Convert.ToString(cbMathang.Text[0])) break;
                }
                // Update Đơn giá nhập từ DataBase vao TxtDongiaNhap.Text
                TxtDongiaNhap.Text = kh.GiaNhap.ToString();
            }
        }

       

        private void TxtSoluong_TextChanged(object sender, EventArgs e)
        {
            if ((cbMathang.Text != "") && (TxtDongiaNhap.Text != "") && (TxtSoluong.Text != "")) BtnChon.Enabled = true;
            else BtnChon.Enabled = false;
        }

        private void dataGridViewNhap1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            dataGridViewNhap1.Rows.RemoveAt(dataGridViewNhap1.SelectedCells[0].RowIndex);
            int tong = 0;
            for (int i = 0; i <= dataGridViewNhap1.Rows.Count - 1; i++)
                tong = tong + Convert.ToInt32(dataGridViewNhap1.Rows[i].Cells[3].Value.ToString());

            TxtTong.Text = tong.ToString();

            checkdGvNhap1Status--;
            if (checkdGvNhap1Status > 0)
            {
                BtnClear.Enabled = true;
                BtnNhap.Enabled = true;
            }
            else
            {
                BtnClear.Enabled = false;
                BtnNhap.Enabled = false;
            }
        }
    }
}
