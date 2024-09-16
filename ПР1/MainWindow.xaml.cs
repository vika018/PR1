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

namespace ПР1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            double result = 0;
            result = (Convert.ToInt16(tb1.Text) * Convert.ToInt16(tb5.Text) * Convert.ToInt16(tb9.Text) + Convert.ToInt16(tb2.Text) * Convert.ToInt16(tb6.Text) * Convert.ToInt16(tb7.Text) +
                 Convert.ToInt16(tb3.Text) * Convert.ToInt16(tb4.Text) * Convert.ToInt16(tb8.Text)) - (Convert.ToInt16(tb3.Text) * Convert.ToInt16(tb5.Text) * Convert.ToInt16(tb7.Text) -
                 Convert.ToInt16(tb1.Text) * Convert.ToInt16(tb6.Text) * Convert.ToInt16(tb8.Text) - Convert.ToInt16(tb2.Text) * Convert.ToInt16(tb4.Text) - Convert.ToInt16(tb9.Text));
            RESULT.Text = "Ответ: " + result.ToString();
        }
    }
}
