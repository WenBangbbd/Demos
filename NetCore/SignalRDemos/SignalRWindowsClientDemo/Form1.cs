using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignalRWindowsClientDemo
{
    public partial class Form1 : Form
    {
        HubConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new HubConnectionBuilder()
                  .WithUrl("http://localhost:5000/chathub")
                  .Build();
            connection.Closed += async (error) =>
            {
                await Task.Delay(new Random().Next(0, 5) * 1000);
                await connection.StartAsync();
            };

            connection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                txtMessages.AppendText(user+":"+message);
            });

        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
               await connection.InvokeAsync("SendMessage", txtUser.Text, txtMessage.Text);
            }
            catch (Exception ex)
            {
                txtMessages.AppendText(ex.Message);
            }
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {

            try
            {
                await connection.StartAsync();
                txtMessages.AppendText("Connection started");
                btnSend.Enabled = true;
            }
            catch (Exception ex)
            {
                txtMessages.AppendText(ex.Message);
            }
        }
    }
}
