using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _21_12_2022_WPF_Greed
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            string data = new DataTable().Compute(this.result.Text,null).ToString();
            this.result.Text = data;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.result.Text = Button.NameProperty.Name;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.result.Text = "1";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.result.Text = "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.result.Text = "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.result.Text = "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.result.Text = "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            this.result.Text = "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            this.result.Text = "7";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            this.result.Text = "8";
        }
    }
}
