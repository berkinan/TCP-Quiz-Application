using Docker.DotNet.Models;
using Microsoft.Azure.Management.ContainerInstance.Fluent.Models;
using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace quizapp
{
    public partial class server : Form
    {
        public server()
        {
            InitializeComponent();
        }

        string ip;
        string port;
        string message;
        int port_Int;
        SimpleTcpServer main_Server;

        private void start_Button_Click(object sender, EventArgs e)
        {
            try
            {
                ip = ip_Textbox.Text;
                port = port_Textbox.Text;
                port_Int = Int16.Parse(port);
                main_Server = new SimpleTcpServer(ip, port_Int);
                main_Server.Events.ClientConnected += Events_ClientConnected;
                main_Server.Events.DataReceived += Events_DataReceived;
                main_Server.Events.ClientDisconnected += Events_ClientDisconnected;
                main_Server.Start();
                server_Richtextbox.Text += $" Started Server...";
                server_Richtextbox.Text += $"{Environment.NewLine} Welcome to the Quiz Game";
                server_Richtextbox.Text += $"{Environment.NewLine} Please enter Quiz Question Number: ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
           
        }

        private void Events_ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {

                server_Richtextbox.Text += $"{Environment.NewLine} {e.IpPort} Disconnected!!!... and Reason is : {e.Reason}";
            });
            
            
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate

            {
                byte [] data = e.Data.ToArray();
                message =  Encoding.UTF8.GetString(data);
                server_Richtextbox.Text += $"{Environment.NewLine} {e.IpPort}: {message}";
            });

        }

        private void Events_ClientConnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                server_Richtextbox.Text += $"{Environment.NewLine} {e.IpPort}  Client Connected!...";
            });
        }

        private void stop_Button_Click(object sender, EventArgs e)
        {
            main_Server.Stop();
            server_Richtextbox.Text += $"{Environment.NewLine} Server Stopped!!!...";
        }
    }
}
