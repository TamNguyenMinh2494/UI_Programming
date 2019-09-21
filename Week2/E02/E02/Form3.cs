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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        
        private void rdbTime_CheckedChanged(object sender, EventArgs e)
        {
            txtShow.Font = new Font("Times New Roman",18);
        }

        private void rdbComic_CheckedChanged(object sender, EventArgs e)
        {
            txtShow.Font = new Font("Comic Sans MS", 18);
        }

        private void rdbUVN_CheckedChanged(object sender, EventArgs e)
        {
            txtShow.Font = new Font("UVN Lac Long Quan", 18);
        }

        private void rdbThao_CheckedChanged(object sender, EventArgs e)
        {
            txtShow.Font = new Font("PhuongThao 1.1", 18);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
