using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FA_SYSTEM1.source
{

    public partial class Page_numb : Form
    {

        public TextBox texpin;
        private int flgpin = 0;
        private int flgdot = 0;

        public Page_numb()
        {
            InitializeComponent();
        }
        public Page_numb( TextBox tx )
        {
            InitializeComponent();

            texpin = tx;
        }
        public void set_formatpass(Boolean flg = true)
        {
            textBox1.UseSystemPasswordChar = flg;
        }



        public void set_flgoin(int pin = 0)
        {
            flgpin = pin;
            if ( flgpin == 1 ) button13.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + "1";
            texpin.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
            texpin.Text = textBox1.Text;
  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
            texpin.Text = textBox1.Text;

        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
            texpin.Text = textBox1.Text;

        }


        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
            texpin.Text = textBox1.Text;

        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
            texpin.Text = textBox1.Text;

        }


        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
            texpin.Text = textBox1.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
            texpin.Text = textBox1.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
            texpin.Text = textBox1.Text;

        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
            texpin.Text = textBox1.Text;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if( flgpin == 0)
            {
                texpin.Text = "";
                textBox1.Text = "";
            }
            else
            {
                texpin.Text = "0.00";
                textBox1.Text = "";
                flgdot = 0;
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if( flgpin == 0)
                if(texpin.Text.ToString().Length < 4)
                {
                    MessageBox.Show("pin ต้องมี 4 ตัว", "String Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    texpin.Text = "";
                    textBox1.Text = "";
                }
                else
                {
                    texpin.Select(texpin.Text.Length, 0 );
                    texpin.Select(textBox1.Text.Length, 0);
                }
            else
                {
                if (textBox1.Text != "") texpin.Text = float.Parse(texpin.Text).ToString("#,#0.00");
                else texpin.Text = "0.00";
                }


            this.Close();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if(flgdot == 0)
            {
            textBox1.Text = textBox1.Text + ".";
            texpin.Text = textBox1.Text;
            //flgdot = 0;


            }

        }

        private void Page_numb_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (flgpin == 1)
            {
                int index2 = textBox1.Text.IndexOf('.');
                if (textBox1.Text == ".")
                {
                    textBox1.Text = "";
                }
                if (index2 > -1 && flgdot == 0)
                {
                    flgdot = 1;
                    //if(flgdot > 1) textBox1.Text = textBox1.Text.Substring(0, (textBox1.Text.ToString().Length - 1));

                    //flgdot++;
                }
                //if(textBox1.Text != "") textBox1.Text = float.Parse(textBox1.Text).ToString("#,#0");
            }
            //Console.WriteLine(textBox1.Text);
        }
    }
}
