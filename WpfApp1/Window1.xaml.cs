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
using System.Windows.Shapes;
using static System.Console;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void Result_Click(object sender, RoutedEventArgs e)
        {
            string s = Textbox1.Text;
            string first = "";
            string secound = "";
            char[] sym = s.ToCharArray();
            string sym1 = "";
            bool tjek = true;
            int temp;


            
            foreach (char word in s)
            {
                if (int.TryParse(word.ToString(), out temp) || word == ',' || word == '-')
                {

                    if (tjek)
                    {
                        first += word.ToString();
                    }
                    else
                    {
                        secound += word.ToString();
                    }
                }
                else
                {
                    sym1 = word.ToString();
                    tjek = false;
                }


            }
            switch (sym1)
            {
                case "+":
                    Textbox1.Text = (Convert.ToDouble(first) + Convert.ToDouble(secound)).ToString();

                    break;
                case "÷":
                    Textbox1.Text = ((Convert.ToDouble(first) - Convert.ToDouble(secound)).ToString());

                    break;
                case "*":
                    Textbox1.Text = ((Convert.ToDouble(first) * Convert.ToDouble(secound)).ToString());

                    break;
                case "/":
                    Textbox1.Text = ((Convert.ToDouble(first) / Convert.ToDouble(secound)).ToString());

                    break;



            }
            

            /*   string s = Textbox1.Text;
               char[] symbol = {'*'};
               bool yes = s.IndexOfAny(symbol) > 0;
               if (yes == true)
               {
                   string[] words = s.Split('*');
                   foreach(string word in words)
                   {
                       MessageBox.Show(word);
                   }
               }*/
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            komma = true;
            komma2 = true;
            Textbox1.Text += "/";
            // symbol = '/';
            //Cal();
        }

        private void Multipler_Click(object sender, RoutedEventArgs e)
        {
            //string[] asda= "bobo";
            komma = true;
            komma2 = true;
            Textbox1.Text += "*";
            //  symbol = '*';
            /*// MessageBox.Show("ghello");if (symbol == "123")
            if(symbol == "123")
            {

                total = a * b;

                MessageBox.Show(total.ToString());
            }
            else
            {

            }*/
            //Cal();

        }
        public string tal1;
        private void Minus_Click(object sender, RoutedEventArgs e)
        {


            komma = true;
            komma2 = true;
            Textbox1.Text += "÷";
            //symbol = '-';
            //Cal();
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            komma = true;
            komma2 = true;
            Textbox1.Text += "+";
            // symbol = '+';
            //Cal();
        }
        public void Cal()
        {
            /*a = int.Parse(Textbox1.Text);
            b = int.Parse(Textbox2.Text);

            if (symbol == '*')
            {
                total = a * b;
                MessageBox.Show(total.ToString());
            }
            else if (symbol == '-')
            {

                total = a - b;
                MessageBox.Show(total.ToString());
            }
            else if (symbol == '+')
            {

                total = a + b;
                MessageBox.Show(total.ToString());
            }
            else if (symbol == '/')
            {

                total = a / b;
                MessageBox.Show(total.ToString());
            }*/
        }

        private void n1_Click(object sender, RoutedEventArgs e)
        {
            Textbox1.Text += "1";
        }

        private void n2_Click(object sender, RoutedEventArgs e)
        {
            Textbox1.Text += "2";
        }

        private void n3_Click(object sender, RoutedEventArgs e)
        {
            Textbox1.Text += "3";
        }

        private void n4_Click(object sender, RoutedEventArgs e)
        {
            Textbox1.Text += "4";
        }

        private void n5_Click(object sender, RoutedEventArgs e)
        {
            Textbox1.Text += "5";
        }

        private void n6_Click(object sender, RoutedEventArgs e)
        {
            Textbox1.Text += "6";
        }

        private void n7_Click(object sender, RoutedEventArgs e)
        {
            Textbox1.Text += "7";
        }

        private void n8_Click(object sender, RoutedEventArgs e)
        {
            Textbox1.Text += "8";
        }

        private void n9_Click(object sender, RoutedEventArgs e)
        {
            Textbox1.Text += "9";
        }

        private void n0_Click(object sender, RoutedEventArgs e)
        {
            Textbox1.Text += "0";
        }

        string text;
        bool komma2 = true;

        bool komma = true;
        private void nkomma_Click(object sender, RoutedEventArgs e)
        {

            text = Textbox1.Text;


            if (komma == true && komma2 == true && (text.EndsWith("1") || text.EndsWith("2") || text.EndsWith("3") || text.EndsWith("4") || text.EndsWith("5") || text.EndsWith("6") || text.EndsWith("7") || text.EndsWith("8") || text.EndsWith("9") || text.EndsWith("0")))
            {
                Textbox1.Text += ",";
                komma = false;

                komma2 = false;
            }
            else
            {
                komma = true;
            }

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Textbox1.Text = string.Empty;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close(); 
        }
    }
}
