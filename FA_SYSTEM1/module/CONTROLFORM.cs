using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using Newtonsoft.Json;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace FA_SYSTEM1
{

    static class CONTROLFORMS
    {
       private static FORM_PASSWORD FMPASS;       
       public static FORM_MENU FMMENU { get; set; } /* FORM PROGRAM */
       public static FORMINPUT_LOGIN FMLOGINI { get; set; } /* FORM PROGRAM */
       public static FORM_MOVEL FMMOVE { get; set; } /* FORM PROGRAM */
       public static FORM_CONF FMCONF;  /* FORM CONFIGURATION */
       


       public static USERS MEMBER;  /* CLASS USERS */
       public static String PIN { get; set; }  /* CLASS USERS */  
        
       public static DATAS ACPTLT;    /* CLASS DATAS */     
       public static CONFP CONFPRO;   /* CLASS CONFIGURATION */
       public static SerialPort PORT; /* PORT SERAIL */     
       public static TextBox TXTPORT { get; set; }/* CONTROL BOX */

        

       static CONTROLFORMS()
       {
            
            //SETSERIAL();
       }
    
    /* BOX CONTROL LOGIN PROGRAM */
       public static void LOGIN_PROGRAM(string u = "")
       {
           MEMBER = new USERS(u);
           if( MEMBER.USERIN() )
           {
                //FMLOGIN.FORM_CLOSE_SERAIL();
                FMPASS = new FORM_PASSWORD();
                FMPASS.ShowDialog();                
           }

       }
       public static void LOGIN_PIN()
       {
           if (MEMBER.USERPIN(PIN)){
               FMPASS.Close();
               FMLOGINI.Close();
           }
           else{
               MessageBox.Show("Password invelid!!");
           }
       }
    
    /* BOX CONTROL FROM_MENU */
       public static void MENUVIEWS(){  if(FMMENU.Visible) FMMENU.Hide(); else FMMENU.Show(); }
       public static void CLOSE_FORMLOGIN() { FMMENU.Close(); } 
    /* BOX CONTROL PORT SERIAL  */
       public static void SETSERIAL()
       {
          string STRPAHT = AppDomain.CurrentDomain.BaseDirectory + "conf.ini";
          Console.WriteLine(STRPAHT +" => " + File.Exists(STRPAHT) );// return;
          if ( File.Exists(STRPAHT) )
          {

                SETSERAILCONNECT();
          }
          else 
          {
                // This path is a directory
                MessageBox.Show("Erroe message: Not config port ", "ERROR PORT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //SETSERAILCONNECT();
                //
                FMCONF.ShowDialog();
          }

          //SETSERAILCONNECT();

        }
       private static void SETSERAILCONNECT()
        {
             try
             {
                PORT = new SerialPort(CONFPRO.SERAILPORTCONF, 9600, Parity.None, 8, StopBits.One);
                PORT.Open();
                PORT.DiscardInBuffer();
                PORT.DiscardOutBuffer();
                PORT.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SERIAL_DATARECEIVED);
             }
             catch (Exception e)
             {
                 MessageBox.Show("Erroe message: " + e.Message, "ERROR PORT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 FMCONF.ShowDialog();
             }
        }
       public static void CLOSESERAIL()
        {
           if (PORT.IsOpen)
           {
               Thread CloseDown = new Thread(new ThreadStart(delegate
               {
                   try
                   {
                       PORT.Close(); //close the serial port
                       PORT.Dispose();
                   }
                   catch (Exception ex)

                   {
                       MessageBox.Show(ex.Message); //catch any serial port closing error messages
                   }
               })); //close port in new thread to avoid hang

               CloseDown.Start();
           }
        }
       static void SERIAL_DATARECEIVED(object sender, SerialDataReceivedEventArgs e)
       {
           string data_sc = PORT.ReadExisting(); 
           TXTPORT.Invoke(new Action(() => TXTPORT.Text = data_sc.ToString().Trim()));
       }
        /* BOX CONTROL DATA ACCEPT */
        public static void SEARCHACCEPT(String d) => ACPTLT = new DATAS(d);//return ACPTLT;//Console.WriteLine(ACPTLT.DATASYS);




    }

}
