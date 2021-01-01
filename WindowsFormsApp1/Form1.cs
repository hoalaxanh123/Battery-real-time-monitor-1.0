using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Boolean isRunningOnBattery = false;
        static string fileName = "";
        static string currentPatch = System.IO.Path.GetDirectoryName(Application.ExecutablePath.ToString()).Replace("//","\\");
        static string logsPatch = currentPatch + "\\logs\\";
        public Form1()
        {
            InitializeComponent();
        }
        private string getCurrentTime()
        {
            DateTime getCurrentTime = DateTime.Now;
            return getCurrentTime.ToShortDateString() + " " + getCurrentTime.ToLongTimeString();
        }
        private void logToTool(string message)
        {
            string status = this.timer.Enabled ? "RUNNING" : "STOPPED";
            string str = String.Format("\n>{0} [{1}]: {2}", this.getCurrentTime(), status, message);
            rtb_result.Text += str;
            rtb_result.SelectionStart = rtb_result.TextLength;
            rtb_result.Focus();

            System.IO.Directory.CreateDirectory(logsPatch);
            string filePath = currentPatch + "\\logs\\" + fileName;
            using (StreamWriter w = File.AppendText(currentPatch+"\\logs\\" +fileName))
            {
                w.WriteLine(str);
            }
        }

        private void btn_start_stop_Click(object sender, EventArgs e)
        {
            //isRunningOnBattery = (System.Windows.Forms.SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Offline);
            //if (!isRunningOnBattery && !timer.Enabled)
            //{
            //    MessageBox.Show("Please unpluged AC adapter to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            if (timer.Enabled == false)
            {
                fileName =this.getCurrentTime().Replace('/', '_').Replace(':', '_').Replace(' ','_') + ".txt";

                this.logToTool("Started");
                this.btn_start_stop.Text = "Stop";
                timer.Start();
            }
            else
            {
                this.logToTool("Stoped");
                timer.Stop();
                this.btn_start_stop.Text = "Start";

            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            PowerStatus pw = SystemInformation.PowerStatus;
            string batteryStatus = isRunningOnBattery ? "BATTERY" : "AC";
            string batteryPercent = String.Format("{0} %", pw.BatteryLifePercent * 100);
            string str = String.Format("{0} ({1})", batteryPercent, batteryStatus);
            this.logToTool(str);
            isRunningOnBattery = (System.Windows.Forms.SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Offline);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://dark-developers.blogspot.com/");
        }

        private void exitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void runWithCmd(string command)
        {
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/c" + command+ "&&pause";
                startInfo.Verb = "runas";
                process.StartInfo = startInfo;
                process.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void batteryReport_Click(object sender, EventArgs e)
        {
            try
            {
                this.runWithCmd("powercfg /batteryreport && battery-report.html");
            }
            catch
            {
                MessageBox.Show("Cannot get battery report, are you using a laptop with battery?");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool isRunningWithAdministrator = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
            if (!isRunningWithAdministrator)
            {
                MessageBox.Show("Your System is Windows 7/8/10. \nPlease Right Click on this tool. \nThen choose Run as administrator.", "Battery Realtime Monitor 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void clearLog_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(logsPatch);
            System.IO.DirectoryInfo di = new DirectoryInfo(logsPatch);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }

            MessageBox.Show("Done","", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void openLogs_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe",logsPatch);
        }
    }
}
