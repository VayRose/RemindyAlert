
namespace Remindy
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.txtReminderMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSunday = new System.Windows.Forms.CheckBox();
            this.chkSaturday = new System.Windows.Forms.CheckBox();
            this.chkFriday = new System.Windows.Forms.CheckBox();
            this.chkThursday = new System.Windows.Forms.CheckBox();
            this.chkWednesday = new System.Windows.Forms.CheckBox();
            this.chkTuesday = new System.Windows.Forms.CheckBox();
            this.chkMonday = new System.Windows.Forms.CheckBox();
            this.grpReminderInterval = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbIntervalUnit = new System.Windows.Forms.ComboBox();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.chkEnableInterval = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startTimerBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.grpOnceADay = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpOnceADayTime = new System.Windows.Forms.DateTimePicker();
            this.chkOnceADay = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpReminderInterval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.grpOnceADay.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.stopTimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 70);
            // 
            // showApplicationToolStripMenuItem
            // 
            this.showApplicationToolStripMenuItem.Name = "showApplicationToolStripMenuItem";
            this.showApplicationToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.showApplicationToolStripMenuItem.Text = "Show Application";
            this.showApplicationToolStripMenuItem.Click += new System.EventHandler(this.showApplicationToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // stopTimerToolStripMenuItem
            // 
            this.stopTimerToolStripMenuItem.Name = "stopTimerToolStripMenuItem";
            this.stopTimerToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.stopTimerToolStripMenuItem.Text = "Stop Timer";
            this.stopTimerToolStripMenuItem.Click += new System.EventHandler(this.stopTimerToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(361, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Minimize App";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtReminderMessage
            // 
            this.txtReminderMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtReminderMessage.Location = new System.Drawing.Point(72, 95);
            this.txtReminderMessage.Name = "txtReminderMessage";
            this.txtReminderMessage.Size = new System.Drawing.Size(324, 26);
            this.txtReminderMessage.TabIndex = 3;
            this.txtReminderMessage.Text = "Enter Custom Alert Here";
            this.txtReminderMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(112, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Set your reminder message here.";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Remindy";
            this.notifyIcon1.Visible = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.chkSunday);
            this.groupBox1.Controls.Add(this.chkSaturday);
            this.groupBox1.Controls.Add(this.chkFriday);
            this.groupBox1.Controls.Add(this.chkThursday);
            this.groupBox1.Controls.Add(this.chkWednesday);
            this.groupBox1.Controls.Add(this.chkTuesday);
            this.groupBox1.Controls.Add(this.chkMonday);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(16, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 87);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reminder days";
            // 
            // chkSunday
            // 
            this.chkSunday.AutoSize = true;
            this.chkSunday.Location = new System.Drawing.Point(191, 56);
            this.chkSunday.Name = "chkSunday";
            this.chkSunday.Size = new System.Drawing.Size(82, 24);
            this.chkSunday.TabIndex = 6;
            this.chkSunday.Text = "Sunday";
            this.chkSunday.UseVisualStyleBackColor = true;
            // 
            // chkSaturday
            // 
            this.chkSaturday.AutoSize = true;
            this.chkSaturday.Location = new System.Drawing.Point(97, 56);
            this.chkSaturday.Name = "chkSaturday";
            this.chkSaturday.Size = new System.Drawing.Size(92, 24);
            this.chkSaturday.TabIndex = 5;
            this.chkSaturday.Text = "Saturday";
            this.chkSaturday.UseVisualStyleBackColor = true;
            // 
            // chkFriday
            // 
            this.chkFriday.AutoSize = true;
            this.chkFriday.Checked = true;
            this.chkFriday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFriday.Location = new System.Drawing.Point(7, 56);
            this.chkFriday.Name = "chkFriday";
            this.chkFriday.Size = new System.Drawing.Size(71, 24);
            this.chkFriday.TabIndex = 4;
            this.chkFriday.Text = "Friday";
            this.chkFriday.UseVisualStyleBackColor = true;
            // 
            // chkThursday
            // 
            this.chkThursday.AutoSize = true;
            this.chkThursday.Checked = true;
            this.chkThursday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkThursday.Location = new System.Drawing.Point(309, 26);
            this.chkThursday.Name = "chkThursday";
            this.chkThursday.Size = new System.Drawing.Size(93, 24);
            this.chkThursday.TabIndex = 3;
            this.chkThursday.Text = "Thursday";
            this.chkThursday.UseVisualStyleBackColor = true;
            // 
            // chkWednesday
            // 
            this.chkWednesday.AutoSize = true;
            this.chkWednesday.Checked = true;
            this.chkWednesday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWednesday.Location = new System.Drawing.Point(191, 26);
            this.chkWednesday.Name = "chkWednesday";
            this.chkWednesday.Size = new System.Drawing.Size(112, 24);
            this.chkWednesday.TabIndex = 2;
            this.chkWednesday.Text = "Wednesday";
            this.chkWednesday.UseVisualStyleBackColor = true;
            // 
            // chkTuesday
            // 
            this.chkTuesday.AutoSize = true;
            this.chkTuesday.Checked = true;
            this.chkTuesday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTuesday.Location = new System.Drawing.Point(97, 26);
            this.chkTuesday.Name = "chkTuesday";
            this.chkTuesday.Size = new System.Drawing.Size(88, 24);
            this.chkTuesday.TabIndex = 1;
            this.chkTuesday.Text = "Tuesday";
            this.chkTuesday.UseVisualStyleBackColor = true;
            // 
            // chkMonday
            // 
            this.chkMonday.AutoSize = true;
            this.chkMonday.Checked = true;
            this.chkMonday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMonday.Location = new System.Drawing.Point(7, 26);
            this.chkMonday.Name = "chkMonday";
            this.chkMonday.Size = new System.Drawing.Size(84, 24);
            this.chkMonday.TabIndex = 0;
            this.chkMonday.Text = "Monday";
            this.chkMonday.UseVisualStyleBackColor = true;
            // 
            // grpReminderInterval
            // 
            this.grpReminderInterval.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.grpReminderInterval.Controls.Add(this.label6);
            this.grpReminderInterval.Controls.Add(this.label5);
            this.grpReminderInterval.Controls.Add(this.dtpEndTime);
            this.grpReminderInterval.Controls.Add(this.label4);
            this.grpReminderInterval.Controls.Add(this.cmbIntervalUnit);
            this.grpReminderInterval.Controls.Add(this.numInterval);
            this.grpReminderInterval.Controls.Add(this.dtpStartTime);
            this.grpReminderInterval.Controls.Add(this.label3);
            this.grpReminderInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpReminderInterval.Location = new System.Drawing.Point(23, 324);
            this.grpReminderInterval.Name = "grpReminderInterval";
            this.grpReminderInterval.Size = new System.Drawing.Size(395, 171);
            this.grpReminderInterval.TabIndex = 6;
            this.grpReminderInterval.TabStop = false;
            this.grpReminderInterval.Text = "Reminder Interval";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Every:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(8, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Interval Type:";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(143, 131);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(200, 26);
            this.dtpEndTime.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(1, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "End Time.";
            // 
            // cmbIntervalUnit
            // 
            this.cmbIntervalUnit.FormattingEnabled = true;
            this.cmbIntervalUnit.Items.AddRange(new object[] {
            "Minutes",
            "Hours"});
            this.cmbIntervalUnit.Location = new System.Drawing.Point(111, 55);
            this.cmbIntervalUnit.Name = "cmbIntervalUnit";
            this.cmbIntervalUnit.Size = new System.Drawing.Size(121, 28);
            this.cmbIntervalUnit.TabIndex = 1;
            this.cmbIntervalUnit.Text = "Hours";
            this.cmbIntervalUnit.SelectedIndexChanged += new System.EventHandler(this.cmbIntervalUnit_SelectedIndexChanged);
            // 
            // numInterval
            // 
            this.numInterval.Location = new System.Drawing.Point(296, 57);
            this.numInterval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(62, 26);
            this.numInterval.TabIndex = 0;
            this.numInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(143, 99);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(200, 26);
            this.dtpStartTime.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(3, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Start Time. ";
            // 
            // chkEnableInterval
            // 
            this.chkEnableInterval.AutoSize = true;
            this.chkEnableInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.chkEnableInterval.Location = new System.Drawing.Point(129, 294);
            this.chkEnableInterval.Name = "chkEnableInterval";
            this.chkEnableInterval.Size = new System.Drawing.Size(231, 28);
            this.chkEnableInterval.TabIndex = 7;
            this.chkEnableInterval.Text = "Enable Custom Intervals";
            this.chkEnableInterval.UseVisualStyleBackColor = true;
            this.chkEnableInterval.CheckedChanged += new System.EventHandler(this.chkEnableInterval_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(127, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Days to be notified";
            // 
            // startTimerBtn
            // 
            this.startTimerBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.startTimerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startTimerBtn.Location = new System.Drawing.Point(12, 12);
            this.startTimerBtn.Name = "startTimerBtn";
            this.startTimerBtn.Size = new System.Drawing.Size(111, 35);
            this.startTimerBtn.TabIndex = 9;
            this.startTimerBtn.Text = "Start Timer!";
            this.startTimerBtn.UseVisualStyleBackColor = false;
            this.startTimerBtn.Click += new System.EventHandler(this.startTimerBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(129, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Stop Timer!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuitBtn
            // 
            this.QuitBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.QuitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.QuitBtn.Location = new System.Drawing.Point(244, 12);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(111, 35);
            this.QuitBtn.TabIndex = 11;
            this.QuitBtn.Text = "Quit";
            this.QuitBtn.UseVisualStyleBackColor = false;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // grpOnceADay
            // 
            this.grpOnceADay.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.grpOnceADay.Controls.Add(this.label7);
            this.grpOnceADay.Controls.Add(this.dtpOnceADayTime);
            this.grpOnceADay.Enabled = false;
            this.grpOnceADay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpOnceADay.Location = new System.Drawing.Point(23, 561);
            this.grpOnceADay.Name = "grpOnceADay";
            this.grpOnceADay.Size = new System.Drawing.Size(395, 125);
            this.grpOnceADay.TabIndex = 12;
            this.grpOnceADay.TabStop = false;
            this.grpOnceADay.Text = "Reminder time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Select Time for Reminder to go off";
            // 
            // dtpOnceADayTime
            // 
            this.dtpOnceADayTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpOnceADayTime.Location = new System.Drawing.Point(96, 60);
            this.dtpOnceADayTime.Name = "dtpOnceADayTime";
            this.dtpOnceADayTime.ShowUpDown = true;
            this.dtpOnceADayTime.Size = new System.Drawing.Size(200, 26);
            this.dtpOnceADayTime.TabIndex = 0;
            // 
            // chkOnceADay
            // 
            this.chkOnceADay.AutoSize = true;
            this.chkOnceADay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.chkOnceADay.Location = new System.Drawing.Point(129, 531);
            this.chkOnceADay.Name = "chkOnceADay";
            this.chkOnceADay.Size = new System.Drawing.Size(207, 28);
            this.chkOnceADay.TabIndex = 13;
            this.chkOnceADay.Text = "Once a day reminder";
            this.chkOnceADay.UseVisualStyleBackColor = true;
            this.chkOnceADay.CheckedChanged += new System.EventHandler(this.chkOnceADay_CheckedChanged);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(479, 703);
            this.Controls.Add(this.chkOnceADay);
            this.Controls.Add(this.grpOnceADay);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.startTimerBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkEnableInterval);
            this.Controls.Add(this.grpReminderInterval);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReminderMessage);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpReminderInterval.ResumeLayout(false);
            this.grpReminderInterval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.grpOnceADay.ResumeLayout(false);
            this.grpOnceADay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showApplicationToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtReminderMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSunday;
        private System.Windows.Forms.CheckBox chkSaturday;
        private System.Windows.Forms.CheckBox chkFriday;
        private System.Windows.Forms.CheckBox chkThursday;
        private System.Windows.Forms.CheckBox chkWednesday;
        private System.Windows.Forms.CheckBox chkTuesday;
        private System.Windows.Forms.CheckBox chkMonday;
        private System.Windows.Forms.GroupBox grpReminderInterval;
        private System.Windows.Forms.CheckBox chkEnableInterval;
        private System.Windows.Forms.ComboBox cmbIntervalUnit;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startTimerBtn;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem stopTimerToolStripMenuItem;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpOnceADay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpOnceADayTime;
        private System.Windows.Forms.CheckBox chkOnceADay;
    }
}

