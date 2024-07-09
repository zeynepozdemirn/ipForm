using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipForm
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        private string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ipAddress = GetLocalIPAddress();
            txt_ip.Text = ipAddress;
            //pictureBox1.Image = ımageList1.Images[0];
            //pictureBox1.Width = 200;
            //pictureBox1.Height = 200;
            //label1.ForeColor = Color.Red;
            //timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (label1.ForeColor == Color.Pink)
            {
                label1.ForeColor = Color.Black;
            }
            else
            {
                label1.ForeColor = Color.Red;
            }
        }
    }
    }

