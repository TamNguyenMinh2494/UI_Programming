using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VipCoopMart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class KhachHang
        {
            public string msKH { set; get; }
            public string tenKH { set; get; }
            public DateTime Ngaysinh { set; get; }
            public string Diachi { set; get; }
            public string NgheNghiep { set; get; }

            public override string ToString()
            {
                return "Mã số: " + msKH + "\n"
                    + "Họ tên: " + tenKH + "\n"
                    + "Ngày: " + Ngaysinh.ToShortDateString() + "\n"
                    + "Địa chỉ: " + Diachi + "\n"
                    + "Nghề: " + NgheNghiep + "\n";
            }
        }
        
        
        public List<KhachHang> khachHang = new List<KhachHang>();
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you want to close?", "Warnings",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                this.Close();
            else return;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            txtKhachHang.Focus();
            btnDangKy.Enabled = false;
            btnNhapMoi.Enabled = false;
            btnTongKet.Enabled = false;
            dmNgheNghiep.SelectedItem = dmNgheNghiep.Items[0];
            timer1.Tick += timer1_Tick;
            timer1.Enabled = true;
            timer1.Start();


        }

        public int i = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Location = new Point(label1.Location.X + i, label1.Location.Y);
            if (label1.Location.X > this.Width)
            {
                label1.Location = new Point(-label1.Width,label1.Location.Y);
            }
        }
        public bool checkInput()
        {
            if (txtKhachHang.Text == "")
            {
               return false;
            }
            if(txtHoTen.Text == "")
            {
                return false;
            }
            if (txtDiaChi.Text == "")
            {
                return false;
            }
            return true;
        }

       
        private void btnDangKy_Click(object sender, EventArgs e)
        {
         
            if (true)
            {
                KhachHang kh = new KhachHang() {
                    msKH = txtKhachHang.Text,
                    tenKH = txtHoTen.Text,
                    Ngaysinh = new DateTime((int)nudNam.Value, (int)nudThang.Value, (int)nudNgay.Value),
                    Diachi = txtDiaChi.Text,
                    NgheNghiep = dmNgheNghiep.SelectedItem.ToString()
                };
                khachHang.Add(kh);
                if((MessageBox.Show("Hello\n" + kh, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)) == DialogResult.OK)
                {
                    btnNhapMoi.Enabled = true;
                    btnTongKet.Enabled = true;
                    btnDangKy.Enabled = false;
                }
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (checkInput())
            {
                btnDangKy.Enabled = true;
            }
        }

        private void txtKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (checkInput())
            {
                btnDangKy.Enabled = true;
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            if (checkInput())
            {
                btnDangKy.Enabled = true;
            }
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtKhachHang.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            btnNhapMoi.Enabled = false;
            btnTongKet.Enabled = false;
        }

        private void btnTongKet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tổng khách hàng: "+khachHang.Count().ToString());
        }
    }
}
