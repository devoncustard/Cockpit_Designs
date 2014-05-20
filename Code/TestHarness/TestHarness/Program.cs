using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

class MainClass
{
    private static void Main()
    {
        string IP = "127.0.0.1";
        int port = 65002;

        IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Parse(IP), port);


        UdpClient client = new UdpClient();

        int r = 0;
        while (!Console.KeyAvailable)
        {

            byte[] data = Encoding.UTF8.GetBytes("01234567*404=" + r.ToString());
            client.Send(data, data.Length, remoteEndPoint);
            Console.Write(r.ToString());
            Thread.Sleep(2000);
            r++;
            if (r == 2)
                r = 0;
        }
        client.Close();
    }


}
