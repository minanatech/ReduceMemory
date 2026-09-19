namespace reducememory
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button btnOptimize;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlProgressBg;
        private System.Windows.Forms.Panel pnlProgressFill;
        private System.Windows.Forms.LinkLabel linkDeveloper;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.CheckBox chkAutoOptimize;
        private System.Windows.Forms.CheckBox chkRunOnStartup;
        private System.Windows.Forms.Label lblProcessName;
        private System.Windows.Forms.NotifyIcon notifyIcon1;

        // Komponen Panel Panduan di Halaman Utama
        private System.Windows.Forms.Panel pnlGuide;
        private System.Windows.Forms.Label lblGuideText;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.btnOptimize = new System.Windows.Forms.Button();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlProgressBg = new System.Windows.Forms.Panel();
            this.pnlProgressFill = new System.Windows.Forms.Panel();
            this.linkDeveloper = new System.Windows.Forms.LinkLabel();
            this.lblNotification = new System.Windows.Forms.Label();
            this.chkAutoOptimize = new System.Windows.Forms.CheckBox();
            this.chkRunOnStartup = new System.Windows.Forms.CheckBox();
            this.lblProcessName = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlGuide = new System.Windows.Forms.Panel();
            this.lblGuideText = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlProgressBg.SuspendLayout();
            this.pnlGuide.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(30, 48);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(251, 30);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Current RAM Usage: 0%";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDetails.ForeColor = System.Drawing.Color.Gray;
            this.lblDetails.Location = new System.Drawing.Point(32, 75);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(160, 20);
            this.lblDetails.TabIndex = 4;
            this.lblDetails.Text = "Free: 0 GB / Total: 0 GB";
            // 
            // btnOptimize
            // 
            this.btnOptimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnOptimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptimize.FlatAppearance.BorderSize = 0;
            this.btnOptimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptimize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOptimize.ForeColor = System.Drawing.Color.White;
            this.btnOptimize.Location = new System.Drawing.Point(35, 188);
            this.btnOptimize.Name = "btnOptimize";
            this.btnOptimize.Size = new System.Drawing.Size(350, 42);
            this.btnOptimize.TabIndex = 7;
            this.btnOptimize.Text = "FREE UP MEMORY";
            this.btnOptimize.UseVisualStyleBackColor = false;
            this.btnOptimize.Click += new System.EventHandler(this.btnOptimize_Click);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 1000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlTop.Controls.Add(this.lblMinimize);
            this.pnlTop.Controls.Add(this.lblClose);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(420, 35);
            this.pnlTop.TabIndex = 10;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMinimize.ForeColor = System.Drawing.Color.DarkGray;
            this.lblMinimize.Location = new System.Drawing.Point(365, 4);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(20, 28);
            this.lblMinimize.TabIndex = 0;
            this.lblMinimize.Text = "_";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            this.lblMinimize.MouseEnter += new System.EventHandler(this.lblTopButtons_MouseEnter);
            this.lblMinimize.MouseLeave += new System.EventHandler(this.lblTopButtons_MouseLeave);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblClose.ForeColor = System.Drawing.Color.DarkGray;
            this.lblClose.Location = new System.Drawing.Point(390, 6);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(25, 28);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblTopButtons_MouseLeave);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(138, 23);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Reduce Memory";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // pnlProgressBg
            // 
            this.pnlProgressBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlProgressBg.Controls.Add(this.pnlProgressFill);
            this.pnlProgressBg.Location = new System.Drawing.Point(35, 98);
            this.pnlProgressBg.Name = "pnlProgressBg";
            this.pnlProgressBg.Size = new System.Drawing.Size(350, 12);
            this.pnlProgressBg.TabIndex = 8;
            // 
            // pnlProgressFill
            // 
            this.pnlProgressFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.pnlProgressFill.Location = new System.Drawing.Point(0, 0);
            this.pnlProgressFill.Name = "pnlProgressFill";
            this.pnlProgressFill.Size = new System.Drawing.Size(0, 12);
            this.pnlProgressFill.TabIndex = 0;
            // 
            // linkDeveloper
            // 
            this.linkDeveloper.ActiveLinkColor = System.Drawing.Color.White;
            this.linkDeveloper.AutoSize = true;
            this.linkDeveloper.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkDeveloper.LinkColor = System.Drawing.Color.Gray;
            this.linkDeveloper.Location = new System.Drawing.Point(287, 375);
            this.linkDeveloper.Name = "linkDeveloper";
            this.linkDeveloper.Size = new System.Drawing.Size(118, 20);
            this.linkDeveloper.TabIndex = 5;
            this.linkDeveloper.TabStop = true;
            this.linkDeveloper.Text = "minanatech.com";
            this.linkDeveloper.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDeveloper_LinkClicked);
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNotification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.lblNotification.Location = new System.Drawing.Point(32, 375);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(0, 20);
            this.lblNotification.TabIndex = 6;
            // 
            // chkAutoOptimize
            // 
            this.chkAutoOptimize.AutoSize = true;
            this.chkAutoOptimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkAutoOptimize.ForeColor = System.Drawing.Color.LightGray;
            this.chkAutoOptimize.Location = new System.Drawing.Point(35, 120);
            this.chkAutoOptimize.Name = "chkAutoOptimize";
            this.chkAutoOptimize.Size = new System.Drawing.Size(283, 24);
            this.chkAutoOptimize.TabIndex = 3;
            this.chkAutoOptimize.Text = "Auto Optimize when RAM load > 80%";
            // 
            // chkRunOnStartup
            // 
            this.chkRunOnStartup.AutoSize = true;
            this.chkRunOnStartup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkRunOnStartup.ForeColor = System.Drawing.Color.LightGray;
            this.chkRunOnStartup.Location = new System.Drawing.Point(35, 142);
            this.chkRunOnStartup.Name = "chkRunOnStartup";
            this.chkRunOnStartup.Size = new System.Drawing.Size(190, 24);
            this.chkRunOnStartup.TabIndex = 2;
            this.chkRunOnStartup.Text = "Run at Windows Startup";
            this.chkRunOnStartup.CheckedChanged += new System.EventHandler(this.chkRunOnStartup_CheckedChanged);
            // 
            // lblProcessName
            // 
            this.lblProcessName.AutoSize = true;
            this.lblProcessName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblProcessName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblProcessName.Location = new System.Drawing.Point(32, 168);
            this.lblProcessName.Name = "lblProcessName";
            this.lblProcessName.Size = new System.Drawing.Size(81, 19);
            this.lblProcessName.TabIndex = 1;
            this.lblProcessName.Text = "Cleaning: ...";
            this.lblProcessName.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "Reduce Memory - minanatech.com";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // pnlGuide
            // 
            this.pnlGuide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.pnlGuide.Controls.Add(this.lblGuideText);
            this.pnlGuide.Location = new System.Drawing.Point(35, 245);
            this.pnlGuide.Name = "pnlGuide";
            this.pnlGuide.Size = new System.Drawing.Size(350, 115);
            this.pnlGuide.TabIndex = 0;
            // 
            // lblGuideText
            // 
            this.lblGuideText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGuideText.ForeColor = System.Drawing.Color.DarkGray;
            this.lblGuideText.Location = new System.Drawing.Point(12, 12);
            this.lblGuideText.Name = "lblGuideText";
            this.lblGuideText.Size = new System.Drawing.Size(326, 95);
            this.lblGuideText.TabIndex = 0;
            this.lblGuideText.Text = resources.GetString("lblGuideText.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(420, 405);
            this.Controls.Add(this.pnlGuide);
            this.Controls.Add(this.lblProcessName);
            this.Controls.Add(this.chkRunOnStartup);
            this.Controls.Add(this.chkAutoOptimize);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.linkDeveloper);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.btnOptimize);
            this.Controls.Add(this.pnlProgressBg);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reduce Memory";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlProgressBg.ResumeLayout(false);
            this.pnlGuide.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}