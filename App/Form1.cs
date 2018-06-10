using System;
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
        //Button for selecting file
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
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
                //Actions with Label, that displays the name of the selected file.
                label_file_name.Visible = true;
                label_file_name.Text = openFileDialog1.FileName;
            }

        } 
        //Button for sending selected file on to desired server address
        private void button_send_Click(object sender, EventArgs e)
        {
         //   Thread serverThread = new Thread(Server.StartListening);
         //   Thread clientThread = new Thread(RunClient);
         ////   serverThread.Start();
         //   clientThread.Start();
            RunClient();
        }
        private void RunClient()
        {
            Client.StartClient(FilePath, textBox_IP.Text, 8800);
        }
    }
}
