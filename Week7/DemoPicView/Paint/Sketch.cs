using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public delegate void OnChangePosition(Point position);
    public partial class Sketch : Panel
    {
        public Sketch()
        {
            InitializeComponent();
            paper = new Bitmap(Width, Height);
            DoubleBuffered = true;
        }
        PointF previousPoint;
        bool hasPrevious = false;
        Bitmap paper;
        public Color color;
        public event OnChangePosition OnChangePosition;
       

        public void DrawLine(Color color)
        {
            this.color = color;
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if(hasPrevious == false)
            {
                previousPoint = PointToClient(Cursor.Position);
                hasPrevious = true;
            }
            else
            {
                using(Graphics g = Graphics.FromImage(paper))
                {
                    g.DrawLine(new Pen(color), previousPoint, PointToClient(Cursor.Position));
                    hasPrevious = false;
                }
            }
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            paper = new Bitmap(Width, Height);
        }

        
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            Invalidate();
            OnChangePosition?.Invoke(PointToClient(Cursor.Position));
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (paper != null)
            {
                e.Graphics.DrawImage(paper, new PointF(0, 0));
            }
            if(hasPrevious != false)
            {
                e.Graphics.DrawLine(new Pen(Color.Black,1), previousPoint, PointToClient(Cursor.Position));

            }
        }
       
    }
}
