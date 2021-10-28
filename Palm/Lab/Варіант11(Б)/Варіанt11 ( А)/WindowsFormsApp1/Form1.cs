using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
//11.Б)За допомогою графічних примітивів намалювати комп&#39;ютер, за яким ви зараз працюєте.

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


            graph.FillRectangle(Brushes.Black, 150, 12, 186, 83);
            graph.FillRectangle(Brushes.Gray, 160, 20, 170, 65);
            graph.FillRectangle(Brushes.Black , 172, 95, 20, 20);
            graph.FillRectangle(Brushes.Black, 291, 95, 20, 20);
            graph.FillRectangle(Brushes.Black, 160, 128, 170, 45);
            graph.FillRectangle(Brushes.Gray, 168, 136, 152, 30);
            graph.FillRectangle(Brushes.Gray, 60, 33, 50, 110);
            graph.FillRectangle(Brushes.Red, 80, 116, 15, 15);

            pictureBox1.Image = bmp;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
