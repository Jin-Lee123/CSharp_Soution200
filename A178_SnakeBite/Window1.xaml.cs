using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using System.Diagnostics;
using System;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Controls;

namespace A178_SnakeBite
{
    /// <summary>
    /// Window1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Window1 : Window
    {
        Random r = new Random();
        Ellipse[] snakes = new Ellipse[30];
        Ellipse egg = new  Ellipse();
        private int size = 12;
        private int visibleCount = 5;
        private string move ="";
        private int eaten = 0;
        DispatcherTimer timer = new DispatcherTimer();
        Stopwatch sw = new Stopwatch();
        private bool startFlag = false;

        public Window1()
        {
            InitializeComponent();
            InitSnake();
            InitEgg();

            timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void InitSnake()
        {
            for(int i = 0; i < 30; i++)
            {
                snakes[i] = new Ellipse();
                snakes[i].Width = size;
                snakes[i].Height = size;
                if (i == 0)
                    snakes[i].Fill = Brushes.Chocolate;
                else if (i % 5 == 0)
                    snakes[i].Fill = Brushes.YellowGreen;
                else
                    snakes[i].Fill = Brushes.Gold;
                snakes[i].Stroke = Brushes.Black;
                Canvas1.Children.Add(snakes[i]);
            }

            for(int i = visibleCount; i<30; i++)
            {
                snakes[i].Visibility = Visibility.Hidden;
            }

            int x = r.Next(1, 480 / size) * size;
            int y = r.Next(1, 380 / size) * size;
            CreateSnake(x, y);
        }

        private void CreateSnake(int x, int y)
        {
            for(int i=0;i<visibleCount;i++)
            {
                snakes[i].Tag = new Point(x, y+i*size);
                Canvas.SetLeft(snakes[i], x);
                Canvas.SetTop(snakes[i], y+i*size   );
            }
        }

        private void InitEgg()
        {
            egg = new Ellipse();
            egg.Tag = new Point(r.Next(1, 480 / size) * size, r.Next(1, 380 / size) * size);
            egg.Width = size;
            egg.Height = size;
            egg.Stroke = Brushes.Black;
            egg.Fill = Brushes.Red;

            Point p =(Point)egg.Tag;
            Canvas1.Children.Add(egg);
            Canvas.SetLeft(egg, p.X);
            Canvas.SetTop(egg, p.Y);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if(move !="")
            {
                startFlag = true;

                for(int i = visibleCount; i>=1 ;i--)
                {
                    Point p = (Point)snakes[i - 1].Tag;
                    snakes[i].Tag = new Point(p.X, p.Y);
                }

                Point pnt = (Point)snakes[0].Tag;
                if (move == "Right")
                    snakes[0].Tag = new Point(pnt.X + size, pnt.Y);
                else if (move == "Left")
                    snakes[0].Tag = new Point(pnt.X - size, pnt.Y);
                else if (move == "Up")
                    snakes[0].Tag = new Point(pnt.X, pnt.Y - size);
                else if (move =="Down")
                    snakes[0].Tag = new Point(pnt.X , pnt.Y + size);
                EatEgg();
            }
            if(startFlag ==true)
            {
                TimeSpan ts = sw.Elapsed;
                time.Text = String.Format("Time = {0:00}:{1:00}.{2:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds/10);
                DrawSnakes();
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(move == "")
                sw.Start();

            if (e.Key == Key.Right)
                move = "Right";
            else if (e.Key == Key.Left)
                move = "Left";
            else if (e.Key == Key.Up)
                move = "Up";
            else if (e.Key == Key.Down)
                move = "Down";
            else if (e.Key == Key.Escape)
                move = "";
        }

        private void  EatEgg()
        {
            Point pS = (Point)snakes[0].Tag;
            Point pE = (Point)egg.Tag;

            if(pS.X ==pE.X && pS.Y ==pE.Y)
            {
                egg.Visibility = Visibility.Hidden;
                visibleCount++;
                snakes[visibleCount-1].Visibility = Visibility.Visible;
                score.Text = "Eggs = " + (++eaten).ToString();

                if(visibleCount ==30)
                {
                    timer.Stop();
                    sw.Stop();
                    DrawSnakes();
                    TimeSpan ts = sw.Elapsed;
                    string tElapsed = String.Format("Time = {0:00}:{1:00}.{2:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                    MessageBox.Show("Success!! " + tElapsed + " sec");
                    this.Close();
                }
                Point p = new Point(r.Next(1, 480 / size) * size, r.Next(1, 380 / size) * size);
                egg.Tag = p;
                egg.Visibility = Visibility.Visible;
                Canvas.SetLeft(egg, p.X);
                Canvas.SetTop(egg, p.Y);
            }
        }

        private void DrawSnakes()
        {
            for (int i = 0; i<visibleCount; i++)
            {
                Point p  = (Point)snakes[i].Tag;
                Canvas.SetLeft(snakes[i], p.X);
                Canvas.SetTop(snakes[i], p.Y);
            }
        }
    }
}
