using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App
{
    class Server
    {
        // Incoming data from the client.  
        public static string data = null;
        [STAThreadAttribute]
        public static void StartListening()
        {
            //TcpListener Listener = null;
            //try
            //{
            //    Listener = new TcpListener(IPAddress.Any, 8800);
            //    Listener.Start();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //byte[] RecData = new byte[1024];
            //int RecBytes;

            //for (; ; )
            //{
            //    TcpClient client = null;
            //    NetworkStream netstream = null;

            //    try
            //    {
            //        string message = "Accept the Incoming File ";
            //        string caption = "Incoming Connection";
            //        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            //        DialogResult result;

            //        if (Listener.Pending())
            //        {
            //            client = Listener.AcceptTcpClient();
            //            netstream = client.GetStream();

            //            result = MessageBox.Show(message, caption, buttons);

            //            if (result == System.Windows.Forms.DialogResult.Yes)
            //            {
            //                string SaveFileName = string.Empty;
            //                SaveFileDialog DialogSave = new SaveFileDialog();
            //                DialogSave.Filter = "All files (*.*)|*.*";
            //                DialogSave.RestoreDirectory = true;
            //                DialogSave.Title = "Where do you want to save the file?";
            //                DialogSave.InitialDirectory = @"C:/";
            //                if (DialogSave.ShowDialog() == DialogResult.OK)
            //                    SaveFileName = DialogSave.FileName;
            //                if (SaveFileName != string.Empty)
            //                {
            //                    int totalrecbytes = 0;
            //                    FileStream Fs = new FileStream
            //     (SaveFileName, FileMode.OpenOrCreate, FileAccess.Write);
            //                    while ((RecBytes = netstream.Read
            //         (RecData, 0, RecData.Length)) > 0)
            //                    {
            //                        Fs.Write(RecData, 0, RecBytes);
            //                        totalrecbytes += RecBytes;
            //                    }
            //                    Fs.Close();
            //                }
            //                netstream.Close();
            //                client.Close();
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //        //netstream.Close();
            //    }
            // Data buffer for incoming data.  
            byte[] bytes = new Byte[1024];

            // Establish the local endpoint for the socket.  
            // Dns.GetHostName returns the name of the   
            // host running the application.  
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = IPAddress.Any;//ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 8800); //Подключает с любого IP, а порт надо ввести конкретный.

            // Create a TCP/IP socket.  
            Socket listener = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket to the local endpoint and   
            // listen for incoming connections.  
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                // Start listening for connections.  
                while (true)
                {
                    Console.WriteLine("Waiting for a connection...");
                    // Program is suspended while waiting for an incoming connection.  
                    Socket handler = listener.Accept();
                    data = null;
                    ///
                    ///
                    // An incoming connection needs to be processed.  
                    while (true)
                    {
                        int bytesRec = handler.Receive(bytes);

                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        if (data.IndexOf("<EOF>") > -1)
                        {
                            break;
                        }
                    }

                    // Show the data on the console.  
                    Console.WriteLine("Received : {0}", data);

                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPress ENTER to continue...");
            Console.Read();

        }
    }
}

