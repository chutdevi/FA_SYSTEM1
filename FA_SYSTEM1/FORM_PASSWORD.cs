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

namespace FA_SYSTEM1
{
    public partial class FORM_PASSWORD : Form
    {
        public FORM_PASSWORD()
        {
            InitializeComponent();
        }

        private void FORM_LOAD(object sender, EventArgs e)
        {
            pictureBox1.Image = CONTROLFORMS.MEMBER.IMAGE_USER;
            label2.Text       = CONTROLFORMS.MEMBER.UID_USER + " : " + CONTROLFORMS.MEMBER.NAME_USER;
        }

        private void TextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //TextBox2.Focus();
        }
        private void TextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            //nmPin = new Page_numb(TextBox2);
            //nmPin.ShowDialog();
        }
        private void BNTCLOSED(object sender, EventArgs e)
        {
             this.Close();
            //CONTROLFORMS.FMLOGIN.SETLOAD();
        }
        private void BNTPASSW(object sender, EventArgs e)
        {
            FORM_NUMP NMPIN = new FORM_NUMP();
            //NMPIN.ShowDialog();
        }

    }
}