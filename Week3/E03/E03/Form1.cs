using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nUDFont_ValueChanged(object sender, EventArgs e)
        {
            tbHeader.Font = new Font ("Times New Roman",int.Parse(nUDFont.Value.ToString()));
        }

        private void cbRegular_CheckedChanged(object sender, EventArgs e)
        {
            tbHeader.Font = new Font(tbHeader.Font, FontStyle.Regular);
        }

        private void cbBold_CheckedChanged(object sender, EventArgs e)
        {
            tbHeader.Font = new Font(tbHeader.Font, FontStyle.Bold);
        }

        private void cbItalic_CheckedChanged(object sender, EventArgs e)
        {
            tbHeader.Font = new Font(tbHeader.Font, FontStyle.Italic);
        }

        private void cbBoldItalic_CheckedChanged(object sender, EventArgs e)
        {
            tbHeader.Font = new Font(tbHeader.Font, FontStyle.Bold|FontStyle.Italic);
        }

        private void rdAutoColor_CheckedChanged(object sender, EventArgs e)
        {
            ColorDialog colorAuto = new ColorDialog();
            colorAuto.ShowDialog();
            tbHeader.ForeColor = colorAuto.Color;
        }

        private void rdRed_CheckedChanged(object sender, EventArgs e)
        {
            tbHeader.ForeColor = Color.Red;
        }

        private void rdGreen_CheckedChanged(object sender, EventArgs e)
        {
            tbHeader.ForeColor = Color.Green;
        }

        private void rdBlue_CheckedChanged(object sender, EventArgs e)
        {
            tbHeader.ForeColor = Color.Blue;
        }

        private void rdLeft_CheckedChanged(object sender, EventArgs e)
        {
            tbHeader.TextAlign = HorizontalAlignment.Left;
        }

        private void rdRight_CheckedChanged(object sender, EventArgs e)
        {
            tbHeader.TextAlign = HorizontalAlignment.Right;
        }

        private void rdCenter_CheckedChanged(object sender, EventArgs e)
        {
            tbHeader.TextAlign = HorizontalAlignment.Center;
        }
    }
}
