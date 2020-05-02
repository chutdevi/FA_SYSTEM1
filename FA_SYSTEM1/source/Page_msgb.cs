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
    public partial class Page_msgb : Form
    {
        private string str_msg = "";
        public Page_msgb()
        {
            InitializeComponent();
        }

        public Page_msgb(string mgs)
        {
            InitializeComponent();
            this.richTextBox1.Text = mgs;
            str_msg = mgs;

            this.ShowDialog();
            
        }

        private void Page_msgb_Load(object sender, EventArgs e)
        {
            //richTextBox1.Enabled = false;
            //if(str_msg != "")
            //{
            //    this.richTextBox1.Text = str_msg;
            //}
            //this.ShowDialog();
        }


        public void setButton(int flg = 0)
        {
            switch(flg)
            {
                case 1: 
                    break;
                case 2:
                    break;
                case 3:
                    break;
              default:
                    break;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //printPreviewDialog1.Document = 
            //printPreviewDialog1.Document = new System.Drawing.Printing.PrintDocument();
            //printPreviewDialog1.Document.Print();
            //printPreviewDialog1.print;

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
