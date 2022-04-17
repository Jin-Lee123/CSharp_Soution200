using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace A176_MatchingGames
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        Button first;
        Button second;
        DispatcherTimer myTimer = new DispatcherTimer();
        int matched = 0;
        int[] rnd = new int[16];

        public MainWindow()
        {
            InitializeComponent();
            BoardSet();
            myTimer.Interval = new TimeSpan(0, 0, 0,0,750);
            myTimer.Tick += MyTimer_Tick;
        }

        private void BoardSet()
        {
            for (int i = 0  ; i < 16; i++)
            {
                Button c = new Button();
                c.Background = Brushes.White;
                c.Margin = new Thickness(10);
                c.Content = MakeImage("../../Images/check.png");
                c.Tag = TagSet();
                c.Click += C_Click;
                board.Children.Add(c);
            }
        }

        private Image MakeImage(string v)
        {
            BitmapImage bi = new BitmapImage(); 
            bi.BeginInit();
            bi.UriSource = new Uri(v, UriKind.Relative);
            bi.EndInit();
            Image myImage = new Image();
            myImage.Margin = new Thickness(10);
            myImage.Stretch = Stretch.Fill;
            myImage.Source =  bi;
            return myImage;
        }
        
        private int TagSet()
        {
            int i;
            Random r = new Random();    
            while(true)
            {
                i = r.Next(16);
                if(rnd[i] ==0)
                {
                    rnd[i] = 1;
                    break;
                }
            }
            return i%8;
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            string[] icon = { "딸기", "레몬", "모과", "배", "사과", "수박", "파인애플", "포도" };
            btn.Content = MakeImage("../../Images/" + icon[(int)btn.Tag] + ".PNG");

            //두 개의 버튼을 순서대로 눌렀을 때 처리
            if (first == null)
            {
                first = btn;
                return;
            }
            second = btn;

            if ((int)first.Tag == (int)second.Tag)
            {
                first = null;
                second = null;
                matched += 2;
                if (matched >= 16)
                {
                    MessageBoxResult res = MessageBox.Show("성공! 다시하겠습니까", "Success", MessageBoxButton.YesNo);
                    if (res == MessageBoxResult.Yes)
                        NewGame();
                    else
                        Close();
                }
                else
                {
                    myTimer.Start();
                }
            }
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            myTimer.Stop();
            first.Content = MakeImage("../../Images/check.png");
            second.Content = MakeImage("../../Images/check.png");
            first = null;
            second = null;
        }

        private void NewGame()
        {
            for (int i = 0; i < 16; i++)
                rnd[i] = 0;
            board.Children.Clear();
            BoardSet();
            matched = 0;
        }
    }
}
