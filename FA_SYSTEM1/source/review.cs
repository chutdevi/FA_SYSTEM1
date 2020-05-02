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
    public partial class review_rec : Form
    {
        public review_rec()
        {
            InitializeComponent();
        }

        private void Dat_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Dat.Text = DateTime.Now.ToString("yyyy / MM / dd     hh : mm : ss");
        }

        private void review_rec_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            timer1.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
