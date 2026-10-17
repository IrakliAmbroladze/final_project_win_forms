using System;
using System.Windows.Forms;

namespace final_project_win_forms
{
    public partial class Form1 : Form
    {
        private readonly Timer timer = new Timer();
        private bool alarmEnabled;
        private TimeSpan alarmTime;
        private DateTime? lastTriggeredDate;
        public Form1()
        {
            InitializeComponent();
            clockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            alarmPicker.Format = DateTimePickerFormat.Time;
            alarmPicker.ShowUpDown = true;
            statusLabel.Text = "No alarm set.";
            setAlarmButton.Click += SetAlarm;
            timer.Interval = 1000;
            timer.Tick += UpdateClock;
            timer.Start();
            UpdateClock(this, EventArgs.Empty);
        }
        private void SetAlarm(object sender, EventArgs e)
        {
            alarmTime = alarmPicker.Value.TimeOfDay;
            alarmEnabled = true;
            lastTriggeredDate = null;
            statusLabel.Text = "Alarm set for " + alarmTime.ToString(@"hh\:mm");
        }

        private void UpdateClock(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            clockLabel.Text = now.ToString("HH:mm:ss");

            if (alarmEnabled &&
                now.Hour == alarmTime.Hours &&
                now.Minute == alarmTime.Minutes &&
                lastTriggeredDate?.Date != now.Date)
            {
                alarmEnabled = false;
                lastTriggeredDate = now.Date;

                statusLabel.Text = "Alarm triggered!";

                MessageBox.Show(
                    "Wake up! Your alarm is ringing.",
                    "Alarm",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            timer.Stop();
            timer.Dispose();

            base.OnFormClosed(e);
        }
    }
}