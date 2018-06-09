﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        string FilePath;
        public Form1()
        {
            InitializeComponent();
        }
        private void button_file_Click(object sender, EventArgs e)
        {
         //   Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FilePath = openFileDialog1.FileName;
                    //if ((myStream = openFileDialog1.OpenFile()) != null)
                    //{
                    //    using (myStream)
                    //    {
                    //        // Insert code to read the stream here. 
                    //    }
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }

            }

        }
        private void button_send_Click(object sender, EventArgs e)
        {
          
            Thread serverThread = new Thread(Server.StartListening);
            Thread clientThread = new Thread(RunClient);
            serverThread.Start();
            clientThread.Start();
            
         //   Server.StartListening();
         //   Client.StartClient(FilePath, textBox_IP.Text, port);
        }
        private void RunClient()
        {
            int port;
            int.TryParse(textBox_Port.Text, out port);
            Client.StartClient(FilePath, textBox_IP.Text, port);
        }
    }
}
