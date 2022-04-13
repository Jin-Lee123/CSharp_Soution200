using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A165_WinFormAnalogClock
{
    public partial class Form1 : Form
    {
        Graphics g;
        private Point center;
        private double radius;
        private int hourHand;
        private int minHand;
        private int secHand;
        private Timer timer1;
        private const int clinetSize = 300;
        private const int clockSize = 200;

        public Form1()
        {
            InitializeComponent();

            this.ClientSize = new Size(clinetSize, clinetSize);
            this.Text = "Analog Clock";
            panel1.BackColor = Color.WhiteSmoke;
            this.Padding = new Padding(10);

            g = panel1.CreateGraphics();

            aClockSetting();
            TimerSetting();
        }
        private void aClockSetting()
        {
            center = new Point(panel1.Width /2, panel1.Height /2);
            radius = panel1.Height / 2;

            hourHand = (int)(radius * 0.45);
            minHand = (int)(radius * 0.45);
            secHand = (int)(radius * 0.45);
        }

        private void TimerSetting()
        {
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }
        private void Timer1_Tick(object  sender, EventArgs e)
        {
            DateTime c = DateTime.Now;

            panel1.Refresh();

            DrawClockFace();

            double radHr = (c.Hour % 12 + c.Minute / 60.0) * 30 * Math.PI / 180;
            double radMin = (c.Minute + c.Second /60.0) *6* Math.PI / 180;
            double radSec = (c.Second) * 6 * Math.PI / 180;

            DrawHands(radHr, radMin, radSec);
        }

        private void DrawClockFace()
        {
            Pen pen = new Pen(Brushes.LightSteelBlue, 30);
            g.DrawEllipse(pen, center.X - clockSize / 2, center.Y - clockSize / 2, clockSize, clockSize);
        }

        private void DrawHands(double radHr, double radMin, double radSec)
        {
            DrawLine((int)(hourHand* Math.Sin(radHr)), (int)(-hourHand*Math.Cos(radHr)), 0,0,Brushes.RoyalBlue,8,center.X,center.Y);
            DrawLine((int)(minHand * Math.Sin(radMin)), (int)(-minHand * Math.Cos(radMin)), 0, 0, Brushes.SkyBlue, 6, center.X, center.Y);
            DrawLine((int)(secHand * Math.Sin(radSec)), (int)(-secHand * Math.Cos(radSec)), 0, 0, Brushes.OrangeRed, 3, center.X, center.Y);
            int coreSize = 16;
            Rectangle r = new Rectangle(center.X - coreSize / 2, center.Y -coreSize / 2, coreSize, coreSize);
            g.FillEllipse(Brushes.Gold, r);
            Pen p = new Pen(Brushes.DarkRed, 3);
            g.DrawEllipse(p, r);
        }
        private void DrawLine(int x1, int y1, int x2, int y2, Brush color, int thick, int cx, int cy)
        {
            Pen pen = new Pen(color, thick);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            g.DrawLine(pen, x1 + cx, y1 + cy, x2 +cx, y2+ cy);
        }
    }
}
