using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FA_SYSTEM1
{

    public partial class FORM_MENU : Form
    {
        private FORMINPUT_LOGIN LOGIN;
        public FORM_MENU()
        {
            InitializeComponent();

        }
        public void LOGINCLOSE()
        {
            LOGIN.Close();
        }
        private void FORMMENULOAD(object sender, EventArgs e)
        {
            CONTROLFORMS.FMMENU = this;
        }
        private void FORMMENUSHOWN(object sender, EventArgs e)
        {
            LOGIN = new FORMINPUT_LOGIN();
            LOGIN.ShowDialog();
        }
        private void BUTMENUMOUSEUP(object sender, MouseEventArgs e)
        {
            Button bnt = (Button)sender;
            bnt.FlatAppearance.BorderColor = Color.White;
            bnt.FlatAppearance.BorderSize = 0;
        }
        private void BUTMENUMOUSEDOWN(object sender, MouseEventArgs e)
        {
            Button bnt = (Button)sender;
            bnt.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            bnt.FlatAppearance.BorderSize = 5;
        }

        private void BNTMENUCLICK(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
            int btag  = Int16.Parse( (bnt.Tag).ToString());
            switch (btag)
            {
                case 1:
                    FORM_MOVEL m = new FORM_MOVEL();
                    
                    m.Show();
                    CONTROLFORMS.MENUVIEWS();
                    CONTROLFORMS.FMMOVE = m;

                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    Application.Exit();
                    break;
            }
        }
    }
}
