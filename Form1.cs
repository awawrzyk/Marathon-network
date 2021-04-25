using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace marathon_network
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            IPAddress[] ipv4 = Array.FindAll(Dns.GetHostEntry(string.Empty).AddressList, a => a.AddressFamily == AddressFamily.InterNetwork);
            ip_label.Text = ipv4[1].ToString();
            

        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            Ping ping;
            PingReply reply;
            string subnet = ip_subnet_txt.Text;
            string ip_addr;
            IPAddress ip_address;
            marathon_progressbar.Minimum = 0;
            marathon_progressbar.Maximum = 254;
            for(int i=0;i<255;i++)
            {
                marathon_progressbar.Value = i;
                try
                {
                    ip_addr = subnet + "." + i.ToString();
                    ip_address = IPAddress.Parse(ip_addr);
                    ping = new Ping();
                    reply = ping.Send(ip_address, 1000);

                     ListViewItem lvi = new ListViewItem();
                     lvi.SubItems.Add(reply.Address.ToString());
                     lvi.SubItems.Add(reply.Status.ToString());
                     ip_listview.Items.Add(lvi);
                     
                     if(i==255)
                    {
                        marathon_progressbar.Value = 0;
                        marathon_progressbar.Style = ProgressBarStyle.Continuous;
                        marathon_progressbar.MarqueeAnimationSpeed = 0;
                        marathon_progressbar.Hide();
                    }
                    
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
           
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            ip_subnet_txt.Text = "";
            ip_listview.Items.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.Show();
        }
    }
}
