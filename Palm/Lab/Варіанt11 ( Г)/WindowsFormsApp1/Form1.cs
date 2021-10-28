using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
//11.Г) намалювати барабан з паличками.

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Blue, 10);
            SolidBrush sld = new SolidBrush(Color.Blue);


            graph.FillRectangle(Brushes.Purple, 160, 215, 200, 100);
            graph.FillEllipse(Brushes.Violet, 160, 195, 200, 40);
            graph.FillEllipse(Brushes.Purple, 160, 290, 200, 40);

            Point p0 = new Point(250, 200);
            Point p1 = new Point(120, 160);
            Point p2 = new Point(280, 200);
            Point p3 = new Point(410, 160);




            graph.DrawLine(pen, p0, p1);
            graph.DrawLine(pen, p2, p3);


            pictureBox1.Image = bmp;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

