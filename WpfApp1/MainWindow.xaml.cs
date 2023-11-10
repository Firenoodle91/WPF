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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool NewButton;
        private double SaveValue;
        private string Cal;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_NumClick(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string Num = btn.Content.ToString();

            if (true)
            {
                ResultTextBox.Text = ResultTextBox.Text + Num;
            }
        }

        private void Button_CalClick(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Cal = btn.Content.ToString();

            SaveValue = double.Parse(ResultTextBox.Text);
            ResultTextBox.Text = "";
        }

        private void Button_ResultClick(object sender, RoutedEventArgs e)
        {
            Button Btn = sender as Button;

            if (Cal == null) return;

            if (Cal == "+")
                ResultTextBox.Text = (double.Parse(ResultTextBox.Text) + SaveValue).ToString();
            else if (Cal == "-")
            {
                ResultTextBox.Text = (double.Parse(ResultTextBox.Text) - SaveValue).ToString();
            }
            else if (Cal == "X")
            {
                ResultTextBox.Text = (double.Parse(ResultTextBox.Text) * SaveValue).ToString();
            }
            else if (Cal == "%")
            {
                ResultTextBox.Text = (double.Parse(ResultTextBox.Text) / SaveValue).ToString();
            }
        }

    }
}
