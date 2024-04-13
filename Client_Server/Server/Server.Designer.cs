﻿namespace Server
{
    partial class Server
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.lbServer = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.btnShut = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpEmoji = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEmoji = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmoji = new System.Windows.Forms.TextBox();
            this.btnFindEmoji = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.flpEmoji.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.Location = new System.Drawing.Point(593, 19);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(177, 34);
            this.btnSend.TabIndex = 5;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtbMessage
            // 
            this.rtbMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMessage.Location = new System.Drawing.Point(6, 19);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(535, 34);
            this.rtbMessage.TabIndex = 0;
            this.rtbMessage.Text = "";
            this.rtbMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbMessage_KeyDown);
            // 
            // rtbMain
            // 
            this.rtbMain.BackColor = System.Drawing.SystemColors.Window;
            this.rtbMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rtbMain.Location = new System.Drawing.Point(12, 27);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.ReadOnly = true;
            this.rtbMain.Size = new System.Drawing.Size(535, 354);
            this.rtbMain.TabIndex = 3;
            this.rtbMain.Text = "";
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbServer.Location = new System.Drawing.Point(553, 27);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(151, 31);
            this.lbServer.TabIndex = 6;
            this.lbServer.Text = "Server Port";
            // 
            // txtPort
            // 
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPort.Location = new System.Drawing.Point(559, 61);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 30);
            this.txtPort.TabIndex = 0;
            this.txtPort.Text = "8888";
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnOpenPort.Location = new System.Drawing.Point(559, 97);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(89, 31);
            this.btnOpenPort.TabIndex = 8;
            this.btnOpenPort.Text = "Open";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // btnShut
            // 
            this.btnShut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnShut.Location = new System.Drawing.Point(654, 97);
            this.btnShut.Name = "btnShut";
            this.btnShut.Size = new System.Drawing.Size(89, 31);
            this.btnShut.TabIndex = 8;
            this.btnShut.Text = "Shut";
            this.btnShut.UseVisualStyleBackColor = true;
            this.btnShut.Click += new System.EventHandler(this.btnShutPort_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // sendFileToolStripMenuItem
            // 
            this.sendFileToolStripMenuItem.Name = "sendFileToolStripMenuItem";
            this.sendFileToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.sendFileToolStripMenuItem.Text = "Send File";
            this.sendFileToolStripMenuItem.Click += new System.EventHandler(this.sendFileToolStripMenuItem_Click);
            // 
            // flpEmoji
            // 
            this.flpEmoji.AutoScroll = true;
            this.flpEmoji.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpEmoji.Controls.Add(this.txtEmoji);
            this.flpEmoji.Controls.Add(this.btnFindEmoji);
            this.flpEmoji.Location = new System.Drawing.Point(263, 134);
            this.flpEmoji.Name = "flpEmoji";
            this.flpEmoji.Size = new System.Drawing.Size(525, 247);
            this.flpEmoji.TabIndex = 10;
            this.flpEmoji.Visible = false;
            // 
            // btnEmoji
            // 
            this.btnEmoji.Location = new System.Drawing.Point(547, 19);
            this.btnEmoji.Name = "btnEmoji";
            this.btnEmoji.Size = new System.Drawing.Size(40, 34);
            this.btnEmoji.TabIndex = 11;
            this.btnEmoji.Text = "E";
            this.btnEmoji.UseVisualStyleBackColor = true;
            this.btnEmoji.Click += new System.EventHandler(this.btnEmoji_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbMessage);
            this.groupBox1.Controls.Add(this.btnEmoji);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Location = new System.Drawing.Point(12, 387);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 62);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message";
            // 
            // txtEmoji
            // 
            this.txtEmoji.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmoji.Location = new System.Drawing.Point(3, 3);
            this.txtEmoji.Name = "txtEmoji";
            this.txtEmoji.Size = new System.Drawing.Size(412, 20);
            this.txtEmoji.TabIndex = 2;
            // 
            // btnFindEmoji
            // 
            this.btnFindEmoji.Location = new System.Drawing.Point(421, 3);
            this.btnFindEmoji.Name = "btnFindEmoji";
            this.btnFindEmoji.Size = new System.Drawing.Size(75, 23);
            this.btnFindEmoji.TabIndex = 3;
            this.btnFindEmoji.Text = "Find";
            this.btnFindEmoji.UseVisualStyleBackColor = true;
            this.btnFindEmoji.Click += new System.EventHandler(this.btnFindEmoji_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.btnShut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flpEmoji);
            this.Controls.Add(this.btnOpenPort);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lbServer);
            this.Controls.Add(this.rtbMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flpEmoji.ResumeLayout(false);
            this.flpEmoji.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.RichTextBox rtbMain;
        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.Button btnShut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendFileToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpEmoji;
        private System.Windows.Forms.Button btnEmoji;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmoji;
        private System.Windows.Forms.Button btnFindEmoji;
    }
}

