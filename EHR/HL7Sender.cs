﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EHR
{
    internal class HL7Sender
    {
        internal static bool SendHL7(string server, int port, string hl7message)
        {
            try
            {
                // Add the leading and trailing characters so it is LLP complaint.
                string llphl7message = Convert.ToChar(11).ToString() + hl7message + Convert.ToChar(28).ToString() + Convert.ToChar(13).ToString();

                // Get the size of the message that we have to send.
                Byte[] bytesSent = Encoding.ASCII.GetBytes(llphl7message);
                Byte[] bytesReceived = new Byte[256];

                // Create a socket connection with the specified server and port.
                Socket s = ConnectSocket(server, port);

                // If the socket could not get a connection, then return false.
                if (s == null)
                    throw new Exception("Could not connect to Mirth");

                Console.WriteLine("---------------------------------");
                Console.WriteLine($"Sending HL7 message to {server}");

                // Send message to the server.
                s.Send(bytesSent, bytesSent.Length, 0);

                // Receive the response back
                int bytes = 0;

                s.ReceiveTimeout = 30 * 1000;
                bytes = s.Receive(bytesReceived, bytesReceived.Length, 0);
                string page = Encoding.ASCII.GetString(bytesReceived, 0, bytes);
                s.Close();

                Console.Write(page);

                // Check to see if it was successful
                if (page.Contains("MSA|AA"))
                {
                    return true;
                }
                else
                {
                    throw new Exception($"Got invalid response from Mirth:[{page}]");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private static Socket ConnectSocket(string server, int port)
        {
            Socket s = null;
            IPHostEntry hostEntry = null;

            // Get host related information.
            hostEntry = Dns.GetHostEntry(server);

            foreach (IPAddress address in hostEntry.AddressList)
            {
                IPEndPoint ipe = new IPEndPoint(address, port);
                Socket tempSocket =
                    new Socket(ipe.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                tempSocket.Connect(ipe);

                if (tempSocket.Connected)
                {
                    s = tempSocket;
                    break;
                }
                else
                {
                    continue;
                }
            }
            return s;
        }
    }
}
