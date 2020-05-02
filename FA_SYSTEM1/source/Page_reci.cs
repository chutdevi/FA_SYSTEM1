using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FA_SYSTEM1;
using Newtonsoft.Json.Linq;

namespace FA_SYSTEM1.source
{
    public partial class Page_reci : Form
    {
        private Control_page data_con;
        private List<string> qr_tag = new List<string>();
        public Page_reci()
        {
            InitializeComponent();
            
        }

        private void Page_reci_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }

        private void Page_reci_Load(object sender, EventArgs e)
        {
                    //this.WindowState = FormWindowState.Maximized;
            linkLabel1.Text = DateTime.Now.AddDays(-0).ToString("yyyy-MM-dd");
            list_set();
        }






        public void tread_task(Control_page ty)
        {
            data_con = ty;

            label1.Text = "Name : " + ty.user_dt._name_user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data_con.Control_logout();
        }
        private void button_refash(object sender, EventArgs e)
        {
            list_set();
        }


        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            int ind = listView1.FocusedItem.Index;
            string[] dt = qr_tag.ToArray();
            //Page_msgb ms = new Page_msgb();

            //ms.ShowDialog();

            //pe.read_qr = qr[ind];
            //Console.WriteLine(listView1.Items[ind].SubItems[1].Text);

            data_con.rtag_page.list_set(listView1.Items[ind].SubItems[1].Text);
            data_con.rtag_page.label_po.Text = listView1.Items[ind].SubItems[1].Text;
            data_con.rtag_page.label_total.Text = listView1.Items[ind].SubItems[3].Text;
            data_con.rtag_page.label_lot.Text = listView1.Items[ind].SubItems[5].Text;
            data_con.rtag_page.label_receive_date.Text = DateTime.ParseExact(dt[ind], "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            data_con.rtag_page.rDate = dt[ind];
            data_con.rtag_page.Show();
            this.Hide();
        }

        private void Page_reci_Activated(object sender, EventArgs e)
        {
            //this.list_set();
        }

        private void Page_reci_Shown(object sender, EventArgs e)
        {

        }


        public void list_set( )
        {
            listView1.Items.Clear();
            JArray rlist =  Api.api_getJArray("http://192.168.161.102/api_system/Api_receiveinmanage/list_acpt?adate=" + linkLabel1.Text.ToString() );
            int listCount = rlist.Count();
            if (listCount < 14) listView1.Columns[4].Width = 230;
            else listView1.Columns[4].Width = 210;
            //Console.WriteLine(listCount); return;
            Font normalfont = new System.Drawing.Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Bold);
            for (int i = 0; i < listCount; i++)
            {
                if (rlist[i]["INSPC_FLG"].ToString() == "QC INSPECTION")
                {
                    ListViewItem lt = new ListViewItem((i).ToString().PadLeft(3, '0'));
                    lt.UseItemStyleForSubItems = false;
                    qr_tag.Add(rlist[i]["RECEIVE_DATE"].ToString());
                    float qty = float.Parse(rlist[i]["RECEIVE_QTY"].ToString());
                    lt.SubItems.Add(rlist[i]["PUCH_ODR_CD"].ToString());
                    lt.SubItems.Add(rlist[i]["ITEM_CD"].ToString());

                    lt.SubItems.Add(qty.ToString("#,##0.00"));
                    lt.SubItems.Add(rlist[i]["DLV_DATE"].ToString());
                    lt.SubItems.Add(rlist[i]["LOT_RECEIVE"].ToString());
                    lt.SubItems[4].Font = normalfont;
                    listView1.Items.Add(lt);
                }
                //listView1.Items[i].SubItems[4].Font = normalfont;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Page_date pd = new Page_date(linkLabel1);

            pd.ShowDialog();
        }

        private void linkLabel1_TextChanged(object sender, EventArgs e)
        {
            if( linkLabel1.Text.Length == 10)
            {
                list_set();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if( checkBox1.Checked == false)
            {
                checkBox1.Text = "O";
            }
            else
            {
                checkBox1.Text = "P";
            }
        }
    }
}
