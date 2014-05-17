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

namespace UDPBridge
{
    public partial class Form1 : Form
    {    
        private bool done = true;
        private int listenPort = 65002;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonUDPON_Click(object sender, EventArgs e)
        {
            done = false;
            UdpClient listener = new UdpClient(listenPort);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, listenPort);
            string received_data;
            byte[] receive_byte_array;
            try
            {
                while (!done)
                {
                    receive_byte_array = listener.Receive(ref groupEP);
                    received_data = Encoding.ASCII.GetString(receive_byte_array, 0, receive_byte_array.Length);
                    if (received_data.Length > 0)
                        textBox1.Text = "";
                    string[] r = received_data.Split(':');
                    foreach (string s in r)
                    {
                        //ProcessData(s);
                        textBox1.Text += s + Environment.NewLine;
                    }
                    Application.DoEvents();
                }
            }
            catch (Exception ex)
            {
                textBox1.AppendText(ex.ToString());
            }
            listener.Close();
        }

        private void buttonUDPOFF_Click(object sender, EventArgs e)
        {
            done = true;
        }

        private void buttonCOMON_Click(object sender, EventArgs e)
        {

        }

        private void buttonCOMOFF_Click(object sender, EventArgs e)
        {

        }
    }
}
