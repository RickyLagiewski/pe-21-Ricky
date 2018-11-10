using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GameForm : Form
    {
        
        public GameForm()
        {
            InitializeComponent();
        }

        Form1 frm1 = new Form1();
        int guess;
        int publicRandomNumber;
        TextBox txtrun = new TextBox();

        public void GameForm_Load(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = true;
                timer1.Start();
                timer1.Interval = 1000;
                progressBar1.Maximum = 20;
                timer1.Tick += new EventHandler(timer1_Tick);
                play(frm1.highNumber, frm1.lowNumber, guess);
            }
            catch(Exception ex)
            {
                txtrun.Text = (ex.Message);
            }
        }

        public void play(int p_lownumber, int p_highnumber, int p_guess)
        {
            try
            {


                guess = p_guess;
                int lowernumber = p_lownumber;
                int highernumber = p_highnumber;
                Random rng = new Random();
                int randomNumber = rng.Next(lowernumber, highernumber);
                publicRandomNumber = randomNumber;
            }
            catch(Exception ex)
            {
                txtrun.Text = (ex.Message);
            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int guess;
                string guessString;
                guessString = textBox1.Text;
                guess = int.Parse(guessString);
            }
            catch(Exception ex)
            {
                txtrun.Text = (ex.Message);
            }
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (progressBar1.Value != 20)
                {
                    progressBar1.Value++;
                }
                else
                {
                    timer1.Stop();
                }
                if (progressBar1.Value == 20)
                {
                    timer1.Stop();
                    Console.WriteLine("Times up you lost");
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                txtrun.Text = (ex.Message);
            }
        }

        public void button1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {

                if (guess > publicRandomNumber)
                {
                    label1.Text = ("Your guess of " + guess + " is high");
                }
                if (guess < publicRandomNumber)
                {
                    label1.Text = ("Your guess of" + guess + " is low");
                }
                if (guess == publicRandomNumber)
                {
                    Console.WriteLine("Your guess of " + guess + " was right!");
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                txtrun.Text = (ex.Message);
            }
        }
    }
}
