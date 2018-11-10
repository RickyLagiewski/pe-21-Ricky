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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public string lowEnd = "";
        public string highEnd = "";
        public int lowNumber;
        public int highNumber;
        TextBox txtrun = new TextBox();

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            lowEnd = textBox1.Text;
            lowNumber = int.Parse(lowEnd);
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            highEnd = textBox2.Text;
            highNumber = int.Parse(highEnd);
        }

        public void button1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                GameForm game = new GameForm();
                this.Hide();
                game.ShowDialog();
                this.Close();
                /*
                if (lowEnd != null && highEnd != null)
                {
                    if (lowNumber < highNumber)
                    {
                        
                    }

                }*/
            }
            catch(Exception ex)
            {
                txtrun.Text = (ex.Message);
            }
        }
    }
}
