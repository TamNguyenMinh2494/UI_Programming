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
    public partial class Form4 : Form
    {
        public Form4()
        {
           
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("D:/CNTT/LapTrinhGiaoDien/Week3/E03/E03/Pictures/hinh4.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Location = new Point(this.Size.Width / 100 * e.NewValue, pictureBox1.Location.Y);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, this.Size.Height / 100 * e.NewValue);

        }
    }
}
