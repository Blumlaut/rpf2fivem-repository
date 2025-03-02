﻿namespace rpf2fivem
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnClearQueue = new System.Windows.Forms.Button();
            this.btnAddQueue = new System.Windows.Forms.Button();
            this.queueList = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gta5mods_status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.log = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CompressCheck = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.VmenuCheck = new System.Windows.Forms.CheckBox();
            this.fivemresname_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.reslua = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.jobTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsQueue = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsBar = new System.Windows.Forms.ToolStripProgressBar();
            this.btnConvertFromFolder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnClearQueue);
            this.groupBox1.Controls.Add(this.btnAddQueue);
            this.groupBox1.Controls.Add(this.queueList);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.gta5mods_status);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RPF Selector";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(443, 22);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnClearQueue
            // 
            this.btnClearQueue.Location = new System.Drawing.Point(114, 68);
            this.btnClearQueue.Name = "btnClearQueue";
            this.btnClearQueue.Size = new System.Drawing.Size(102, 23);
            this.btnClearQueue.TabIndex = 19;
            this.btnClearQueue.Text = "Clear queue";
            this.btnClearQueue.UseVisualStyleBackColor = true;
            this.btnClearQueue.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAddQueue
            // 
            this.btnAddQueue.Enabled = false;
            this.btnAddQueue.Location = new System.Drawing.Point(9, 68);
            this.btnAddQueue.Name = "btnAddQueue";
            this.btnAddQueue.Size = new System.Drawing.Size(99, 23);
            this.btnAddQueue.TabIndex = 18;
            this.btnAddQueue.Text = "Add to queue";
            this.btnAddQueue.UseVisualStyleBackColor = true;
            this.btnAddQueue.Click += new System.EventHandler(this.btnAddQueue_Click);
            // 
            // queueList
            // 
            this.queueList.FormattingEnabled = true;
            this.queueList.ItemHeight = 16;
            this.queueList.Location = new System.Drawing.Point(9, 113);
            this.queueList.Name = "queueList";
            this.queueList.Size = new System.Drawing.Size(443, 116);
            this.queueList.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Queue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 12;
            // 
            // gta5mods_status
            // 
            this.gta5mods_status.AutoSize = true;
            this.gta5mods_status.BackColor = System.Drawing.SystemColors.Control;
            this.gta5mods_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gta5mods_status.ForeColor = System.Drawing.Color.Crimson;
            this.gta5mods_status.Location = new System.Drawing.Point(377, 20);
            this.gta5mods_status.Name = "gta5mods_status";
            this.gta5mods_status.Size = new System.Drawing.Size(75, 16);
            this.gta5mods_status.TabIndex = 10;
            this.gta5mods_status.Text = "BAD LINK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add to queue";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.log);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(476, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 456);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(6, 17);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(591, 433);
            this.log.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(196, -3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(398, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "buildname fxmanifest_support | developed by: github.com/Avenze";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.CompressCheck);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.VmenuCheck);
            this.groupBox3.Controls.Add(this.fivemresname_tb);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 179);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resource";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(9, 148);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(268, 20);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "store converted vehicles in one resource";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CompressCheck
            // 
            this.CompressCheck.AutoSize = true;
            this.CompressCheck.Checked = true;
            this.CompressCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CompressCheck.Location = new System.Drawing.Point(9, 122);
            this.CompressCheck.Name = "CompressCheck";
            this.CompressCheck.Size = new System.Drawing.Size(326, 20);
            this.CompressCheck.TabIndex = 18;
            this.CompressCheck.Text = "compress/downsize textures (might reduce quality)";
            this.CompressCheck.UseVisualStyleBackColor = true;
            this.CompressCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(9, 70);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(267, 20);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "change in-game name (COMING SOON)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(264, 37);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(188, 22);
            this.textBox6.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Custom vehicle in-game name";
            // 
            // VmenuCheck
            // 
            this.VmenuCheck.AutoSize = true;
            this.VmenuCheck.Checked = true;
            this.VmenuCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VmenuCheck.Enabled = false;
            this.VmenuCheck.Location = new System.Drawing.Point(9, 96);
            this.VmenuCheck.Name = "VmenuCheck";
            this.VmenuCheck.Size = new System.Drawing.Size(373, 20);
            this.VmenuCheck.TabIndex = 14;
            this.VmenuCheck.Text = "vMenu / server.cfg helper (check directory after converting)\r\n";
            this.VmenuCheck.UseVisualStyleBackColor = true;
            this.VmenuCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // fivemresname_tb
            // 
            this.fivemresname_tb.Location = new System.Drawing.Point(9, 37);
            this.fivemresname_tb.Name = "fivemresname_tb";
            this.fivemresname_tb.Size = new System.Drawing.Size(249, 22);
            this.fivemresname_tb.TabIndex = 13;
            this.fivemresname_tb.Text = "default";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "FiveM Resource name";
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(12, 437);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // reslua
            // 
            this.reslua.Location = new System.Drawing.Point(482, 499);
            this.reslua.Multiline = true;
            this.reslua.Name = "reslua";
            this.reslua.Size = new System.Drawing.Size(525, 274);
            this.reslua.TabIndex = 10;
            this.reslua.Text = resources.GetString("reslua.Text");
            this.reslua.Visible = false;
            this.reslua.TextChanged += new System.EventHandler(this.reslua_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus,
            this.jobTime,
            this.toolStripStatusLabel1,
            this.tsQueue,
            this.tsBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1088, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "tsStatus";
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsStatus.Size = new System.Drawing.Size(67, 17);
            this.tsStatus.Text = "Status:  Idle";
            // 
            // jobTime
            // 
            this.jobTime.Name = "jobTime";
            this.jobTime.Size = new System.Drawing.Size(109, 17);
            this.jobTime.Text = "| Last job time: 0ms";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(730, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // tsQueue
            // 
            this.tsQueue.Name = "tsQueue";
            this.tsQueue.Size = new System.Drawing.Size(65, 17);
            this.tsQueue.Text = "Queue: 0/0";
            // 
            // tsBar
            // 
            this.tsBar.Name = "tsBar";
            this.tsBar.Size = new System.Drawing.Size(100, 16);
            // 
            // btnConvertFromFolder
            // 
            this.btnConvertFromFolder.Location = new System.Drawing.Point(93, 437);
            this.btnConvertFromFolder.Name = "btnConvertFromFolder";
            this.btnConvertFromFolder.Size = new System.Drawing.Size(146, 23);
            this.btnConvertFromFolder.TabIndex = 20;
            this.btnConvertFromFolder.Text = "Convert from folder";
            this.btnConvertFromFolder.UseVisualStyleBackColor = true;
            this.btnConvertFromFolder.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1088, 488);
            this.Controls.Add(this.btnConvertFromFolder);
            this.Controls.Add(this.reslua);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "rpf2fivem convertor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label gta5mods_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox VmenuCheck;
        private System.Windows.Forms.TextBox fivemresname_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox reslua;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsQueue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox queueList;
        private System.Windows.Forms.Button btnAddQueue;
        private System.Windows.Forms.ToolStripProgressBar tsBar;
        private System.Windows.Forms.Button btnClearQueue;
        private System.Windows.Forms.ToolStripStatusLabel jobTime;
        private System.Windows.Forms.Button btnConvertFromFolder;
        private System.Windows.Forms.CheckBox CompressCheck;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
