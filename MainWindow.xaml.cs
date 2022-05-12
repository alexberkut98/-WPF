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

namespace Попытка_в_WPF
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

        int Operation(int a,int b, char op)
        {
            int l = 0;
            if (op == '+')
                l = a + b;
            else
                l = a - b;
            return l;
        }

        bool CheckNumbers(string A, string B)
        {
            bool a = true;
            //Надо убедиться что перед нами числа, а не смесь букв и цифр
            string f = A;
            string s = B;
            int r = 0;
            for (int i = 0; i < f.Length; i++)
            {
                if (f[i] == '1' || f[i] == '2' || f[i] == '3' || f[i] == '4' || f[i] == '5' || f[i] == '6' || f[i] == '7' || f[i] == '8' || f[i] == '9' || f[i] == '0')
                {
                    r = 1;
                }
                else
                { 
                    r = 0;
                    break;
                }
            }
            if (r != 0)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '1' || s[i] == '2' || s[i] == '3' || s[i] == '4' || s[i] == '5' || s[i] == '6' || s[i] == '7' || s[i] == '8' || s[i] == '9' || s[i] == '0')
                    {
                        r = 1;
                    }
                    else
                    { 
                        r = 0;
                        break;
                    }
                }
            }
            if (r == 0)
                a = false;
            return a;
        }
        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            if(First.Text!=null&&Second.Text!=null)
            {
                if (CheckNumbers(First.Text, Second.Text))
                {
                    if (!Result.Items.IsEmpty)
                    {
                        Result.Items.Clear();
                    }
                    Result.Items.Add(Convert.ToString(Operation(Convert.ToInt32(First.Text), Convert.ToInt32(Second.Text),'+')));
                }

            }
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            if (First.Text != null && Second.Text != null)
            {
                if (CheckNumbers(First.Text, Second.Text))
                {
                    if (!Result.Items.IsEmpty)
                    {
                        Result.Items.Clear();
                    }
                    Result.Items.Add(Convert.ToString(Operation(Convert.ToInt32(First.Text), Convert.ToInt32(Second.Text), '-')));
                }

            }
        }
    }
}
