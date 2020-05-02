using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FA_SYSTEM1
{
    public partial class FORM_SCAN : Form
    {
        public FORM_SCAN()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        public void HideCaret()
        {
            HideCaret(TXTSC01.Handle);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CONTROLFORMS.TXTPORT = TXTSC01;
            TXTSC01.Text = String.Empty;
        }

        private void BNTSENDERRORCLICK(object sender, EventArgs e)
        {
            MessageBox.Show("Send error system ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            NOTIFICATION.LINENOTF("\n⚠️ System error\n" + "send by : " + CONTROLFORMS.MEMBER.ENAME_USER);
            this.Close();
        }

        private void TXTCHANGED(object sender, EventArgs e)
        {
            HideCaret();
            Application.DoEvents();
            if(TXTSC01.Text.Length > 10)
            {

                if (TXTSC01.Text.Substring(0, 2).Equals("GD")) { TXTSC01.Text = TXTSC01.Text.Substring(2, 10); this.Close(); } 
                else if (TXTSC01.Text.Substring(0, 2).Equals("51")) { TXTSC01.Text = TXTSC01.Text.Substring(0, 10); this.Close();  }
                else { TXTSC01.Text = String.Empty; }

            }
        }
        private void TXTB1_TEXTGOTFOCUS(object sender, EventArgs e)
        {
            HideCaret();
        }

        private void TRADSCAL()
        {
            Thread thd1 = new Thread(delegate ()
            {
                Invoke((MethodInvoker)delegate
                {
                    CONTROLFORMS.FMMOVE.SETGRID();
                });
      

            });

            thd1.Start();
        }

        private void FORM_SCANCLOSED(object sender, FormClosedEventArgs e)
        {
            CONTROLFORMS.FMMOVE.POSEARCH( TXTSC01.Text.ToString() );
        }
    }
}
