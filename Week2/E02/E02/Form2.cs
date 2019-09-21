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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void rdbRegular_CheckedChanged(object sender, EventArgs e)
        {
            lbHead.Font = new Font(lbHead.Font,FontStyle.Regular);
        }

        private void rdbBold_CheckedChanged(object sender, EventArgs e)
        {
            lbHead.Font = new Font(lbHead.Font, FontStyle.Bold);
        }

        private void rdbItalic_CheckedChanged(object sender, EventArgs e)
        {
            lbHead.Font = new Font(lbHead.Font, FontStyle.Italic);
        }

        private void rdbBoldItalic_CheckedChanged(object sender, EventArgs e)
        {
            lbHead.Font = new Font(lbHead.Font, FontStyle.Bold|FontStyle.Italic);
        }

        private void rdbAuto_CheckedChanged(object sender, EventArgs e)
        {
            ColorDialog colorAuto = new ColorDialog();
            colorAuto.ShowDialog();
            lbHead.ForeColor = colorAuto.Color;
        }

        private void rdbRed_CheckedChanged(object sender, EventArgs e)
        {
            lbHead.ForeColor = Color.Red;
        }

        private void rdbGreen_CheckedChanged(object sender, EventArgs e)
        {
            lbHead.ForeColor = Color.Green;
        }

        private void rdbBlue_CheckedChanged(object sender, EventArgs e)
        {
            lbHead.ForeColor = Color.Blue;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
