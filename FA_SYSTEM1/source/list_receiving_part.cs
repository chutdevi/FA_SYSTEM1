using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace FA_SYSTEM1
{
    public partial class Control_rec : Form
    {
        public string str_set;
        public Control_rec()

        {
            InitializeComponent();
            set_itemlist();
        }
        public string setLb
        {
            set
            {
                //listView1.Items[0].SubItems[2].Text = value;
                //listView1.Items[0].SubItems[4].Text = value;
                //listView1.Items[0].SubItems[4].Text = value;
            }
        }
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {         
            int rm = listView1.FocusedItem.Index;                          
            Edit_QTY Editrec = new Edit_QTY(listView1.Items[rm].SubItems[2].Text, double.Parse(listView1.Items[rm].SubItems[4].Text).ToString("#,###"));
            MessageBox.Show("Are you sure.");          
            Hide();
            Editrec.Show();
        }

        private void Control_rec_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            timer1.Start();
        }   
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void set_itemlist()
        {
            string sql = $"CALL ACEPT_LIST10(0,0)";
            string Server = "server = 192.168.161.6; Database = ship; Uid = develop; Pwd = tbk";
            MySqlConnection conn = new MySqlConnection(Server);
            try  
            {              
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                listView1.Items.Clear();
                int nw = 1;
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {                                   
                    if (rdr.HasRows)
                    {                      
                        while (rdr.Read())
                        {
                            ListViewItem lvi = new ListViewItem((nw++).ToString().PadLeft(3, '0'));
                            lvi.SubItems.Add(rdr.GetValue(0).ToString());
                            lvi.SubItems.Add(rdr.GetValue(2).ToString());
                            lvi.SubItems.Add(rdr.GetValue(10).ToString());
                            lvi.SubItems.Add(rdr.GetValue(4).ToString());
                            lvi.SubItems.Add(rdr.GetValue(13).ToString());
                            listView1.Items.Add(lvi);
                        }                    
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Program", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                conn.Close();
            }
        }
        private void Dat_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Dat.Text = DateTime.Now.ToString("yyyy / MM / dd    hh : mm : ss");
        }

        private void userid_Click(object sender, EventArgs e)
        {       
        }

        public void set_labelUser(string id)
        {
            userid.Text = id;
        }
        public void set_labelname(string name)
        {
            username.Text = name;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_page Fp = new F_page();
            Fp.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            review_rec Fm = new review_rec();
            Fm.Show();
            Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            review_rec Fm = new review_rec();
            Fm.Show();
            Hide();
        }
    }
}
