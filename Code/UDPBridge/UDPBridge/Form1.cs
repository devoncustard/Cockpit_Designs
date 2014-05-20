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
using System.IO.Ports;
using System.Threading;

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
                        ProcessData(s);
                        textBox1.Text += s + Environment.NewLine;
                    }
                    Application.DoEvents();
                    Thread.Sleep(500);
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
            string[] ports = SerialPort.GetPortNames();
            string query = "*9999-0#";
            foreach (string port in ports)
            {
                SerialPort p = new SerialPort();
                p.BaudRate = 9600;
                p.PortName = port;
                try
                {
                    p.Open();
                    if (p.IsOpen)
                    {
                        p.Write(query);
                        string s;

                        Thread.Sleep(500);
                        s = p.ReadExisting();
                        p.Close();
                        try
                        {
                            if (s.Contains("<ident:"))
                            {
                                int i = s.IndexOf("<ident:");
                                s = s.Substring(i + 7);
                                i = s.IndexOf(">");
                                s = s.Substring(0, i);
                                if (s == "BORIS")
                                {
                                    serialPort1.PortName = port;
                                    serialPort1.Open();
                                }

                            }
                        }
                        catch { }
                    }
                }
                catch (Exception ex)
                {
                    ;
                }
            }
        }

        private void buttonCOMOFF_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }

        private void ProcessData(string data)
        {
            data = data.Substring(9);
            string[] d2 = data.Split('=');
            if (d2.Length != 2)
                return;
            if (d2[1].Substring(d2[1].Length - 1) == "\n")
                d2[1] = d2[1].Substring(0, d2[1].Length - 1);
            switch (d2[0])
            {
                //Master Caution Switch
                case "404":
                    SendSerialData("404", d2[1].ToString());
                    break;
         
                default:
                    break;
            }
        }

        private void SendSerialData(string function, string value)
        {
            if (serialPort1.IsOpen)
            {
                string sendthis = "*" + function + "-" + value + "#";
                char[] c = sendthis.ToCharArray();
                serialPort1.Write(c, 0, c.Length);
            }
        }
    }
}
