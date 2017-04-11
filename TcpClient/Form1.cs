using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TcpClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TcpClient client = new TcpClient("192.168.123.1", 3128);
                MessageBox.Show("Connection Ok");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection is not established");
            }
        }
    }
}
