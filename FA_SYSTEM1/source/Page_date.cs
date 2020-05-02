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
    
    public partial class Page_date : Form
    {
        private TextBox txtput;
        private int txtFlg = 0;
        private LinkLabel link_lb;
        public Page_date()
        {
            InitializeComponent();
            textBox_day.Enter += (s, e) => { textBox_day.Parent.Focus(); };
            textBox_month.Enter += (s, e) => { textBox_month.Parent.Focus(); };
            textBox_year.Enter += (s, e) => { textBox_year.Parent.Focus(); };
        }
        public Page_date(LinkLabel lb)
        {
            InitializeComponent();
            link_lb = lb;
            textBox_day.Enter += (s, e) => { textBox_day.Parent.Focus(); };
            textBox_month.Enter += (s, e) => { textBox_month.Parent.Focus(); };
            textBox_year.Enter += (s, e) => { textBox_year.Parent.Focus(); };
        }
        private void Page_date_Load(object sender, EventArgs e)
        {
            txtput = textBox_day;
            textBox_day.Text = "";
            textBox_month.Text = "";
            textBox_year.Text = "";

        }
        private void Page_date_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Escape:
                    Console.WriteLine(Evk.key_num);
                    this.Close();
                    break;
                default:
                    Console.WriteLine(e.KeyChar);
                    break;


            }
        }

        private void buttonClick(object sender, EventArgs e)
        {

            Button bclick = (Button)sender;
            
            //Console.WriteLine(bclick.Text);
            switch ( bclick.Text )
            {
                //case "1":
                //    txtput.Text = txtput.Text += bclick.Text;
                //    break;
                //case "2":
                //    txtput.Text = txtput.Text += bclick.Text;
                //    break;
                //case "3":
                //    txtput.Text = txtput.Text += bclick.Text;
                //    break;
                //case "4":
                //    txtput.Text = txtput.Text += bclick.Text;
                //    break;
                //case "5":
                //    txtput.Text = txtput.Text += bclick.Text;
                //    break;
                //case "6":
                //    txtput.Text = txtput.Text += bclick.Text;
                //    break;
                //case "7":
                //    txtput.Text = txtput.Text += bclick.Text;
                //    break;
                //    
                //case "8":
                //    txtput.Text = txtput.Text += bclick.Text;
                //    break;
                //case "9":
                //    txtput.Text = txtput.Text += bclick.Text;
                //    break;
                //case "0":
                //   txtput.Text = txtput.Text += bclick.Text;
                //   break;
                case "OK":
                    if (txtFlg == 3)
                    {
                        string du = textBox_year.Text  + textBox_month.Text.PadLeft(2, '0') + textBox_day.Text.PadLeft(2, '0');
                        link_lb.Text =  DateTime.ParseExact(du, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
                    }
                    this.Close();
                    break;
                case "CLEAR":
                    textBox_day.Text = "";
                    textBox_month.Text = "";
                    textBox_year.Text = "";
                    txtput = textBox_day;
                    txtFlg = 0;
                    break;
                case "This day":
                    //Console.WriteLine(DateTime.Now.ToString("dd"));
                    textBox_day.Text = DateTime.Now.ToString("dd");
                    txtFlg = 3;
                    break;
                case "This month":
                    textBox_month.Text = DateTime.Now.ToString("MM");
                    txtFlg = 3;
                    break;
                case "This year":
                    textBox_year.Text = DateTime.Now.ToString("yyyy");
                    txtFlg = 3;
                    break;
                default:
                    txtput.Text += bclick.Text;
                    break;          
            }

            //Console.WriteLine(this.Focus());
            if      ( textBox_day.Text.Length   == 2 && txtFlg == 0)  {   txtput = textBox_month; txtFlg = 1; }
            else if ( textBox_month.Text.Length == 2 && txtFlg == 1)  {   txtput = textBox_year;  txtFlg = 2; }
            else if ( textBox_year.Text.Length  == 4 && txtFlg == 2)  {   txtFlg = 3;   }//MessageBox.Show("End");
            //else 
        }

        private void textbox_Changed(object sender, EventArgs e)
        {
            TextBox tcn = (TextBox)sender;
            //TextBox txtclick = (TextBox)sender;
            //SendKeys.Send("{tab}");
            if( tcn.Text != "")
            {
                switch (tcn.Name)
                {
                    case "textBox_day":
                        if (int.Parse(tcn.Text) > 31)
                        {
                            Page_msgb pm = new Page_msgb("กรุณา ใส่วันที่ให้ถูกต้อง");
                            tcn.Text.DefaultIfEmpty();
                        }
                        break;
                    case "textBox_month":
                        if (int.Parse(tcn.Text) > 12)
                        {
                            Page_msgb pm = new Page_msgb("กรุณา ใส่เดือนให้ถูกต้อง");
                            tcn.Text.DefaultIfEmpty();
                        }
                        break;
                    case "textBox_year":
                        if (int.Parse(tcn.Text) < 2019 && textBox_year.Text.Length == 4)
                        {
                            Page_msgb pm = new Page_msgb("กรุณา ใส่ปีให้มากว่า ค.ศ. 2019 ");
                            tcn.Text.DefaultIfEmpty();
                        }
                        break;
                }
            }
        }

        private void txt_Cdate(TextBox tx, int dc)
        {

        }



        private void textBox_Click(object sender, EventArgs e)
        {
            TextBox txtclick = (TextBox)sender;
            SendKeys.Send("{tab}");
            if (txtclick.Text != "")
            {
                switch (txtclick.Name)
                {
                    case "textBox_day":
                        txtput = textBox_day;
                        txtput.Text = "";
                        //txtFlg = 0;
                        break;
                    case "textBox_month":
                        txtput = textBox_month;
                        txtput.Text = "";
                        //txtFlg = 1;
                        break;
                    case "textBox_year":
                        txtput = textBox_year;
                        txtput.Text = "";
                        //txtFlg = 2;
                        break;
                }
            }
        }
    }
}
