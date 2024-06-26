﻿namespace client
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.logs = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_send = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.playerMove = new System.Windows.Forms.ComboBox();
            this.leaderboard = new System.Windows.Forms.ListBox();
            this.button_leavegame = new System.Windows.Forms.Button();
            this.button_join = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(89, 62);
            this.textBox_ip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(116, 22);
            this.textBox_ip.TabIndex = 2;
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(89, 98);
            this.textBox_port.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(116, 22);
            this.textBox_port.TabIndex = 3;
            this.textBox_port.Text = "3131";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(89, 182);
            this.button_connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(92, 27);
            this.button_connect.TabIndex = 4;
            this.button_connect.Text = "connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // logs
            // 
            this.logs.Location = new System.Drawing.Point(361, 64);
            this.logs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(217, 320);
            this.logs.TabIndex = 5;
            this.logs.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Choose a Move";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_send
            // 
            this.button_send.Enabled = false;
            this.button_send.Location = new System.Drawing.Point(253, 331);
            this.button_send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(87, 32);
            this.button_send.TabIndex = 8;
            this.button_send.Text = "send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(89, 140);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(116, 22);
            this.textBox_name.TabIndex = 9;
            this.textBox_name.Text = "player";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name:";
            // 
            // playerMove
            // 
            this.playerMove.Enabled = false;
            this.playerMove.FormattingEnabled = true;
            this.playerMove.Items.AddRange(new object[] {
            "Rock",
            "Paper",
            "Scissors"});
            this.playerMove.Location = new System.Drawing.Point(125, 331);
            this.playerMove.Margin = new System.Windows.Forms.Padding(1);
            this.playerMove.Name = "playerMove";
            this.playerMove.Size = new System.Drawing.Size(108, 24);
            this.playerMove.TabIndex = 11;
            // 
            // leaderboard
            // 
            this.leaderboard.FormattingEnabled = true;
            this.leaderboard.ItemHeight = 16;
            this.leaderboard.Location = new System.Drawing.Point(603, 60);
            this.leaderboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leaderboard.Name = "leaderboard";
            this.leaderboard.Size = new System.Drawing.Size(337, 324);
            this.leaderboard.TabIndex = 12;
            // 
            // button_leavegame
            // 
            this.button_leavegame.Enabled = false;
            this.button_leavegame.Location = new System.Drawing.Point(38, 236);
            this.button_leavegame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_leavegame.Name = "button_leavegame";
            this.button_leavegame.Size = new System.Drawing.Size(92, 49);
            this.button_leavegame.TabIndex = 13;
            this.button_leavegame.Text = "Leave Game";
            this.button_leavegame.UseVisualStyleBackColor = true;
            this.button_leavegame.Click += new System.EventHandler(this.button_leavegame_Click);
            // 
            // button_join
            // 
            this.button_join.Enabled = false;
            this.button_join.Location = new System.Drawing.Point(152, 236);
            this.button_join.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_join.Name = "button_join";
            this.button_join.Size = new System.Drawing.Size(92, 49);
            this.button_join.TabIndex = 14;
            this.button_join.Text = "Join Game";
            this.button_join.UseVisualStyleBackColor = true;
            this.button_join.Click += new System.EventHandler(this.button_join_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 406);
            this.Controls.Add(this.button_join);
            this.Controls.Add(this.button_leavegame);
            this.Controls.Add(this.leaderboard);
            this.Controls.Add(this.playerMove);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.RichTextBox logs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox playerMove;
        private System.Windows.Forms.ListBox leaderboard;
        private System.Windows.Forms.Button button_leavegame;
        private System.Windows.Forms.Button button_join;
    }
}

