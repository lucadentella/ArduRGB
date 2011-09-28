using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace ArduRGB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog1.Color;
                Console.WriteLine("New color: #" + selectedColor.R + selectedColor.G + selectedColor.B);

                string serialPortName = (string)cbSerialPort.SelectedItem;
                SerialPort serialPort = new SerialPort(serialPortName, 9600);
                serialPort.WriteTimeout = 5000;
                Console.WriteLine("Connecting to " + serialPortName);
                serialPort.Open();
                Console.WriteLine("Connected");
                byte[] message = new byte[3];
                message[0] = selectedColor.R;
                message[1] = selectedColor.G;
                message[2] = selectedColor.B;
                try
                {
                    serialPort.Write(message, 0, 3);
                    Console.Write("Sent ");
                    for (int i = 0; i < 3; i++) Console.Write(message[i]) ;
                    Console.WriteLine();
                }
                catch (TimeoutException)
                {
                    Console.WriteLine("Timeout while sending...");
                }
                serialPort.Close();
                Console.WriteLine("Connection closed");

                BackColor = selectedColor;
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] comPorts = SerialPort.GetPortNames();
            if (comPorts.Length == 0)
            {
                cbSerialPort.Items.Add("(no COM detected)");                
                cbSerialPort.Enabled = false;
                btColor.Enabled = false;
            }
            else
            {
                foreach (string comPort in comPorts)
                    cbSerialPort.Items.Add(comPort);
            }
            cbSerialPort.SelectedIndex = 0;
        }
    }
}