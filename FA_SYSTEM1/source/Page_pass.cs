using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace FA_SYSTEM1.source
{
    public partial class Page_pass : Form
    {
        private Control_page data_con;
        private Worker data_wrk;
        private Page_numb nmPin;
        //private Page_pass pageGobal;
        public Page_pass()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //if (ino == 0)
            //{
            Pen pen = new Pen(Color.Red, 5);
            //  Console.WriteLine(e.ClipRectangle.Left + " " + e.ClipRectangle.Top + " " + e.ClipRectangle.Width + " " + (++ino));
            e.Graphics.DrawRectangle(pen,
            e.ClipRectangle.Left,
            e.ClipRectangle.Top,
            e.ClipRectangle.Width - 1,
            e.ClipRectangle.Height - 1);
            base.OnPaint(e);
            //}
        }

        public void tread_task(Control_page ty, Worker wk)
        {
            data_con = ty;
            data_wrk = wk;
            //Console.WriteLine(data_wrk._system_user);
        }

        private void Page_pass_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = data_wrk.img_user;
            textBox1.Text = data_wrk._uid_user + " : " + data_wrk._name_user;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Focus();
        }
        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            nmPin = new Page_numb(textBox2);
            nmPin.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ///Application.DoEvents();
            ///
            //int h = 0;
            if (textBox2.Text.ToString().Length == 4)
            {
                //pageGobal = this;
                Thread thd1 = new Thread(delegate (object obj)
                {
                    var propertyInfos = obj.GetType().GetProperty("fm");
                    var propertyContn = obj.GetType().GetProperty("oor");
                //Console.WriteLine(propertyInfos.GetValue(obj, null));
                //Console.WriteLine( obj.GetType().GetProperty("fm").GetValue(obj, null).GetType());
                    Page_pass fl = (Page_pass)propertyInfos.GetValue(obj, null);
                    Control_page bg = (Control_page)propertyContn.GetValue(obj,null);
                    if (Api.api_request("http://192.168.161.102/api_system/Api_emptransfer/user_pinlogin?user=" + data_wrk._uid_user + "&upin=" + textBox2.Text.ToString()).Equals("1"))
                    {


                        Invoke((MethodInvoker)delegate
                        {
                           // Application.DoEvents();
                           // this.Hide();

                            //MessageBox.Show("กำหนด pin เสร็จเรียนร้อยแล้ว", "Pin userd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                           
                            data_con.reci_page.Show();
                            //data_con.reci_page.list_set(); 
                           


                            data_con.home_page.Hide();
                            //Page_msgb ms = new Page_msgb("เข้าสู่ระบบ สำเร็จ");
                            //ms.Dispose();
                            this.Close();
                            //thd1.Abort();
                        });
                            //data_con.reci_page.Invoke(new Action(Show));
                            //data_con.home_page.Invoke(new Action(Hide));
                            //if (data_con.)  data_con.home_page.Invoke(new Action(Hide));
                            //data_con.reci_page.Show();
                            //data_con.reci_page.list_set();
                            //Application.DoEvents();
                            //data_con.reci_page.list_set();

                    }
                    else
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            this.Show();
                        });
                    }

                });

                thd1.Start( new { fm = this, oor = data_con } );

                //this.Hide();
                nmPin.Close();

                //if (h == 1) thd1.Abort();
                ///{
                ///    data_con.reci_page.Show();
                ///    data_con.reci_page.list_set();
                ///    data_con.home_page.Hide();
                ///}

                //Application.DoEvents();

            }
            //thd1.Abort();
        }
    }
}