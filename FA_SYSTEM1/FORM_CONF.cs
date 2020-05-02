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
    public partial class FORM_CONF : Form
    {
        public FORM_CONF() => InitializeComponent();



        private void FORM_CONFLOAD(object sender, EventArgs e)
        {
            CONTROLFORMS.CONFPRO.SETCOMBOPORTSCAN(CMB01);
            CONTROLFORMS.CONFPRO.SETCOMBOPRINTER(CMB02);
        }


        private void BUTTONCONFCLICK(object sender, EventArgs e)
        {
            Button bn = (Button)sender;
            string bntag = bn.Tag.ToString();
            switch(bntag)
            {
                case "ED": break;
                case "CS": this.Close();      break;
                case "SV": EVENBUTTONSAVE();  break;

            }
        }

        private void EVENBUTTONSAVE()
        {
            CONTROLFORMS.CONFPRO.SERAILPORTCONF = CMB01.Text;
            CONTROLFORMS.CONFPRO.PRINTERNAME    = CMB02.Text;
            DialogResult f = MessageBox.Show("Do you want to save the configuration?", "Confirm Configuration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (f == DialogResult.Yes)
            {
                CONTROLFORMS.CONFPRO.WRITECONF();
                this.Close();
            }   
            
        }

       //private void CMB02SELECTINDEXCHANGED(object sender, EventArgs e)
       //{
       //    CONTROLFORMS.CONFPRO.SETCOMBOPRINTER_PAGE( CMB02.Text.ToString(), CMB03 );
       //}
    }
}
