using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FA_SYSTEM1
{
    public partial class FORMINPUT_LOGIN : Form
    {
        public FORMINPUT_LOGIN()
        {
            InitializeComponent();
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        public void HideCaret()
        {
            HideCaret(TXTB1.Handle);
        }
        private void FORMINPUT_LOGIN_LOAD(object sender, EventArgs e)
        {
            CONTROLFORMS.CONFPRO = new CONFP();


        }

        private void TXTB1_TEXTCHANGED(object sender, EventArgs e)
        {
            HideCaret();
            TXTB1.SelectionStart = TXTB1.Text.Length;
            if (TXTB1.Text.Length > 5)
            {
                MessageBox.Show("รหัสพนักงานต้องไม่เกิน 5 ตัวอักษร");
                TXTB1.Focus();
                TXTB1.Text = "";
            }
            else if (TXTB1.Text.Length > 4)
            {
                CHECKING_USER();
            }
        }
        private void TXTB1_TEXTGOTFOCUS(object sender, EventArgs e)
        {
            HideCaret();
        }
        private void CHECKING_USER()
        {
            CONTROLFORMS.FMLOGINI = this;
            CONTROLFORMS.LOGIN_PROGRAM(TXTB1.Text);
        }

        private void FMKEYPRESS(object sender, KeyPressEventArgs e)
        {
            char k = (e.KeyChar);
            switch (k)
            {
                case (char)Keys.Escape: this.Close(); break;
                case (char)Keys.Enter : EVENENTER();  break;
            }
        }
        private void EVENENTER()
        {
             
            switch(TXTB1.Text.ToString().Trim().ToUpper() )
            {
                case "CN":
                    FORM_CONF c = new FORM_CONF();
                    c.ShowDialog(); 
                    break;
                case "CS":
                    Application.Exit();
                    break;
            }

        }

        private void FORMINPUT_LOGINSHOW(object sender, EventArgs e)
        {
            HideCaret();
            CONTROLFORMS.SETSERIAL();
            CONTROLFORMS.TXTPORT = TXTB1;
        }
    }
}
