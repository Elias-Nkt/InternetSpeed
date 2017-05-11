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
using System.Net;

namespace TestSpeed
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// Может добавить сюда тест скорости инета через сервисы наподобии 2IP
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            string url = Text1.Text;
            WebClient client = new WebClient();

            //to label2 for test
            DateTime dt = DateTime.Now;
            string ms = dt.ToString("s.fff");
           
            ms = ms.Remove(2, 1);
            //label2.Content = ms;
            //label3.Content = Convert.ToInt32(ms);
            // double x = Convert.ToDouble(ms);
            //

            DateTime dt1 = DateTime.Now;
            string dt11 = dt1.ToString("s.fff");
            dt11 = ms.Remove(2, 1);
            double t1 = Convert.ToDouble(dt11) / 1000;

            label2.Content = dt11;


            byte[] data = client.DownloadData(url);


            DateTime dt2 = DateTime.Now;
            string dt22 = dt2.ToString("s.fff");
            dt22 = ms.Remove(2, 1);
            double t2 = Convert.ToDouble(dt22) / 1000;

            label3.Content = dt22;

            label1.Content = ((data.Length * 8) / (t2 - t1)) / 1024 / 1024 + " Mbit/s";
            label1.Background = new SolidColorBrush(Color.FromRgb(0, 135, 25));
        }
    }
}
