using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoPicView
{
    public partial class Form2 : Form
    {
       
        public Form2(String image)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(image);
            Text = image.Substring(image.LastIndexOf('\\') + 1);
        }
        public Form2()
        {
            InitializeComponent();
        }
    }
}
