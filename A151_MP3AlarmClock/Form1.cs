using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace A151_MP3AlarmClock
{
    public partial class Form1 : Form
    {
        private Timer myTimer = new Timer();
        private DateTime dDay;
        private DateTime tTime;
        private bool setAlarm;

        WindowsMediaPlayer myplayer = new WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();

            lblAlarm.ForeColor = Color.Gray;
            lblAlarmSet.ForeColor = Color.Gray;

            TimePicker.Format = DateTimePickerFormat.Custom;
            TimePicker.CustomFormat = "tt hh:mm";

            myTimer.Interval = 1000;
            myTimer.Tick += timer1_Tick_1;
            myTimer.Start();

            tabControl1.SelectedTab = tabPage2;
        }

        

        private void btnSet_Click_1(object sender, EventArgs e)
        {
            dDay = DateTime.Parse(datePicker.Text);
            tTime = DateTime.Parse(TimePicker.Text);

            setAlarm = true;
            lblAlarmSet.ForeColor = Color.Red;
            lblAlarm.ForeColor = Color.Blue;
            lblAlarm.Text = "Alarm : " + dDay.ToShortTimeString() + " " + tTime.ToLongDateString();
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            setAlarm = false;
            lblAlarmSet.ForeColor = Color.Gray;
            lblAlarm.ForeColor = Color.Gray;
            lblAlarm.Text = "Alarm : ";
            tabControl1.SelectedTab = tabPage2;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime cTime = DateTime.Now;
            lblDate.Text = cTime.ToShortDateString();
            lblTime.Text = cTime.ToLongTimeString();

            if (setAlarm == true)
            {
                if (dDay == DateTime.Today && cTime.Hour == tTime.Hour && cTime.Minute == tTime.Minute)
                {
                    setAlarm = false;
                    myplayer.URL = @"filepath\preview.mp3";
                    myplayer.controls.play();
                    
                }
            }
           
        }
    }
}
