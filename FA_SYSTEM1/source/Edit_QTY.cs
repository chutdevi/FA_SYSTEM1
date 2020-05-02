using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FA_SYSTEM1
{

    public partial class Edit_QTY : Form
    {
        public string str_set;
   

        // string str1_set;
        public Edit_QTY(string odr ,string text)
        {
            InitializeComponent();
            this.str_set = odr;
            Partno.Text = odr;        
            this.str_set = text;
            Rec_qty.Text = String.Format("{0:F2}", text);
          
        }

        public Edit_QTY()
        {

        }

        private void Edit_QTY_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            timer1.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {            
        }

        private void Partno_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {          
        }

        private void Partno_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Dat.Text = DateTime.Now.ToString("yyyy / MM / dd     hh : mm : ss");
        }

        private void Rec_qty_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You want to Confirmed", "QC", MessageBoxButtons.OK,
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        public void set_UserID1(string Id)
        {
            //label2.Text = Id;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Control_rec recForm = new Control_rec();
            recForm.Show();
            Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt16(Rec_qty.Text);
            int num2 = Convert.ToInt16(NGPa.Text);

            int sum = 0;
            sum = num1 - num2;

            MessageBox.Show("OK PART = "+sum.ToString());
            Control_rec rec = new Control_rec();
            rec.Show();
            Hide();
        }
    }
}
