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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
       
        private void rdCheese_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D:/CNTT/LapTrinhGiaoDien/Week3/E03/E03/Pictures/cheese.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            lbRecipe.Items.Add("Cheese Pizza");
            lbIngredients.Items.Add("Eggs");
        }

        private void rdVeg_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D:/CNTT/LapTrinhGiaoDien/Week3/E03/E03/Pictures/veg_crunchy.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            lbRecipe.Items.Add("Veg Crunchy Pizza");
            lbIngredients.Items.Add("Eggs");
        }

        private void rdChinese_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D:/CNTT/LapTrinhGiaoDien/Week3/E03/E03/Pictures/chinese.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            lbRecipe.Items.Add("Chinese Pizza");
            lbIngredients.Items.Add("Eggs");
        }

        private void rdItalian_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D:/CNTT/LapTrinhGiaoDien/Week3/E03/E03/Pictures/italian_pizza.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            lbRecipe.Items.Add("Italian Pizza");
            lbIngredients.Items.Add("Eggs");
        }

        private void rdVegetable_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D:/CNTT/LapTrinhGiaoDien/Week3/E03/E03/Pictures/vegetable.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            lbRecipe.Items.Add("Vegetable Pizza");
            lbIngredients.Items.Add("Eggs");
        }
    }
}
