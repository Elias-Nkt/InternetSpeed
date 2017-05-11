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
            label2.Content = ms;
           // double x = Convert.ToDouble(ms);
            //

            DateTime dt1 = DateTime.Now;
            double t1 = Convert.ToDouble(dt1.ToString("fff"));
            byte[] data = client.DownloadData(url);

            DateTime dt2 = DateTime.Now;
            double t2 = Convert.ToDouble(dt1.ToString("fff"));
            label1.Content = ((data.Length * 8) / (t2 - t1)) / 1024 / 1024 + " Mbit/s";

        }
    }
}
