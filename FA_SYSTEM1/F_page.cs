  using FA_SYSTEM1.source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//using FA_SYSTEM1.controller;
namespace FA_SYSTEM1
{


    public partial class F_page : Form
    {
        //private Thread thread1; 
        //private Thread thread2;
        // private Thread thread3;
        //private SerialPort port = new SerialPort("COM3",  9600, Parity.None, 8, StopBits.One);
        public F_page()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
               
         //this.WindowState = FormWindowState.Maximized;
            textBox1.Focus();
            Application.EnableVisualStyles();
            //  thread1 = new Thread(tread_task);
            //  thread1.Start();
            timer1.Start();
            serialPort1.Open();
            Console.WriteLine( SerialPort.GetPortNames()[0] );
           // MessageBox.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //textBox1.Focus();
           Dat.Text = DateTime.Now.ToString("yyyy / MM / dd     hh : mm : ss");
            //if ( !textBox1.Focused  )
            //{
                //Console.WriteLine(Focused);&& ( Form.ActiveForm == null || Form.ActiveForm.Text == "F_page" )
                //Console.WriteLine(this.Focused);
            //    textBox1.Focus();
            //}
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.SelectionStart = textBox1.Text.Length;
            if (textBox1.Text.Length > 5)
            {
                MessageBox.Show("รหัสพนักงานต้องไม่เกิน 5 ตัวอักษร");
                textBox1.Focus();
                textBox1.Text = "";
            }
            else if (textBox1.Text.Length > 4)
            {
                checking_user();
            }
               

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            //mssql.main();
            if (textBox1.Text.Length > 4)
            {
                
                Button1.Visible = false;
                label2.Visible  = true;

                label2.Location = new Point(301, 337);
                Application.DoEvents();
                Worker wk = new Worker(textBox1.Text);


                if( wk.user_in() > 0)
                {
                   // timer1.Stop();
                  Control_page op = new Control_page(this);
                  wk.worker_set(wk._system_user);
                  op.Control_set(op, wk);
                  op.Control_login();
                  Button1.Visible = true;
                  label2.Visible = false;
                }
                else
                {
                    MessageBox.Show("Error");
                    textBox1.Focus();
                    textBox1.Text = "";
                    Button1.Visible = true;
                    label2.Visible = false;
                }



            }
            else { MessageBox.Show("รหัสต้องมากกว่า 4 ตัว");  }

        }
        private void checking_user()
        {

                        Button1.Visible = false;
                        label2.Visible = true;

                        label2.Location = new Point(301, 337);
                        //Application.DoEvents();
                        Worker wk = new Worker(textBox1.Text);


                        if (wk.user_in() > 0)
                        {
                // timer1.Stop();
                            if (serialPort1.IsOpen)

                            {
                                Thread CloseDown = new Thread(new ThreadStart(CloseSerialOnExit)); //close port in new thread to avoid hang

                                CloseDown.Start();
                            }
                            Control_page op = new Control_page(this);
                            wk.worker_set(wk._system_user);
                            op.Control_set(op, wk);
                            op.Control_login();
                            Button1.Visible = true;
                            label2.Visible = false;

                        }
                        else
                        {
                            MessageBox.Show("Error");
                            textBox1.Focus();
                            textBox1.Text = "";
                            Button1.Visible = true;
                            label2.Visible = false;
                        }
        }

        public void tread_task(Control_page ty)
        {
            //throw new NotImplementedException();
            //throw new NotImplementedException();
            //fom = new F_page();
            //this.textBox1.Focus();
            Dat.Invoke( new Action(() => Dat.Text = DateTime.Now.ToString("yyyy / MM / dd     hh : mm : ss") ));

            //this.Dat.Text = DateTime.Now.ToString("yyyy / MM / dd     hh : mm : ss");
        }
        private void CloseSerialOnExit()
        {
            try

            {
                serialPort1.Close(); //close the serial port
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message); //catch any serial port closing error messages
            }
            //this.Invoke(new EventHandler(NowClose)); //now close back in the main thread
        }
        private void NowClose(object sender, EventArgs e)

        {

            this.Close(); //now close the form

        }
        private void F_page_Activated(object sender, EventArgs e)
        {

            
            textBox1.Focus();
            Console.Write(textBox1.Focused);
            //port.Open();
            button4.Visible = false;
            SendKeys.Send("{tab}");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Page_regs regs = new Page_regs();
           // timer1.Stop();
            regs.ShowDialog();
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
                case (int)(Keys.D1) + (int)(Keys.D7):
                    Console.WriteLine(Evk.key_num);
                    button4.Visible = true;
                    textBox1.Text = "";
                    Evk.key_num = 0;
                    break;
                default:
                    //Console.WriteLine("Default case");
                    break;

                
            }
            Evk.key_num = 0;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data_sc = serialPort1.ReadExisting();
            //Console.WriteLine( data_sc.Length );
            //MessageBox.Show(data_sc);
            textBox1.Invoke( new Action(() => textBox1.Text = data_sc.ToString().Trim()) );
        }
    }
}
