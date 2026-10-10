using System;
using System.Drawing;
using System.Windows.Forms;

namespace Remindy
{
    public partial class Form1 : Form
    {
        private int lastReminderTime = -1;
        private DateTime lastOnceADayReminderDate = DateTime.MinValue;

        public Form1()
        {
            InitializeComponent();

            dtpStartTime.Value = DateTime.Today.AddHours(9);
            dtpEndTime.Value = DateTime.Today.AddHours(16).AddMinutes(30);

            this.ShowInTaskbar = false;
            numInterval.Maximum = 12;
        }

        //Minimize button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Start button.
        private void startTimerBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            this.Hide();
        }

        //Stop button
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
            MessageBox.Show("Timer has been Stopped!", "Stopped!");
        }

        //Quit button.
        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stopTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
            MessageBox.Show("Timer has been Stopped!", "Stopped!");
        }


        //      =================================           TIMER   CONTROLLER           =================================
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan startTime = dtpStartTime.Value.TimeOfDay;
            TimeSpan endTime = dtpEndTime.Value.TimeOfDay;

            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            /*
            System.Diagnostics.Debug.WriteLine($"Current: {currentTime} | Daily Alert: {dtpOnceADayTime.Value.TimeOfDay}"); - testing item. 
            */


            //once a day bool.
            bool isOnceADayReminderTime = chkOnceADay.Checked && currentTime >= dtpOnceADayTime.Value.TimeOfDay && lastOnceADayReminderDate.Date != DateTime.Today;

            if(currentTime > endTime && !chkOnceADay.Checked)
            {
                timer1.Stop();

                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
                MessageBox.Show("Timer has finished!", "Done!");

                return;
            }

            System.Diagnostics.Debug.WriteLine($"Current: {currentTime} | Start {startTime} | End: {endTime}");

            int intervalMinutes;

            if (cmbIntervalUnit.Text == "Hours")
            {
                intervalMinutes = (int)numInterval.Value * 60;
            }
            else
            {
                intervalMinutes = (int)numInterval.Value;
            }

            int currentTotalMinutes = DateTime.Now.Hour * 60 + DateTime.Now.Minute;
            int startTotalMinutes = dtpStartTime.Value.Hour * 60 + dtpStartTime.Value.Minute;


            int minutesSinceStart = currentTotalMinutes - startTotalMinutes;

            bool isReminderTime = chkEnableInterval.Checked && minutesSinceStart >= 0 && minutesSinceStart % intervalMinutes == 0;



            bool dayIsChecked = false;

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    dayIsChecked = chkMonday.Checked;
                    break;

                case DayOfWeek.Tuesday:
                    dayIsChecked = chkTuesday.Checked;
                    break;

                case DayOfWeek.Wednesday:
                    dayIsChecked = chkWednesday.Checked;
                    break;

                case DayOfWeek.Thursday:
                    dayIsChecked = chkThursday.Checked;
                    break;

                case DayOfWeek.Friday:
                    dayIsChecked = chkFriday.Checked;
                    break;

                case DayOfWeek.Saturday:
                    dayIsChecked = chkSaturday.Checked;
                    break;

                case DayOfWeek.Sunday:
                    dayIsChecked = chkSunday.Checked;
                    break;
            }

            bool withinAllowedTimeWindow = chkOnceADay.Checked || (currentTime >= startTime && currentTime <= endTime);

            int currentReminderTime = DateTime.Now.Hour * 100 + DateTime.Now.Minute;

            if (dayIsChecked
                 && withinAllowedTimeWindow
                     && (isReminderTime || isOnceADayReminderTime)
                         && currentReminderTime != lastReminderTime)
            {
                lastReminderTime = currentReminderTime;

                if (chkOnceADay.Checked)
                {
                    lastOnceADayReminderDate = DateTime.Today;

                    timer1.Stop();

                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                    this.Activate();
                }

                MessageBox.Show(txtReminderMessage.Text, "Reminder");
            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }


        private void chkEnableInterval_CheckedChanged(object sender, EventArgs e)
        {
            grpReminderInterval.Enabled = chkEnableInterval.Checked;

            if (chkEnableInterval.Checked)
            {
                chkOnceADay.Checked = false;
            }

            if (chkEnableInterval.Checked)
            {
                grpReminderInterval.BackColor = SystemColors.ActiveCaption;
            }
            else
            {
                grpReminderInterval.BackColor = SystemColors.ScrollBar;
            }
        }

        private void chkOnceADay_CheckedChanged(object sender, EventArgs e)
        {
            grpOnceADay.Enabled = chkOnceADay.Checked;

            if (chkOnceADay.Checked)
            {
                chkEnableInterval.Checked = false;
            }

            if (chkOnceADay.Checked)
            {
                grpOnceADay.BackColor = SystemColors.ActiveCaption;
            }
            else
            {
                grpOnceADay.BackColor = SystemColors.ScrollBar;
            }
        }

        private void cmbIntervalUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbIntervalUnit.Text == "Minutes")
            {
                numInterval.Maximum = 60;
            }
            else if(cmbIntervalUnit.Text == "Hours")
            {
                numInterval.Maximum = 12;
            }
        }

    }
}
