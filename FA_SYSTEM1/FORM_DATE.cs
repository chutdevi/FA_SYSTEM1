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
    public partial class FORM_DATE : Form
    {
        Label LABINPUT ;
        public FORM_DATE()
        {
            InitializeComponent();
        }
        public void BUTTON_NUMPAD(object sender, EventArgs e)
        {
            Button BNTPUT = (Button)sender;
            String STRTXT = BNTPUT.Text.ToString();

            switch(STRTXT)
            {
                case"OK":
                    CONTROLFORMS.FMMOVE.LNKLAB1.Text = LABYAR.Text + "-" + LABMTH.Text.ToString().PadLeft(2, '0') + "-" + LABDAY.Text.ToString().PadLeft(2, '0');
                    this.Close();
                    break;
                case"CLEAR":
                    LABDAY.Text = String.Empty;
                    LABMTH.Text = String.Empty;
                    LABYAR.Text = String.Empty;
                    break;
                case "TODAY":
                    LABDAY.Text = DateTime.Now.AddDays(-0).ToString("dd");
                    break;
                case "THIS MONTH":
                    LABMTH.Text = DateTime.Now.AddDays(-0).ToString("MM");
                    break;
                case "THIS YEAR":
                    LABYAR.Text = DateTime.Now.AddDays(-0).ToString("yyyy");
                    break;
                default:
                    LABINPUT.Text += STRTXT;
                    break;
            }

        }

        private void LABCLICK(object sender, EventArgs e)
        {
            LABINPUT = (Label)sender;
            LABINPUT.Text = String.Empty;
        }

        private void FORM_DATELOAD(object sender, EventArgs e)
        {
            //LABINPUT.Text = String.Empty;
            LABDAY.Text = DateTime.Now.AddDays(-0).ToString("dd");
            LABMTH.Text = DateTime.Now.AddDays(-0).ToString("MM");
            LABYAR.Text = DateTime.Now.AddDays(-0).ToString("yyyy");
        }
    }
}
