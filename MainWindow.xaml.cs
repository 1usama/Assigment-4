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

namespace calculator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (add.IsChecked == true)
            {
                ADDvalue();
            }
            else if (sub.IsChecked== true)
            {
                SUBvalue();
            }
            else if (mul.IsChecked == true)
            {
                MULvalue();
            }
            else if (div.IsChecked == true)
            {
                DIVvalue();
            }
            else if (rem.IsChecked == true)
            {
                REMvalue();
            }

        }

        private void REMvalue()
        {
            int num1 ,num2, result;
            num1 = Convert.ToInt32(lft.Text);
            num2 = Convert.ToInt32(rgt.Text);
            result = num1 % num2;
            rslt.Text = result.ToString();
        }

        private void DIVvalue()
        {
            int num1, num2, result;
            num1 = Convert.ToInt32(lft.Text);
            num2 = Convert.ToInt32(rgt.Text);
            result = num1 / num2;
            rslt.Text = result.ToString();
        }

        private void MULvalue()
        {
            int num1, num2, result;
            num1 = Convert.ToInt32(lft.Text);
            num2 = Convert.ToInt16(rgt.Text);
            result = num1 * num2;
            rslt.Text = result.ToString();
        }

        private void SUBvalue()
        {
            int num1, num2, result;
            num1 = Convert.ToInt32(lft.Text);
            num2 = Convert.ToInt32(rgt.Text);
            result = num1 - num2;
            rslt.Text = result.ToString();
        }

        private void ADDvalue()
        {
            int num1, num2, result;
            num1 = Convert.ToInt32(lft.Text);
            num2 = Convert.ToInt32(rgt.Text);
            result = num1 + num2;
            rslt.Text = result.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
