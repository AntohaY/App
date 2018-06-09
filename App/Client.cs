using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Client
    {
        public static void StartClient(string File_Path, string Server_IP_Adress, int Server_Port)
        {
            // Connect to a remote device.  
            try
            {
                var ip = IPAddress.Parse(Server_IP_Adress);
                // Establish the remote endpoint for the socket.  
                IPEndPoint remoteEP = new IPEndPoint(ip, Server_Port);

                // Create a TCP/IP  socket.  
                Socket sender = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.  
                try
                {
                    sender.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}",
                        sender.RemoteEndPoint.ToString());

                    Console.WriteLine("Sending {File_Path} to the host.");
                    sender.SendFile(File_Path);

                    // Release the socket.  
                    sender.Shutdown(SocketShutdown.Both);

                    sender.Close();
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }


    }
}

