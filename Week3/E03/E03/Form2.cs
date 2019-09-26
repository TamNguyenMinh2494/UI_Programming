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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void rdVietNam_CheckedChanged(object sender, EventArgs e)
        {
            pbFlags.Image = Image.FromFile("D:/CNTT/LapTrinhGiaoDien/Week3/E03/E03/Pictures/vn.png");
            pbFlags.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void rdUSA_CheckedChanged(object sender, EventArgs e)
        {
            pbFlags.Image = Image.FromFile("D:/CNTT/LapTrinhGiaoDien/Week3/E03/E03/Pictures/usa.png");
            pbFlags.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void rdItalian_CheckedChanged(object sender, EventArgs e)
        {
            pbFlags.Image = Image.FromFile("D:/CNTT/LapTrinhGiaoDien/Week3/E03/E03/Pictures/italian.jpg");
            pbFlags.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void rdPhiliipine_CheckedChanged(object sender, EventArgs e)
        {
            pbFlags.Image = Image.FromFile("D:/CNTT/LapTrinhGiaoDien/Week3/E03/E03/Pictures/philippine.jpg");
            pbFlags.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
