﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace simple_UDP_Client
{
    public class UdpClientSample
    {
        public static void Main()
        {
            byte[] data = new byte[1024];
            //string input;
            string  stringData;
            UdpClient server = new UdpClient("127.0.0.1", 9050);

            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            
                //string welcome = "Hello, this is client";
                string welcome = Console.ReadLine();
                data = Encoding.ASCII.GetBytes(welcome);
                server.Send(data, data.Length);

                data = server.Receive(ref sender);

                //Console.WriteLine("Message received from {0}:", sender.ToString());
                
                stringData = Encoding.ASCII.GetString(data, 0, data.Length);
                Console.WriteLine(stringData);

                // while (true)
                //{
                // input = Console.ReadLine();
                //if (input == "exit")
                //   break;

                // server.Send(Encoding.ASCII.GetBytes(input), input.Length);
                //data = server.Receive(ref sender);
                //stringData = Encoding.ASCII.GetString(data, 0, data.Length);
                //Console.WriteLine(stringData);
                //}
                // Console.WriteLine("Stopping client");
            //}
            Console.ReadKey();
            server.Close();
        }
    }

}
