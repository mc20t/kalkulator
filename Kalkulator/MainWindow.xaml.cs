using System;
using System.Data;
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

namespace Kalkulator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement element in Root.Children)
            {
                if (element is Button)
                {
                    ((Button)element).Click += Button_Clock;
                }
            }
        }

        private void Button_Clock(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;

            if (str == "AC")
                w.Text = "";
            else if (str == "=")
            {
                string value = new DataTable().Compute(w.Text, null).ToString();
                w.Text = value;
            }
            else
                w.Text += str;
        }
    }
}
