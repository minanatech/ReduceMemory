using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace reducememory
{
    public partial class Form1 : Form
    {
        private const string AppName = "ReduceMemoryApp";

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        private class MEMORYSTATUSEX
        {
            public uint dwLength;
            public uint dwMemoryLoad;
            public ulong ullTotalPhys;
            public ulong ullAvailPhys;
            public ulong ullTotalPageFile;
            public ulong ullAvailPageFile;
            public ulong ullTotalVirtual;
            public ulong ullAvailVirtual;
            public ulong ullAvailExtendedVirtual;

            public MEMORYSTATUSEX()
            {
                this.dwLength = (uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX));
            }
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GlobalMemoryStatusEx([In, Out] MEMORYSTATUSEX lpBuffer);

        [DllImport("psapi.dll")]
        private static extern int EmptyWorkingSet(IntPtr hwProc);

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private int notificationTimer = 0;
        private DateTime lastAutoOptimize = DateTime.MinValue;
        private bool isOptimizing = false;

        public Form1()
        {
            InitializeComponent();
            notifyIcon1.Icon = SystemIcons.Application;
            chkRunOnStartup.Checked = IsStartupEnabled();
            UpdateMemoryStatus();
        }

        private bool IsStartupEnabled()
        {
            using (RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", false))
            {
                if (rk != null) return rk.GetValue(AppName) != null;
            }
            return false;
        }

        private void SetStartup(bool enable)
        {
            try
            {
                using (RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
                {
                    if (enable) rk.SetValue(AppName, Application.ExecutablePath);
                    else rk.DeleteValue(AppName, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to set startup configuration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chkRunOnStartup.CheckedChanged -= chkRunOnStartup_CheckedChanged;
                chkRunOnStartup.Checked = !enable;
                chkRunOnStartup.CheckedChanged += chkRunOnStartup_CheckedChanged;
            }
        }

        private void chkRunOnStartup_CheckedChanged(object sender, EventArgs e)
        {
            SetStartup(chkRunOnStartup.Checked);
        }

        private void UpdateMemoryStatus()
        {
            if (isOptimizing) return;

            MEMORYSTATUSEX memStatus = new MEMORYSTATUSEX();
            if (GlobalMemoryStatusEx(memStatus))
            {
                int currentLoad = (int)memStatus.dwMemoryLoad;
                double freeGb = memStatus.ullAvailPhys / (1024.0 * 1024.0 * 1024.0);
                double totalGb = memStatus.ullTotalPhys / (1024.0 * 1024.0 * 1024.0);

                lblStatus.Text = $"Current RAM Usage: {currentLoad}%";
                lblDetails.Text = $"Free: {freeGb:F1} GB  /  Total: {totalGb:F1} GB";

                int maxWidth = pnlProgressBg.Width;
                int fillWidth = (int)((currentLoad / 100.0) * maxWidth);
                pnlProgressFill.Width = fillWidth;

                if (currentLoad > 85) pnlProgressFill.BackColor = Color.FromArgb(244, 67, 54);
                else if (currentLoad > 65) pnlProgressFill.BackColor = Color.FromArgb(255, 193, 7);
                else pnlProgressFill.BackColor = Color.FromArgb(0, 200, 83);

                // Auto-Optimize Logic
                if (chkAutoOptimize.Checked && currentLoad > 80)
                {
                    if ((DateTime.Now - lastAutoOptimize).TotalMinutes >= 1)
                    {
                        PerformOptimization(isAuto: true);
                    }
                }
            }
        }

        private async void PerformOptimization(bool isAuto = false)
        {
            if (isOptimizing) return;
            isOptimizing = true;

            Process[] processes = Process.GetProcesses();
            int totalProcesses = processes.Length;
            int count = 0;

            if (!isAuto)
            {
                btnOptimize.Enabled = false;
                btnOptimize.Text = "OPTIMIZING...";
                lblProcessName.Visible = true;
                timerUpdate.Stop();
            }

            await Task.Run(() =>
            {
                foreach (Process process in processes)
                {
                    try { EmptyWorkingSet(process.Handle); } catch { }

                    if (!isAuto)
                    {
                        count++;
                        this.Invoke((MethodInvoker)delegate {
                            lblProcessName.Text = $"Cleaning: {process.ProcessName}.exe";

                            int maxWidth = pnlProgressBg.Width;
                            int fillWidth = (int)((count / (double)totalProcesses) * maxWidth);
                            pnlProgressFill.Width = fillWidth;
                            pnlProgressFill.BackColor = Color.FromArgb(0, 122, 204);
                        });

                        Thread.Sleep(8);
                    }
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
            });

            isOptimizing = false;

            if (!isAuto)
            {
                lblProcessName.Visible = false;
                timerUpdate.Start();
                UpdateMemoryStatus();
                btnOptimize.Text = "FREE UP MEMORY";
                btnOptimize.Enabled = true;
                lblNotification.Text = "✔ Memory successfully freed!";
                notificationTimer = 3;
            }
            else
            {
                lastAutoOptimize = DateTime.Now;
                lblNotification.Text = "⚡ Auto-optimized RAM (>80%)!";
                notificationTimer = 3;
            }
        }

        private void btnOptimize_Click(object sender, EventArgs e)
        {
            PerformOptimization(isAuto: false);
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            UpdateMemoryStatus();
            if (notificationTimer > 0)
            {
                notificationTimer--;
                if (notificationTimer == 0) lblNotification.Text = "";
            }
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.ShowBalloonTip(1000, "Reduce Memory", "The application is running in the background.", ToolTipIcon.Info);
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
        }

        private void linkDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("http://minanatech.com") { UseShellExecute = true });
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Red;
        }

        private void lblTopButtons_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.White;
        }

        private void lblTopButtons_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.DarkGray;
        }
    }
}