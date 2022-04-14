using System.Windows;
using System;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace A167_WPF_AnalogClock
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private double hourDeg;
        private double minDeg;
        private double secDeg;

        public MainWindow()
        {
            InitializeComponent();

            DrawFace();
            MakeClockHands();

            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = new TimeSpan(0, 0, 0, 0, 10);
            dt.Tick += Dt_Tick;
            dt.Start();
        }
        private void DrawFace()
        {
            Line[] marking = new Line[60];
            int W = 300;

            for (int i = 0; i < 60; i++)
            {
                marking[i] = new Line();
                marking[i].Stroke = Brushes.LightSteelBlue;
                marking[i].X1 = W/2;
                marking[i].Y1 = 2;
                marking[i].X2 = W / 2;
                if(i%5 ==0)
                {
                    marking[i].StrokeThickness = 5;
                    marking[i].Y2 = 20;
                }
                else
                {
                    marking[i].StrokeThickness=2;
                    marking[i].Y2 = 10;
                }

                RotateTransform rt = new RotateTransform(6*i);
                rt.CenterX = 150;
                rt.CenterY = 150;
                marking[i].RenderTransform = rt;
                aClock.Children.Add(marking[i]);
            }
        }
        private void MakeClockHands()
        {
            int W = 300;
            int H = 300;

            secHand.X1 = W/2;
            secHand.Y1 = H/2;
            secHand.X2  = W/2;
            secHand.Y2 = 20;

            minHand.X1 = W / 2;
            minHand.Y1 = H / 2;
            minHand.X2 = W / 2;
            minHand.Y2 = 40;

            hourHand.X1 = W / 2;
            hourHand.Y1 = H / 2;
            hourHand.X2 = W / 2;
            hourHand.Y2 = 60;
        }

        private void Dt_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            int hour = currentTime.Hour;
            int min = currentTime.Minute;
            int sec = currentTime.Second;
            hourDeg = hour % 12 * 30 + min * 0.5;
            minDeg = min * 6;
            secDeg = sec * 6;

            aClock.Children.Remove(hourHand);
            RotateTransform hourRt = new RotateTransform(hourDeg);
            hourRt.CenterX = hourHand.X1;
            hourRt.CenterY = hourHand.Y1;
            hourHand.RenderTransform = hourRt;
            aClock.Children.Add(hourHand);

            aClock.Children.Remove(minHand);
            RotateTransform minRt = new RotateTransform(minDeg);
            minRt.CenterX = minHand.X1;
            minRt.CenterY = minHand.Y1;
            minHand.RenderTransform = minRt;
            aClock.Children.Add(minHand);

            aClock.Children.Remove(secHand);
            RotateTransform secRt = new RotateTransform(secDeg);
            secRt.CenterX = secHand.X1;
            secRt.CenterY = secHand.Y1;
            secHand.RenderTransform = secRt;
            aClock.Children.Add(secHand);

            aClock.Children.Remove(center);
            aClock.Children.Add(center);
        }
    }
}
