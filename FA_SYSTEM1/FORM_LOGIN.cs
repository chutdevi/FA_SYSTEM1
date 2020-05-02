
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

using FA_SYSTEM1;

namespace FA_SYSTEM1
{


    public partial class FORM_LOGIN : Form
    {
        private SerialPort serialP;
        public FORM_LOGIN()
        {
            InitializeComponent();
            
        }
        private void SETSERIAL()
        {
           Thread thd1 = new Thread(delegate ()
           {
               Invoke((MethodInvoker)delegate
               {
                   try
                   {

                           serialP = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
                           serialP.Open();
                           serialP.DiscardInBuffer();
                           serialP.DiscardOutBuffer();
                           //serialP.NewLine = "\r";
                           
                           textBox1.Text = string.Empty;
                           serialP.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SERIAL_DATARECEIVED);
                   }
                   catch ( Exception e)
                   {
                       MessageBox.Show("Ma dia ngi " + e.Message );
                   }
                  
                  
               });
           
           });
           thd1.Start();
        }

        private void FORM_LOAD(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.Text = string.Empty;
            Application.EnableVisualStyles();
            timer1.Start();
            //serialP.Open();
            SETSERIAL();
            //Console.WriteLine( SerialPort.GetPortNames()[0] );
        }
        public void SETLOAD()
        {
            textBox1.Text = string.Empty;
            textBox1.Focus();
            Button4.Visible = false;
            SendKeys.Send("{tab}");
            serialP.DiscardInBuffer();
            serialP.DiscardOutBuffer();
            //SETSERIAL();
            timer1.Start();
            //Console.WriteLine( SerialPort.GetPortNames()[0] );
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
           Dat.Text = DateTime.Now.ToString("yyyy / MM / dd     hh : mm : ss");
        }


        private void TextBox1_TextChanged(object sender, EventArgs e)
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
                CHECKING_USER();
            }
               

        }


        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            //mssql.main();
            if (textBox1.Text.Length > 4)
            {
                CHECKING_USER();
            }
            else { MessageBox.Show("รหัสต้องมากกว่า 4 ตัว");  }

        }
        private void CHECKING_USER()
        {

            Button1.Visible = false;
            label2.Visible = true;

            label2.Location = new Point(301, 337);
            
            CONTROLFORMS.LOGIN_PROGRAM(textBox1.Text);


            Button1.Visible = true;
            label2.Visible = false;
        }


        private void CloseSerialOnExit()
        {
            try
            {
                serialP.Close(); //close the serial port
                serialP.Dispose();
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message); //catch any serial port closing error messages
            }
            //this.Invoke(new EventHandler(NowClose)); //now close back in the main thread
        }
        private void NowClose(object sender, EventArgs e)
        {
            //this.Invoke(new EventHandler( NowClose  );
            this.Close(); //now close the form
        }
        private void FORM_ACTIVED(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox1.Focus();
            Button4.Visible = false;
            SendKeys.Send("{tab}");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
           // Page_regs regs = new Page_regs();
           // timer1.Stop();
           // regs.ShowDialog();
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
                    Button4.Visible = true;
                    textBox1.Text = "";
                    Evk.key_num = 0;
                    break;
                default:
                    //Console.WriteLine("Default case");
                    break;
            }
            Evk.key_num = 0;
        }

        private void SERIAL_DATARECEIVED(object sender, SerialDataReceivedEventArgs e)
        {
            string data_sc = serialP.ReadExisting();
            //Console.WriteLine( data_sc.Length );
            //MessageBox.Show(data_sc);
            textBox1.Invoke( new Action(() => textBox1.Text = data_sc.ToString().Trim()) );
        }
    
    
    
    
        public void FORM_CLOSE_SERAIL()
        {
            if (serialP.IsOpen)
            {
                Thread CloseDown = new Thread(new ThreadStart(CloseSerialOnExit)); //close port in new thread to avoid hang

                CloseDown.Start();
            }
        }
    
    }
}
