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

    public partial class FORM_NUMP : Form
    {

        public FORM_NUMP()
        {
            InitializeComponent();
            this.ShowDialog();
        }
        public FORM_NUMP( TextBox tx )
        {
            InitializeComponent();
        }

        public void BUTTON_NUMPAD(object sender, EventArgs e)
        {
            Button BNTPUT  = (Button)sender;
            String STRTAG  = BNTPUT.Tag.ToString();

            if (STRTAG == "K") this.Close();
            else if (STRTAG == "R") TXTBPASS.Text = String.Empty;
            else TXTBPASS.Text += STRTAG;
            
        }

        private void FORM_NUMPCLOSED(object sender, FormClosedEventArgs e)
        {
            CONTROLFORMS.PIN =  TXTBPASS.Text;
            CONTROLFORMS.LOGIN_PIN();
        }

        private void BNTBORDER1_Click(object sender, EventArgs e)
        {

        }
    }
}
