using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public int firstnum, secondnum, score, timeleft;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft--;
                Timerlabel6.Text = timeleft.ToString();
            }
            if (timeleft == 0)
            {

                timer1.Stop();
                Donebutton1.Enabled = false;
                Startbutton2.Enabled = true;
                Timerlabel6.Text = "";
                AnswertextBox1.Text = "TIME OUT";

                score = score - 1;
                ActiveScorelabel2.Text = score.ToString();
            }


        }



        private void Startbutton2_Click(object sender, EventArgs e)
        {
            timeleft = 60;

            timer1.Start();



            Random rand = new Random();
            firstnum = rand.Next(10);
            secondnum = rand.Next(10);
            FirstNumlabel3.Text = firstnum.ToString();

            SecondNumlabel5.Text = secondnum.ToString();


            Donebutton1.Enabled = true;
            Startbutton2.Enabled = false;



        }

        private void Donebutton1_Click(object sender, EventArgs e)
        {

            Donebutton1.Enabled = false;
            Startbutton2.Enabled = true;
            timer1.Stop();

            //Checking if the number is correct

            int total = firstnum * secondnum;
            if (AnswertextBox1.Text == total.ToString())
            {
                AnswertextBox1.Text = "";
                AnswertextBox1.Text = "Right Answer";

                score = score + 1;
                ActiveScorelabel2.Text = score.ToString();
            }
            else
            {
                AnswertextBox1.Text = "";
                AnswertextBox1.Text = "Wrong Answer";

                score = score - 1;
                ActiveScorelabel2.Text = score.ToString();


            }
        }

    }
    }