namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_start_stop = new System.Windows.Forms.Button();
            this.rtb_result = new System.Windows.Forms.RichTextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.openLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLog = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.batteryReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_start_stop
            // 
            this.btn_start_stop.Location = new System.Drawing.Point(11, 27);
            this.btn_start_stop.Name = "btn_start_stop";
            this.btn_start_stop.Size = new System.Drawing.Size(315, 23);
            this.btn_start_stop.TabIndex = 0;
            this.btn_start_stop.Text = "Start";
            this.btn_start_stop.UseVisualStyleBackColor = true;
            this.btn_start_stop.Click += new System.EventHandler(this.btn_start_stop_Click);
            // 
            // rtb_result
            // 
            this.rtb_result.Location = new System.Drawing.Point(12, 68);
            this.rtb_result.Name = "rtb_result";
            this.rtb_result.ReadOnly = true;
            this.rtb_result.Size = new System.Drawing.Size(314, 132);
            this.rtb_result.TabIndex = 1;
            this.rtb_result.Text = "";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(237, 203);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "@Vuong Nguyen";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.batteryReport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(338, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLogs,
            this.clearLog,
            this.exitProgram});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(37, 20);
            this.menu.Text = "File";
            // 
            // openLogs
            // 
            this.openLogs.Name = "openLogs";
            this.openLogs.Size = new System.Drawing.Size(180, 22);
            this.openLogs.Text = "Open Logs";
            this.openLogs.Click += new System.EventHandler(this.openLogs_Click);
            // 
            // clearLog
            // 
            this.clearLog.Name = "clearLog";
            this.clearLog.Size = new System.Drawing.Size(180, 22);
            this.clearLog.Text = "Clear logs";
            this.clearLog.Click += new System.EventHandler(this.clearLog_Click);
            // 
            // exitProgram
            // 
            this.exitProgram.Name = "exitProgram";
            this.exitProgram.Size = new System.Drawing.Size(180, 22);
            this.exitProgram.Text = "Exit";
            this.exitProgram.Click += new System.EventHandler(this.exitProgram_Click);
            // 
            // batteryReport
            // 
            this.batteryReport.Name = "batteryReport";
            this.batteryReport.Size = new System.Drawing.Size(54, 20);
            this.batteryReport.Text = "Report";
            this.batteryReport.Click += new System.EventHandler(this.batteryReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 225);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.rtb_result);
            this.Controls.Add(this.btn_start_stop);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battery Realtime Monitor 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start_stop;
        private System.Windows.Forms.RichTextBox rtb_result;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem exitProgram;
        private System.Windows.Forms.ToolStripMenuItem batteryReport;
        private System.Windows.Forms.ToolStripMenuItem clearLog;
        private System.Windows.Forms.ToolStripMenuItem openLogs;
    }
}

