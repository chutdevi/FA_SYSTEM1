using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FA_SYSTEM1
{

    class CONFP
    {
        public string SERAILPORTCONF { get; set; }
        public string PRINTERNAME { get; set; }


        private readonly string STRPAHT = AppDomain.CurrentDomain.BaseDirectory + "conf.ini";

        public CONFP()
        {
            CONTROLFORMS.FMCONF = new FORM_CONF();
            try
            {
                string text = File.ReadAllText(STRPAHT);
                JObject con = JObject.Parse(string.Format("{{ {0} }}", text));
                SERAILPORTCONF = con["COMPORT"].ToString();
                PRINTERNAME = con["PRINTNM"].ToString();
            }catch(Exception ex)
            {
                MessageBox.Show("Erroe message: " + ex.Message, "ERROR PORT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CONTROLFORMS.FMCONF.ShowDialog();
            }
        }

        public void WRITECONF()
        {
            string s = String.Empty;
            s += String.Format("COMPORT:\"{0}\",\r\n", SERAILPORTCONF );
            s += String.Format("PRINTNM:\"{0}\"", PRINTERNAME );
            System.IO.File.WriteAllText(STRPAHT, s);
            //System.IO.File.AppendAllLines( STRPAHT, new[] { "Error time : " + DateTime.Now.ToString() + "Error " + ex.Message }); 
        }

        public void SETCOMBOPORTSCAN(ComboBox c)
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            c.Items.Clear();
            c.AutoCompleteCustomSource.Clear();
            c.Items.AddRange(ports);
            c.AutoCompleteCustomSource.AddRange(ports);

            c.Text = (SERAILPORTCONF.Length > 0) ? SERAILPORTCONF : String.Empty;
        }
        public void SETCOMBOPRINTER(ComboBox c)
        {
            c.Items.Clear();
            c.AutoCompleteCustomSource.Clear();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                c.Items.Add(printer);// Console.WriteLine(printer); 
                c.AutoCompleteCustomSource.Add(printer);
            }
            c.Text = (PRINTERNAME.Length > 0) ? PRINTERNAME : String.Empty;
        }
        public void SETCOMBOPRINTER_PAGE(string s, ComboBox c)
        {
            c.Items.Clear();
            c.AutoCompleteCustomSource.Clear();
            System.Drawing.Printing.PrintDocument PNTDOC = new System.Drawing.Printing.PrintDocument();
            PNTDOC.PrinterSettings.PrinterName = s;
            for (int i = 0; i < PNTDOC.PrinterSettings.PaperSizes.Count; i++) 
            {
                //Console.WriteLine(PNTDOC.PrinterSettings.PaperSizes[i]);
                c.Items.Add( PNTDOC.PrinterSettings.PaperSizes[i] );// Console.WriteLine(printer); 
                c.AutoCompleteCustomSource.Add( PNTDOC.PrinterSettings.PaperSizes[i].ToString() );
            }
            c.Text = (c.Items.Count > 0 ) ? c.Items[0].ToString() : String.Empty;
        }

    }
}
