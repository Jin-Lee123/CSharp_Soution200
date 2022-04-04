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

namespace A156_WPF_HelloWorld
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lable1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(lable1.Foreground != Brushes.White)
            {
                lable1.Foreground = Brushes.White;
                this.Background = Brushes.Blue;
            }
            else
            {
                lable1.Foreground = SystemColors.WindowTextBrush;
                this.Background = SystemColors.WindowBrush;
            }
        }
    }
}
