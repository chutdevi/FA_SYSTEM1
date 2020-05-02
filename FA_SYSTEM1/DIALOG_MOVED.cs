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
    public partial class DIALOG_MOVED : Form
    {
        private int LOCATIONX = 0;
        private int LOCATIONY = 0;
        private int PROGRESS = 0;
        public DIALOG_MOVED()
        {
            InitializeComponent();
        }

        private void FORMKEYPRESS(object sender, KeyPressEventArgs e)
        {

            char k = ( e.KeyChar );
            switch (k)
            {
                case (char)Keys.Escape:  this.Close();  break;
            }
            
        }

        private void DIALOG_MOVED_FormClosed(object sender, FormClosedEventArgs e)
        {
            CONTROLFORMS.FMMOVE.Enabled = true;
        }

        private void TM1TICK(object sender, EventArgs e)
        {
            LOCATIONX += 3;

            label1.Text = (++PROGRESS).ToString().PadLeft(2, '0') + " %";
            PICB1.Location = new Point(LOCATIONX, LOCATIONY);

            if (PROGRESS == 100)
            {
                LOCATIONX = 155;
                PROGRESS = 0;
               // TM1.Stop();
            }
                    
        }

        private void BNTBORDER_Click(object sender, EventArgs e)
        {

        }

        private void DIALOG_MOVEDLOAD(object sender, EventArgs e)
        {
            this.LOCATIONX = PICB1.Location.X;
            this.LOCATIONY = PICB1.Location.Y;
            TM1.Start();
        }
    }
}
