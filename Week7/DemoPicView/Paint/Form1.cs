using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sketch1.OnChangePosition += Sketch1_OnChangePosition;
        }

    
        private void Sketch1_OnChangePosition(Point position)
        {
            label1.Text = "X: " + position.X + " Y: " + position.Y;
        }

        private Point pA;
        Graphics g;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            pA = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                g = this.CreateGraphics();
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Pen pen = new Pen(Color.Red, 2f);
                g.DrawLine(pen, pA, e.Location);
                pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            }
        }

        
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            string s;
            s = "X: " + e.X.ToString() + " Y: " + e.Y.ToString();
            label1.Text = s;
            //if (moving && x != -1 && y != -1)
            //{
            //    g.DrawLine(pen, new Point(x, y), e.Location);
            //    x = e.X;
            //    y = e.Y;
            //}
        }

        //private void Form1_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if (moving)
        //    {
        //        int diffx = e.X - x;
        //        int diffy = e.Y - y;
        //        switch (shape)
        //        {
        //            case 2:
        //                g.DrawRectangle(pen, x, y, diffx, diffy);
        //                break;
        //            case 3:
        //                g.DrawEllipse(pen, x, y, diffx, diffy);
        //                break;
        //        }
        //    }
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    shape = 2;
        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
               
                sketch1.DrawLine(colorDialog.Color);
            }
        }
    }
}
