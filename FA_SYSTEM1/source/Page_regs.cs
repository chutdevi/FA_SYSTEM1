using Newtonsoft.Json.Linq;
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
    public partial class Page_regs : Form
    {
        private int stsCk = 0;
        private Page_numb nmPin;
        private string imgCk;
        private string pinU;
        public Page_regs()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

                Pen pen = new Pen(Color.Red, 12);
               //  Console.WriteLine(e.ClipRectangle.Left + " " + e.ClipRectangle.Top + " " + e.ClipRectangle.Width + " " + e.ClipRectangle.Height);
                e.Graphics.DrawRectangle(pen, 0, 0, 776, 213);
                base.OnPaint(e);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            if (textBox5.Text.ToString().Length > 4)
            {
                label8.Visible   = true;
                textBox5.Visible = false;
                Application.DoEvents();
                JArray cuser = Api.api_getJArray("http://192.168.161.102/api_system/Api_emptransfer/user_ck?user=" + textBox5.Text);
                if (cuser.Count > 0)
                {
                    label7.ForeColor = Color.Blue;
                    label7.Text = "พบ รหัสพนักงานนี้ในระบบ";
                    stsCk = 1;

                    textBox5.Enabled = false;
                    pictureBox1.Image = Api.DownloadImage("http://192.168.161.102/api_system/img_mem/" + textBox5.Text + ".jpg");
                    if(Api.img_err == 1)
                    {
                        try
                        {
                           imgCk =  Api.api_getJObject("http://192.168.161.102/api_system/Api_emptransfer/img_mem?img=" + textBox5.Text)["img"].ToString();

                            if (imgCk.Equals("1"))
                            {
                                pictureBox1.Image = Api.DownloadImage("http://192.168.161.102/api_system/img_mem/" + textBox5.Text + ".jpg");
                            }
                        }
                        catch(Exception em)
                        {
                           Console.WriteLine(Api.api_getJObject("http://192.168.161.102/api_system/Api_emptransfer/img_mem?img=" + textBox5.Text)); 
                        }

                    }
                    //string imgPath = pictureBox1.ImageLocation.ToString() ;
                    //string nameImage = imgPath.Substring(imgPath.LastIndexOf('\\') + 1);

                    Console.WriteLine(Api.img_err);

                    textBox1.Text = cuser[0]["USER_CD"].ToString();
                    textBox2.Text = cuser[0]["USER_TNAME"].ToString();
                    label8.Visible = false;
                    textBox5.Visible = true;
                    SendKeys.Send("{tab}");
                    //Console.WriteLine(button1.Focused);
                }
                else
                {
                    stsCk = 0;
                    label7.ForeColor = Color.Red;
                    label7.Text = "ไม่พบ รหัสพนักงานนี้ในระบบ";
                    label8.Visible = false;
                    textBox5.Visible = true;
                }
            }

        }

        private void Page_regs_Load(object sender, EventArgs e)
        {
            textBox5.Focus();
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (stsCk == 1 || stsCk == 3)
            {
                
                nmPin = new Page_numb(textBox3);
                nmPin.ShowDialog();
            }
        }
        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (stsCk == 2)
            {
                stsCk = 1;
                nmPin = new Page_numb(textBox4);
                nmPin.ShowDialog();
            }

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.ToString().Length == 4)
            {
                
                MessageBox.Show("ใส่ pin เสร็จเรียนร้อยแล้ว", "Pin userd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                stsCk = 2;
                nmPin.Close();
                textBox3.Select(textBox3.Text.Length, 1);              

            }else if(textBox3.Text.ToString().Length > 4)
            {
                MessageBox.Show("pin ต้องไม่เกิน 4 ตัว", "String Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBox3.Text = "";
            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.ToString().Length == textBox4.Text.ToString().Length)
            {
                if( textBox3.Text.ToString() == textBox4.Text.ToString() )
                {
                    stsCk = 3;

                    MessageBox.Show("ใส่ pin เสร็จเรียนร้อยแล้ว", "Pin userd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pinU = textBox4.Text.ToString();
                    nmPin.Close();               
                    textBox4.SelectionLength = 0;

                   //textBox4.Text = "0";
                }
                else
                {
                    stsCk = 2;
                    MessageBox.Show("pin ไม่ตรงกัน", "String Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    //nmPin.Close();
                }

            }
            else if ( textBox4.Text.ToString().Length > textBox3.Text.ToString().Length )
            {
                MessageBox.Show("pin ต้องไม่เกิน 4 ตัว", "String Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBox4.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str_ins = "";
            if  (stsCk == 3)
            {
                Console.WriteLine(  );

                if( Api.api_request("http://192.168.161.102/api_system/Api_emptransfer/user_pin?user=" + textBox5.Text + "&upin=" + pinU + "&id=1").Equals("0") )
                {
                    MessageBox.Show("กำหนด pin เสร็จเรียนร้อยแล้ว", "Pin userd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("รหัสนี้ มีการกำหนด pin แล้ว", "Pin Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                
            }
            else
            {
                if( MessageBox.Show("คุณไม่มีการ กำหนด Pin คุณต้องการที่จะทำต่อหรือไม่", "String Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    this.Close();
                }
            }






            
        }

        private void Page_regs_KeyDown(object sender, KeyEventArgs e)
        {
            Evk.KeyDown_even(e.KeyCode);

            //Console.WriteLine( (int)( e.KeyData ) );
        }
        private void Page_regs_KeyUp(object sender, KeyEventArgs e)
        {
            //Evk.Keyup_even(this);
            switch (Evk.key_num)
            {
                case (int)(Keys.F1) + (int)(Keys.O):
                    
                    Console.WriteLine(Evk.key_num);
                    linkLabel1.Visible = true;
                    if(textBox5.Focused)
                    {
                        textBox5.Text = "";
                    }
                    Evk.key_num = 0;
                    break;
                default:
                   // Console.WriteLine("Default case");
                    break;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label3.Text = "New PIN";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
