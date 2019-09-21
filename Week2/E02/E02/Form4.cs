using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E02
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        static String type;
        static float price;
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (true)
            {
                String show = txtInput.Text.ToString();
                MessageBox.Show("" + show,"Your Information", MessageBoxButtons.OK);
            }
        }

        private void rdbCafeDen_CheckedChanged(object sender, EventArgs e)
        {
            type = "cafeden";
            price = 20000;
            if (rdbCafeDen.Checked && cbSV.Checked)
            {
                price = price * 80 / 100;
                txtTongTien.Text = price.ToString();
            }
            else
            {
                txtTongTien.Text = price.ToString();
            }
        }

        private void rdbCafeSua_CheckedChanged(object sender, EventArgs e)
        {
            type = "cafesua";
            price = 25000;
            if (rdbCafeDen.Checked && cbSV.Checked)
            {
                price = price * 80 / 100;
                txtTongTien.Text = price.ToString();
            }
            else
            {
                txtTongTien.Text = price.ToString();
            }
        }

        private void rdbCafeDa_CheckedChanged(object sender, EventArgs e)
        {
            type = "cafeda";
            price = 25000;
            if (rdbCafeDen.Checked && cbSV.Checked)
            {
                price = price * 80 / 100;
                txtTongTien.Text = price.ToString();
            }
            else
            {
                txtTongTien.Text = price.ToString();
            }
        }

        private void rdbCafeSuaDa_CheckedChanged(object sender, EventArgs e)
        {
            type = "cafesuada";
            price = 30000;
            if (rdbCafeDen.Checked && cbSV.Checked)
            {
                price = price * 80 / 100;
                txtTongTien.Text = price.ToString();
            }
            else
            {
                txtTongTien.Text = price.ToString();
            }
        }

        private void rdbCafeKem_CheckedChanged(object sender, EventArgs e)
        {
            type = "cafekem";
            price = 35000;
            if (rdbCafeDen.Checked && cbSV.Checked)
            {
                price = price * 80 / 100;
                txtTongTien.Text = price.ToString();
            }
            else
            {
                txtTongTien.Text = price.ToString();
            }
        }

        private void txtTongKhach_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (txtInput.Text.ToString() != "")
            {
                
            }
            else
            {
                //btnNhapLai.Enabled = false;
                //btnThanhToan.Enabled = false;
                //btnTinhTien.Enabled = false;
            }              

            
        }
    }
}
