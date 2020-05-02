
using Newtonsoft.Json.Linq;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FA_SYSTEM1.source
{
    public partial class Page_edit : Form
    {
        public string read_qr { get; set; }
        public string rec_date { get; set; }
        public string isu_date { get; set; }
        public string seq { get; set; }
        public string max_seq { get; set; }
        public string ename { get; set; }
        public string uid  { get; set; }
        public string dep { get; set; }
        public JToken det { get; set; }
        public JArray mst { get; set; }
        private Page_numb nump;
        public Page_edit()
        {
            InitializeComponent();
        }
        public Page_edit(JToken j)
        {
            InitializeComponent();

            det = j;
            string vend = det["VEND_CD"].ToString();
            Thread thd1 = new Thread(delegate (object obj)
            {
                //Console.WriteLine("http://192.168.161.102/api_system/Api_receiveinmanage/list_mtag?vend_cd=" + vend + "&item_cd=" + det["ITEM_CD"].ToString());
                mst =  Api.api_getJArray("http://192.168.161.102/api_system/Api_receiveinmanage/list_mtag?vend_cd=" + vend + "&item_cd=" + det["ITEM_CD"].ToString() ) ;
                Console.WriteLine(mst);
            });

            thd1.Start();
            
        }
        private void Page_edit_Load(object sender, EventArgs e)
        {
           // mssql.ms_qery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_Ng_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Ng.Text != "")
            {
                try
                {
                    textBox_Ng.Text = float.Parse(textBox_Ng.Text).ToString("#,#0.00");

                    textBox_remain.Text = (float.Parse(textBox_tag.Text) - float.Parse(textBox_Ng.Text)).ToString("#,#0.00");
                }
                catch (Exception ex)
                {
                    //textBox_Ng.Text = float.Parse(textBox_Ng.Text).ToString("#,#0.00");
                    Console.WriteLine(ex.Message);

                }

            }

        }

        private void textBox_Ng_Click(object sender, EventArgs e)
        {
            nump = new Page_numb(textBox_Ng);
            nump.set_formatpass(false);
            nump.set_flgoin(1);
            nump.ShowDialog();
        }



        private void textBox_remain_TextChanged(object sender, EventArgs e)
        {
            if (textBox_remain.Text != "")
            {
                if (float.Parse(textBox_remain.Text) < 0)
                {
                    Page_msgb ms = new Page_msgb("มีการใส่จำนวนผิดพลาด");
                    //ms.ShowDialog();
                    nump.textBox1.Text =  "";
                    textBox_Ng.ForeColor = Color.Red;

                }
                else
                {
                    textBox_Ng.ForeColor = Color.Black;
                }
            }
            else Console.WriteLine("งง");

        }
        private void button4_Click(object sender, EventArgs e)
        {
            //Page_msgb ms = new Page_msgb();
            //foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            //{
            //    MessageBox.Show(printer);
            //}
            //Panel panel = new Panel();
            //this.Controls.Add(panel);
            //Graphics grp = panel.CreateGraphics();
            //Size formSize = this.ClientSize;
            //bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            //grp = Graphics.FromImage(bitmap);
            //Point panelLocation = PointToScreen(panel.Location);
            //grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);

            //printDocument1.PrinterSettings.DefaultPageSettings.PaperSize = new PaperSize("Custom", 20, 20);
            printDocument1.PrinterSettings.PrinterName = "Citizen CL-S400DT #4";
            //printDocument1.PrinterSettings.PrinterName = @"\\192.168.130.79\Citizen CL-S400DT";
            
            //for (int i = 0; i < printDocument1.PrinterSettings.PaperSizes.Count; i++) {  Console.WriteLine(printDocument1.PrinterSettings.PaperSizes[i]);   } 

            //foreach (string printer in PrinterSettings.InstalledPrinters) Console.WriteLine(printer);

            if( float.Parse( textBox_remain.Text ) < 1)
            {
                Page_msgb ms = new Page_msgb("Tag remain ไม่ควรมี remain น้อยกว่า 1");
            }
            else
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.WindowState = FormWindowState.Normal;
                printPreviewDialog1.StartPosition = FormStartPosition.CenterParent;
                printPreviewDialog1.ClientSize = new Size(800, 600);
                // printDocument1.Print();
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                //printPreviewDialog1.Print
                // printPreviewDialog1.Document.PrinterSettings.DefaultPageSettings.PaperSize = new PaperSize("Custom", 20, 20);
                 printPreviewDialog1.ShowDialog();
                //printDocument1.Print();
            }





            
        }


        Bitmap bitmap;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData str_qr = qr.CreateQrCode(read_qr,QRCodeGenerator.ECCLevel.M);
            QRCode code = new QRCode(str_qr);
            Image img_qr = code.GetGraphic(5);

            str_qr = qr.CreateQrCode(uid, QRCodeGenerator.ECCLevel.M);
            code   = new QRCode(str_qr);
            Image uid_qr = code.GetGraphic(5);


            printDocument1.PrinterSettings.DefaultPageSettings.PaperSize = new PaperSize("Custom", 800, 310);

            Console.Write(uid + " " + ename + "Test!." );
            //printDocument1.PrinterSettings.DefaultPageSettings.PaperSize.Height = 700;
            //printDocument1.PrinterSettings.DefaultPageSettings.PaperSize.Width = 2300;
            //Margins margins = new Margins(2, 2, 0, 0);
            //printDocument1.DefaultPageSettings.Margins = margins;
            //printDocument1.OriginAtMargins = true;
            Graphics g = ev.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            Pen pen_in = new Pen(Color.Black, 2);
            StringFormat format = new StringFormat();
            format = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            string[] nm = ename.Split(' ');

            string name = nm[0] + "  " + nm[1].Substring(0, 1) + ".";
            isu_date = DateTime.Now.ToString("yyyyMMdd");
            //ev.PageSettings.PrintableArea;
            //g.DrawRe

            g.DrawRectangle(pen, 10, 10, 700, 285);
            g.DrawRectangle(pen_in, 10, 10, 700, 25);
            //g.DrawRectangle(pen_in, 10, 15, 645, 25);
            g.DrawRectangle(pen_in, 10, 85,  150, 50);
            g.DrawRectangle(pen_in, 10, 135, 150, 60);

            g.DrawRectangle(pen_in, 310,  10,  200, 25);
            g.DrawRectangle(pen_in, 510,  10,  200, 25);
            g.FillRectangle(new SolidBrush(Color.Black), 310, 10, 200, 25);

            g.DrawRectangle(pen_in, 510,  85,  100, 50);
            g.DrawRectangle(pen_in, 310,  135, 300, 60);
            g.DrawRectangle(pen_in, 310,  245, 150, 50);
            g.DrawRectangle(pen_in, 460,  195, 150, 50);
            //g.DrawRectangle(pen_in, 360,  135, 150, 160);

            g.DrawRectangle(pen_in, 10,   35,  300, 50);
            g.DrawRectangle(pen_in, 310,  35,  300, 50);
            g.DrawRectangle(pen_in, 160,  85,  450, 50);
            g.DrawRectangle(pen_in, 160,  135, 550, 60);
            g.DrawRectangle(pen_in, 10,   195, 600, 50);
            g.DrawRectangle(pen_in, 10,   245, 150, 50);
            g.DrawRectangle(pen_in, 160,  245, 450, 50);
            g.FillRectangle(new SolidBrush(Color.Black), 510, 85, 100, 50);


            g.DrawRectangle(pen_in, 610, 35, 100, 260);
            g.DrawString("TBKK Thailand Co.,Ltd.", new Font("Calibri Light", 12, FontStyle.Bold), new SolidBrush(Color.Black),  12, 13);
            g.DrawString("QC Inspection", new Font("Calibri Light", 12, FontStyle.Bold), new SolidBrush(Color.White), 320, 13);
            g.DrawString("035 IDENTIFICATION_TAG", new Font("Calibri Light", 10, FontStyle.Bold), new SolidBrush(Color.Black), 520, 15);

            g.DrawString("PARTS NO"     , new Font("Calibri Light", 8, FontStyle.Bold), new SolidBrush(Color.Black), 12, 37);
            g.DrawString("LOCATION/AREA", new Font("Calibri Light", 8, FontStyle.Bold), new SolidBrush(Color.Black), 312,37);
            g.DrawString("QTY"          , new Font("Calibri Light", 8, FontStyle.Bold), new SolidBrush(Color.Black), 12, 87);
            g.DrawString("SUPPLIER"     , new Font("Calibri Light", 8, FontStyle.Bold), new SolidBrush(Color.Black), 12, 137);
            g.DrawString("SUPPLIER NAME", new Font("Calibri Light", 8, FontStyle.Bold), new SolidBrush(Color.Black), 12, 197);
            g.DrawString("ORDER NO"     , new Font("Calibri Light", 8, FontStyle.Bold), new SolidBrush(Color.Black), 12, 247);

            g.DrawString("PARTS NAME"   , new Font("Calibri Light", 8, FontStyle.Bold), new SolidBrush(Color.Black), 162, 87);
            g.DrawString("TOTAL"        , new Font("Calibri Light", 8, FontStyle.Bold), new SolidBrush(Color.Black), 162, 137);
            //g.DrawString("ORDER NO"     , new Font("Calibri Light", 8, FontStyle.Bold), new SolidBrush(Color.Black), 162, 197);
            g.DrawString("RECEIVE DATE" , new Font("Calibri Light", 8, FontStyle.Bold), new SolidBrush(Color.Black), 162, 247);

            g.DrawString("INSPC. ISSU BY", new Font("Calibri Light", 8, FontStyle.Bold), new SolidBrush(Color.Black), 312, 137);

            g.DrawString("SNP."           , new Font("Calibri Light", 8, FontStyle.Bold), new SolidBrush(Color.Black), 312, 247);
            //g.DrawString("LOT QTY"        , new Font("Calibri Light", 8, FontStyle.Bold), new SolidBrush(Color.Black), 312, 277);

            //g.DrawString("INSPC. ISSU BY"   , new Font("Calibri Light", 8, FontStyle.Bold), new SolidBrush(Color.Black), 462, 137);
            
            g.DrawString("PAGE"             , new Font("Calibri Light", 8, FontStyle.Bold), new SolidBrush(Color.Black), 462, 197);
            //g.DrawString("TEST Inspection"  , new Font("Calibri Light", 8, FontStyle.Bold), new SolidBrush(Color.Black), 462, 227);
            g.DrawString("ISSU DATE"        , new Font("Calibri Light", 8, FontStyle.Bold), new SolidBrush(Color.Black), 462, 247);



            g.DrawString("ID."  , new Font("Calibri Light", 8, FontStyle.Bold), new SolidBrush(Color.Black), 612, 137);
            g.DrawString("DEPT.", new Font("Calibri Light", 8, FontStyle.Bold), new SolidBrush(Color.Black), 612, 177);
            g.DrawString("TAG REMAIN", new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.White), 515, 102);

            g.DrawString(det["ITEM_CD"].ToString(),       new Font("Calibri Light", 18, FontStyle.Bold), new SolidBrush(Color.Black), 12, 50);

            g.DrawString(mst[0]["ITEM_NAME"].ToString(), new Font("Calibri Light", 18, FontStyle.Bold), new SolidBrush(Color.Black), 162, 102);     
            
            g.DrawString(mst[0]["VEND_CD"].ToString()  , new Font("Calibri Light", 20, FontStyle.Bold), new SolidBrush(Color.Black), 12, 160);
            g.DrawString(name.ToUpper(), new Font("Calibri Light", 20, FontStyle.Bold), new SolidBrush(Color.Black), 312, 160);
            g.DrawString(this.uid, new Font("Calibri Light", 8, FontStyle.Bold), new SolidBrush(Color.Black), 644, 137);
            g.DrawString(this.dep, new Font("Calibri Light", 8, FontStyle.Bold), new SolidBrush(Color.Black), 644, 177);

            g.DrawString(mst[0]["VEND_NAME"].ToString(), new Font("Calibri Light", 12, FontStyle.Bold), new SolidBrush(Color.Black), 12, 220);





            g.DrawString(det["LOCATION_PART"].ToString(), new Font("Calibri Light", 18, FontStyle.Bold), new SolidBrush(Color.Black), 312, 50);


            //g.DrawString(mst[0]["PKG_UNIT_QTY"].ToString(), new Font("Calibri Light", 8, FontStyle.Bold), new SolidBrush(Color.Black), 362, 277);


            g.DrawString(det["PUCH_ODR_CD"].ToString() ,  new Font("Calibri Light", 18, FontStyle.Bold), new SolidBrush(Color.Black), 12, 262);

            g.DrawString(rec_date, new Font("Calibri Light", 18, FontStyle.Bold), new SolidBrush(Color.Black), 183, 262);
            g.DrawString(isu_date, new Font("Calibri Light", 18, FontStyle.Bold), new SolidBrush(Color.Black), 483, 262);



           
            float seq_total = float.Parse(textBox_acpt.Text) / float.Parse(det["TAG_QTY"].ToString());
            //double seq_total = 3.0 / 2.0;
             
            Console.WriteLine( seq_total + " = > " + (Math.Ceiling(seq_total) ) );

            g.DrawString( label_seq.Text + '/' + max_seq.ToString().PadLeft(3, '0'), new Font("Calibri Light", 20, FontStyle.Bold),  new SolidBrush(Color.Black), 495, 210);
            //g.DrawString(float.Parse(textBox_acpt.Text).ToString("###0"), new Font("Calibri Light", 20, FontStyle.Bold), new SolidBrush(Color.Black), 162, 160);


            g.DrawString(float.Parse(textBox_remain.Text).ToString("###0"), new Font("Calibri Light", 20, FontStyle.Bold), new SolidBrush(Color.Black), new RectangleF(12, 100, 145, 35), format);
            g.DrawString(float.Parse(textBox_acpt.Text  ).ToString("###0"), new Font("Calibri Light", 20, FontStyle.Bold), new SolidBrush(Color.Black), new RectangleF(162, 160, 145, 35), format);

            //format = new StringFormat(StringFormatFlags.DirectionRightToLeft);

            g.DrawString(float.Parse(mst[0]["PKG_UNIT_QTY"].ToString()).ToString("###0"), new Font("Calibri Light", 18, FontStyle.Bold), new SolidBrush(Color.Black), new RectangleF(310, 262, 145, 50), format);

            g.DrawImage(img_qr, new Rectangle(612,  37, 95, 95)); //QR CODE

            g.DrawImage(img_qr, new Rectangle(612, 197, 95, 95)); //QR CODE

            g.DrawImage(uid_qr, new Rectangle(644, 147, 32, 32)); //QR CODE USER


        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
