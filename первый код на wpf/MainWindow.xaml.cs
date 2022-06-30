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
using System.Data;

namespace первый_код_на_wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textLabel.Text = "0";

            foreach (UIElement el in MainRoot.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            string str = (string)((Button)e.OriginalSource).Content;

            if (textLabel.Text == "0")
            {
                textLabel.Text = "";
            }
            if (str=="AC")
            {
                textLabel.Text = "0";
            }
            else if(str=="="){
                string value = new DataTable().Compute(textLabel.Text, null).ToString();
                textLabel.Text = value;
            }
            else if (str == "1/x")
            {
                
                double result = Convert.ToDouble(textLabel.Text);
                result = 1 / result;
                textLabel.Text = result.ToString();
            }
            else if (str == "del")
            {
                textLabel.Text = textLabel.Text.Substring(0, textLabel.Text.Length - 1);
                if (textLabel.Text == "")
                {
                    textLabel.Text = "0";
                }
            }
            else if(str=="|x|")
            {
                double dn, res;
                dn = Convert.ToDouble(textLabel.Text);
                res = Math.Abs(dn);
                textLabel.Text = res.ToString();
            }
            else if (str == "cos")
            {
                double dn, res;
                dn = Convert.ToDouble(textLabel.Text);
                res = Math.Cos(dn);
                textLabel.Text = res.ToString();
            }
            else if (str == "sin")
            {
                double dn, res;
                dn = Convert.ToDouble(textLabel.Text);
                res = Math.Sin(dn);
                textLabel.Text = res.ToString();
            }
            else if (str == "n!")
            {
                double dn, res;
                dn = Convert.ToDouble(textLabel.Text);
                res = Factorial(dn);
                textLabel.Text = res.ToString();
            }
            else if (str == "e")
            {
                double dn, res;
                dn = Convert.ToDouble(textLabel.Text);
                res = Math.Exp(dn);
                textLabel.Text = res.ToString();
            }
            else if (str == "ln")
            {
                double dn, res;
                dn = Convert.ToDouble(textLabel.Text) ;
                res = Math.Log10(dn);
                textLabel.Text = res.ToString();
            }
     
            else if (str == "x^2")
            {
                double dn, res;
                dn = Convert.ToDouble(textLabel.Text);
                res = Math.Pow(dn,2);
                textLabel.Text = res.ToString();
            }
            else
            { 
            textLabel.Text += str;
             }
            double Factorial(double n)
            {
                if (n == 1) return 1;
                return n * Factorial(n - 1);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            simplepath simplepath = new simplepath();
            simplepath.Show();
            Hide();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            simplepath simplepath = new simplepath();
            simplepath.Show();
            Hide();
        }
    }
}
