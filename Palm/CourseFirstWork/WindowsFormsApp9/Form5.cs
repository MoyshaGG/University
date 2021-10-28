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
    public partial class Form5 : Form
    {
        int box = 0;
        
        public Form5(int value)
        {
            box = value;
            

            InitializeComponent();
        }


        int sumred = 0;
        int sumblue = 0;

        private void Button1_Click(object sender, EventArgs e)
        {
            int scorered = 0;
            int scoreblue = 0;

            Random rnd = new Random();
            int blueC1 = rnd.Next(1, 7); 
            int blueC2 = rnd.Next(1, 7);
            int blueC3 = rnd.Next(1, 7);
            int blueC4 = rnd.Next(1, 7);
            int blueC5 = rnd.Next(1, 7);

            int redC1 = rnd.Next(1, 7);
            int redC2 = rnd.Next(1, 7);
            int redC3 = rnd.Next(1, 7);
            int redC4 = rnd.Next(1, 7);
            int redC5 = rnd.Next(1, 7);

            blue1.Text = Convert.ToString(blueC1);
            blue2.Text = Convert.ToString(blueC2);
            blue3.Text = Convert.ToString(blueC3);
            blue4.Text = Convert.ToString(blueC4);
            blue5.Text = Convert.ToString(blueC5);

            red1.Text = Convert.ToString(redC1);
            red2.Text = Convert.ToString(redC2);
            red3.Text = Convert.ToString(redC3);
            red4.Text = Convert.ToString(redC4);
            red5.Text = Convert.ToString(redC5);


            switch(box)
            {
                case 1:
                    scorered += redC1;
                    scoreblue += blueC1;
                    break;
                case 2:
                    scorered += redC1 + redC2;
                    scoreblue += blueC1 + blueC2;
                    break;
                case 3:
                    scorered += redC1 + redC2 + redC3;
                    scoreblue += blueC1 + blueC2 + blueC3;
                    break;
                case 4:
                    scorered += redC1 + redC2 + redC3 + redC4;
                    scoreblue += blueC1 + blueC2 + blueC3 + blueC4;
                    break;
                case 5:
                    scorered += redC1 + redC2 + redC3 + redC4 + redC5;
                    scoreblue += blueC1 + blueC2 + blueC3 + blueC4 + blueC5;
                    break;
            }

          
          
          
           

            
            if (scorered > scoreblue)
            {
                WinRed.Visible = true;
                WinBlue.Visible = false;
                Draw.Visible = false;
            }
            else if (scorered < scoreblue)
            {
                WinBlue.Visible = true;
                WinRed.Visible = false;
                Draw.Visible = false;
            }
            else
            {
                WinRed.Visible = false;
                WinBlue.Visible = false;
                Draw.Visible = true;
            }


            sumred += scorered;
            sumblue += scoreblue;
 
            BlueAll.Text = Convert.ToString(sumblue);
            RedAll.Text = Convert.ToString(sumred);
        }
        private void Button2_Click(object sender, EventArgs e)
        {
          
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();   
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            switch (box)
            {
                case 1:

                    blue2.Visible = false;
                    blue3.Visible = false;
                    blue4.Visible = false;
                    blue5.Visible = false;
                    red2.Visible = false;
                    red3.Visible = false;
                    red4.Visible = false;
                    red5.Visible = false;
                    break;
 
                case 2:

                    blue3.Visible = false;
                    blue4.Visible = false;
                    blue5.Visible = false;
                    red3.Visible = false;
                    red4.Visible = false;
                    red5.Visible = false;
                    break;

                case 3:

                    blue4.Visible = false;
                    blue5.Visible = false;
                    red4.Visible = false;
                    red5.Visible = false;
                    break;

                case 4:

                    blue5.Visible = false;
                    red5.Visible = false;
                    break;
            }
        }
    }
}
