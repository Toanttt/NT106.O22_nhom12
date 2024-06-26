﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Net.Http;
using System.Security;

namespace Server
{
    public partial class Client : Form
    { 
        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            tableLayoutPanel.Visible = false;

            emojiUtility emojiUtility = new emojiUtility();
            foreach (var emoji in emojiUtility.GetEmojis().Keys)
            {
                // Tạo một Button cho mỗi emoji
                Button button = new Button();
                button.Dock= DockStyle.Fill;
                button.Text = emoji;
                button.Click += (sender, e) =>
                {
                    // Khi một emoji được chọn, thêm emoji vào rtbMessage
                    rtbMessage.AppendText(button.Text);
                };

                // Thêm Button vào TableLayoutPanel
                tableLayoutPanel.Controls.Add(button);
            }

            showTableLayoutPanelButton.Click += (sender, e) =>
            {
                tableLayoutPanel.Visible = !tableLayoutPanel.Visible;
                if (tableLayoutPanel.Visible)
                {
                    tableLayoutPanel.BringToFront(); // Đặt TableLayoutPanel lên trên rtbMain
                }
                tableLayoutPanel.BringToFront(); // Đặt TableLayoutPanel lên trên rtbMain
            };
        }

        bool isConnected = false;
        IPEndPoint IP;
        Socket client;

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                rtbMain.Text += "Lỗi kết nối server";
                return;
            }
            if (rtbMessage.Text == "") { return; }
            Send(rtbMessage.Text.Trim());
            AddMessage("Me: " + rtbMessage.Text.Trim());
            rtbMessage.Clear();
        }

        void AddMessage(string s)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>(AddMessage), new object[] { s });
                return;
            }
            rtbMain.Text += s.Trim() + Environment.NewLine;
            rtbMessage.Clear();
            ScrollToBottom();
        }

        void Connect(int portNumber)
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), portNumber);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
                isConnected = true;
                AddMessage($"Đã kết nối thành công với port {portNumber}");
            }
            catch
            {
                AddMessage("Không thể kết nối server");
                return;
            }

            byte[] message = Encoding.Unicode.GetBytes(txtName.Text.Trim());
            client.Send(message);

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        void Send(string s)
        {
            s = emojiUtility.ConvertUnicodeToEmoji(s);
            byte[] message = Encoding.Unicode.GetBytes(s);
            client.Send(message);
        }

        private bool IsImageData(byte[] data)
        {
            try
            {
                using (var ms = new MemoryStream(data))
                {
                    System.Drawing.Image.FromStream(ms);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    int bytesReceived = client.Receive(data);

                    if (bytesReceived == 0)
                    {
                        client.Close();
                        return;
                    }

                    if (IsImageData(data))
                    {
                        using (MemoryStream ms = new MemoryStream(data, 0, bytesReceived))
                        {
                            Image image = System.Drawing.Image.FromStream(ms);
                            Invoke((MethodInvoker)delegate
                            {
                                AddImageToChatBox(null, image);
                            });
                        }
                    }
                    else
                    {
                        string message = Encoding.Unicode.GetString(data, 0, bytesReceived);
                        AddMessage(message);
                    }
                }
            }
            catch
            {
                Close();
            }
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isConnected)
            {
                client.Close();
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            bool isPortValid = int.TryParse(txtPort.Text.Trim(), out int portNumber);
            if (!isPortValid)
            {
                MessageBox.Show("Lỗi Port");
                txtPort.Focus();
                return;
            }
            if (txtName.Text != "")
            {
                Connect(portNumber);
            } else
            {
                MessageBox.Show("Vui lòng nhập tên!");
                txtName.Focus();
                return;
            }
            txtName.ReadOnly = true;
        }

        private void btnShutServer_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                client.Close();
            }
        }

        private void rtbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
            }
        }
        private void ScrollToBottom()
        {
            rtbMain.SelectionStart = rtbMain.Text.Length;
            rtbMain.ScrollToCaret();
        }

        private void btnSendImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                Image image = Image.FromFile(filePath);
                AddImageToChatBox("Me", image);
                SendImageToServer(image);
            }
        }
        private void AddImageToChatBox(string username, Image image)
        {
            rtbMain.Select(rtbMain.Text.Length, 0);
            rtbMain.SelectionColor = rtbMain.ForeColor;
            rtbMain.AppendText($"{username}: ");
            rtbMain.Select(rtbMain.Text.Length, 0);
            rtbMain.ReadOnly = false;

            //image = ResizeImage(image, 200, 200);
            Clipboard.SetImage(image);
            rtbMain.Paste();

            rtbMain.ReadOnly = true;
            rtbMain.AppendText(Environment.NewLine);
            ScrollToBottom();
        }
        private void SendImageToServer(Image image)
        {
            if (!isConnected) return;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                byte[] image_data = ms.ToArray();
                client.Send(image_data);
            }
        }
    }
}
