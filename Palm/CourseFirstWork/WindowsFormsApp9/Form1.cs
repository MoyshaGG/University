using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        int box1 = 0;     
        public Form1()
        {                              
            InitializeComponent();                 
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            box1 = Convert.ToInt32(textBox1.Text);
            if (box1 > 0 && box1 < 6)
            {
                Form5 frm3 = new Form5(box1);
                frm3.Show();
                this.Hide();
                
            }
            else
            {
                warn.Visible = true;
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
