using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FA_SYSTEM1.source
{
    public partial class Page_scan : Form
    {
        private SerialPort port = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
        public Page_scan()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //textBox1.Text = port.ReadByte().ToString();
            textBox1.Invoke(new Action(() => textBox1.Text = port.ReadByte().ToString().Trim()));
        }

        private void Page_scan_Load(object sender, EventArgs e)
        {
            port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            
            port.Open();
           //string[] ports = SerialPort.GetPortNames();
           //
           //Console.WriteLine("The following serial ports were found:");
           ////button2.Enabled = false;
           //// Display each port name to the console.
           //
           //foreach (string port in ports)
           //{
           //    Console.WriteLine(port);
           //}
           //port.PortName = ports[0];
           //port.Open();
        }
    }
}
