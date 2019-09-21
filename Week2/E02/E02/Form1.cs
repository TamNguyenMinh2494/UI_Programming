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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float soThu1, soThu2, kq;
        private void Form1_Load(object sender, EventArgs e)
        {
            rdbAdd.CheckedChanged += SelectedAdd;
            rdbSub.CheckedChanged += SelectedSub;
            rdbMul.CheckedChanged += SelectedMul;
            rdbDiv.CheckedChanged += SelectedDiv;
        }

        private void SelectedAdd(object sender, EventArgs e)
        {
            soThu1 = float.Parse(txtNum1.Text);
            soThu2 = float.Parse(txtNum2.Text);
            if (txtNum1.Text == "")
            {
                MessageBox.Show("Please input number 1", "Warnings",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Warning);
            }
            else if (txtNum2.Text == "")
            {
                MessageBox.Show("Please input number 2", "Warnings",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning);
            }
            else
            {
                kq = soThu1 + soThu2;
                lbKq.Text = kq.ToString();
            }
          
        }

        private void SelectedSub(object sender, EventArgs e)
        {
            soThu1 = float.Parse(txtNum1.Text);
            soThu2 = float.Parse(txtNum2.Text);
            if (txtNum1.Text == "")
            {
                MessageBox.Show("Please input number 1", "Warnings",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Warning);
            }
            else if (txtNum2.Text == "")
            {
                MessageBox.Show("Please input number 2", "Warnings",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning);
            }
            else
            {
                kq = soThu1 - soThu2;
                lbKq.Text = kq.ToString();
            }
        }

        private void SelectedMul(object sender, EventArgs e)
        {
            soThu1 = float.Parse(txtNum1.Text);
            soThu2 = float.Parse(txtNum2.Text);
            if (txtNum1.Text == "")
            {
                MessageBox.Show("Please input number 1", "Warnings",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Warning);
            }
            else if (txtNum2.Text == "")
            {
                MessageBox.Show("Please input number 2", "Warnings",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning);
            }
            else
            {
                kq = soThu1 * soThu2;
                lbKq.Text = kq.ToString();
            }

        }

        private void SelectedDiv(object sender, EventArgs e)
        {
            soThu1 = float.Parse(txtNum1.Text);
            soThu2 = float.Parse(txtNum2.Text);
            if (txtNum1.Text == "")
            {
                MessageBox.Show("Please input number 1", "Warnings",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Warning);
            }
            else if (txtNum2.Text == "")
            {
                MessageBox.Show("Please input number 2", "Warnings",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning);
            }
            else
            {
                kq = soThu1 / soThu2;
                lbKq.Text = kq.ToString();
            }

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (!String.IsNullOrEmpty(txtNum1.Text.ToString())) //not throw error when null
                if (!Char.IsDigit(control.Text[control.Text.Length - 1])) //warning if string exist
                    txtNum1.BackColor = Color.Red;
                else
                    txtNum1.BackColor = Color.Green;
            else
                txtNum1.BackColor = Color.White;
        }

        

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (!String.IsNullOrEmpty(txtNum2.Text.ToString())) //not throw error when null
                if (!Char.IsDigit(control.Text[control.Text.Length - 1])) //warning if string exist
                    txtNum2.BackColor = Color.Red;
                else
                    txtNum2.BackColor = Color.Green;
            else
                txtNum2.BackColor = Color.White;
        }
    }
}
