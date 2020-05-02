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
   
    public partial class FORM_MOVEL : Form
    {
        private Int32 VBAR = 0;
        public FORM_MOVEL()
        {
            InitializeComponent();
        }

        private void FORMMOVELOAD(object sender, EventArgs e)
        {
            LNKLAB1.Text = DateTime.Now.AddDays(-0).ToString("yyyy-MM-dd");
        }

        private void BUTTONCLOSE(object sender, EventArgs e)
        {   
            CONTROLFORMS.MENUVIEWS();
            this.Close();
        }

        private void BUTTONSEARCH(object sender, EventArgs e)
        {
            SETGRID();
            //DATAGV1.DataSource = CONTROLFORMS.ACPTLT.DATASYS;
        }
        
        public void SETGRID()
        {
            string d = LNKLAB1.Text;
            CONTROLFORMS.SEARCHACCEPT(d);
            DATAGV1.Rows.Clear();
            foreach (string[] gt in CONTROLFORMS.ACPTLT.CONVERTOLISTRECEIVE())
            {
                DATAGV1.Rows.Add(gt);
            }

            //POSEARCH("5100097387");

        }
        public void POSEARCH(string p)
        {
            foreach (DataGridViewRow row in DATAGV1.Rows)
            {
                string s = ( row.Cells[1].Value != null ) ? row.Cells[1].Value.ToString() : String.Empty;
                //Console.WriteLine(row.Cells[1].Value);
                if ( s != p && s != String.Empty ) { row.Visible = false; } 
            }
        }


        private void BUTTON_UPDOWN(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string s = b.Tag.ToString();

            
            switch( s )
            {
                case "up"  :  VBAR -= 10;  break;//
                case "down":  VBAR += 10;  break;//  
            }
            VBAR = (VBAR < 0 ) ? 0 : ( ( VBAR > CONTROLFORMS.ACPTLT.CONVERTOLISTRECEIVE().Count )? CONTROLFORMS.ACPTLT.CONVERTOLISTRECEIVE().Count :  VBAR  );
            DATAGV1.FirstDisplayedScrollingRowIndex = VBAR;
            //Console.WriteLine(VBAR);
        }

        private void BUTTON_MOVED(object sender, EventArgs e)
        {
            this.Enabled = false;
            DIALOG_MOVED d = new DIALOG_MOVED();
            d.ShowDialog();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            DATAGV1.Refresh();
        }

        private void DATAGV1_MOUSEDOUBLECLICK(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex <= CONTROLFORMS.ACPTLT.CONVERTOLISTRECEIVE().Count-1 )
            {
                try
                {
                    LBR1.Text = DATAGV1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    LBR2.Text = DATAGV1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    LBR3.Text = DATAGV1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    LBR4.Text = DATAGV1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    LBR5.Text = DATAGV1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    LBR6.Text = CONTROLFORMS.ACPTLT.GETDATAFROMINDEX((e.RowIndex), "DLV_DATE");
                    LBR7.Text = CONTROLFORMS.ACPTLT.GETDATAFROMINDEX((e.RowIndex), "LOT_RECEIVE");
                    LBR8.Text = CONTROLFORMS.ACPTLT.GETDATAFROMINDEX((e.RowIndex), "MAX_TAG");
                    LBR9.Text = ((int)(float.Parse(CONTROLFORMS.ACPTLT.GETDATAFROMINDEX(e.RowIndex, "TAG_QTY")))).ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show( ex.Message,"Error Log", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //LBR7.Text = DATAGV1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void LINKDATED(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FORM_DATE d = new FORM_DATE();
            d.ShowDialog();
        }
        
        private void BNTSEACEH_CLICK(object sender, EventArgs e)
        {
            FORM_SCAN d = new FORM_SCAN();
            d.ShowDialog();
        }
    }
}
