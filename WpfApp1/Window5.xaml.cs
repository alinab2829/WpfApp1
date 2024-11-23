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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int balls = 0;
            if (vopros.IsChecked == true)
            {
                balls++;
            }
            if (vopros6.IsChecked == true)
            {
                balls++;
            }
            if (vopros9.IsChecked == true)
            {
                balls++;
            }
            if (vopros10.IsChecked == true)
            {
                balls++;
            }
            if(balls == 0)
            {
                MessageBox.Show("ну блин грустно 0");
            }
            if (balls == 1)
            {
                MessageBox.Show("ну чуть-чуть лучше 1");
            }
            if (balls == 2)
            {
                MessageBox.Show("ну хорошо 2");
            }
            if (balls == 3)
            {
                MessageBox.Show("почти почти 3");
            }
            if (balls == 4)
            {
                MessageBox.Show("Супер хорошо 4");
            }
        }
    }
}
