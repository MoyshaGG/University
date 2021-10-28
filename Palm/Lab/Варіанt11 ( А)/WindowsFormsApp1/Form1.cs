using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//11.а)Намалювати в різних місцях екрана сектор кола, куб, зафарбований еліпс і зафарбований
//семикутник.
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
            Pen pen = new Pen(Color.Blue);
            SolidBrush sld = new SolidBrush(Color.Blue);



            Point s1 = new Point(584, 20);

            Point s2 = new Point(626,41);

            Point s3 = new Point(639, 90);

            Point s4 = new Point(608, 127);

            Point s5 = new Point(559, 127);

            Point s6 = new Point(528, 88);

            Point s7 = new Point(537, 42);
                                                          //КУБ
            graph.DrawLine(pen, s1, s2);
            graph.DrawLine(pen, s2, s3);
            graph.DrawLine(pen, s3, s4);
            graph.DrawLine(pen, s4, s5);
            graph.DrawLine(pen, s5, s6);
            graph.DrawLine(pen, s6, s7);
            graph.DrawLine(pen, s7, s1);

            graph.DrawArc(pen, 300, 100, 90, 120, 60, 60); //  ЕЛІПСА
            graph.DrawLine(pen, 317,207, 343, 150);
            graph.DrawLine(pen, 343, 150, 372, 207);

            graph.FillEllipse(Brushes.Blue, 400, 100, 100, 200);



            Point p0 = new Point(20, 90);
            Point p1 = new Point(100, 10);
            Point p2 = new Point(305, 10);
            Point p3 = new Point(240, 90);

            Point p4 = new Point(20, 300);
            Point p5 = new Point(240, 300);
            Point p6 = new Point(305, 220);
            Point p7 = new Point(100, 220);

            graph.DrawLine(pen, p7, p4);
            graph.DrawLine(pen, p7, p6);                            // СЕМИКУТНИК
            graph.DrawLine(pen, p7, p1);

            graph.DrawLine(pen, p0, p1);
            graph.DrawLine(pen, p1, p2);
            graph.DrawLine(pen, p2, p3);
            graph.DrawLine(pen, p0, p3);

            graph.DrawLine(pen, p0, p4);
            graph.DrawLine(pen, p3, p5);
            graph.DrawLine(pen, p2, p6);
            graph.DrawLine(pen, p4, p5);
            graph.DrawLine(pen, p5, p6);


            pictureBox1.Image = bmp;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
