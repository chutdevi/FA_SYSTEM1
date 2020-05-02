using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FA_SYSTEM1.source
{
    
    public partial class Page_rtag : Form
    {
        private Control_page data_con;
        private List<string> qr_tag = new List<string>();
        private JArray rlist;
        public string rDate;
        public Page_rtag()
        {
            InitializeComponent();
        }

        private void Page_rtag_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }


        public void tread_task(Control_page ty)
        {
            data_con = ty;

            label1.Text = "Name : " + ty.user_dt._name_user;
        }
        public void list_set(string po)
        {
            listView1.Items.Clear();
            qr_tag.Clear();
            rlist = Api.api_getJArray("http://192.168.161.102/api_system/Api_receiveinmanage/list_atag?po=" + po );
            int listCount = rlist.Count();
            if (listCount < 14) listView1.Columns[4].Width = 190;
            else listView1.Columns[4].Width = 170;
            //Console.WriteLine(rlist);
            //Console.WriteLine( po + " " + listCount);
            Font normalfont = new System.Drawing.Font("Times New Roman", 10, System.Drawing.FontStyle.Bold);
            for (int i = 0; i < listCount; i++)
            {
                ListViewItem lt = new ListViewItem((i).ToString().PadLeft(3, '0'));
                float qty = float.Parse(rlist[i]["TAG_QTY"].ToString());
                qr_tag.Add( rlist[i]["READ_QR"].ToString() );

                lt.SubItems.Add(rlist[i]["TAG_SEQ"].ToString());
                lt.SubItems.Add(rlist[i]["PUCH_ODR_CD"].ToString());
                lt.SubItems.Add(rlist[i]["ITEM_CD"].ToString());
                lt.SubItems.Add(qty.ToString("#,##0.00"));
                listView1.Items.Add(lt);
                //listView1.Items[i].SubItems[3].Font = normalfont;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            data_con.reci_page.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            list_set(label_po.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Page_scan ps = new Page_scan();
              
            ps.ShowDialog();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            int ind = listView1.FocusedItem.Index;
            Page_edit pe = new Page_edit(rlist[ind]);
            //Console.WriteLine(rlist[ind].GetType());
            string[] qr = qr_tag.ToArray();
            //Page_msgb ms = new Page_msgb();
            
            //ms.ShowDialog();
            
            pe.read_qr = qr[ind];
            pe.max_seq = rlist[ind]["MAX_TAG"].ToString();
            pe.ename = data_con.user_dt._ename_user;
            pe.uid = data_con.user_dt._uid_user;
            pe.dep = data_con.user_dt._dep_user;
            pe.rec_date = rDate;

            pe.textBox_item.Text = listView1.Items[ind].SubItems[3].Text ;
            pe.textBox_tag.Text = float.Parse(  listView1.Items[ind].SubItems[4].Text ).ToString("#,##0.00");
            pe.textBox_acpt.Text = float.Parse( label_total.Text).ToString("#,##0.00"); 
            pe.textBox_Ng.Text = "0.00";
            pe.textBox_remain.Text = ( float.Parse( pe.textBox_tag.Text ) - float.Parse( pe.textBox_Ng.Text ) ).ToString("#,##0.00");
            pe.label_seq.Text = listView1.Items[ind].SubItems[1].Text;
            pe.ShowDialog();
        }

        private void Page_rtag_Shown(object sender, EventArgs e)
        {
            //Page_msgb ms = new Page_msgb("เข้าสู่ระบบ สำเร็จ");
        }
    }
}
