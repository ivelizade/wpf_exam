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

namespace wpf_exam
{
    /// <summary>
    /// Interaction logic for studentWindow.xaml
    /// </summary>
    public partial class studentWindow : Window
    {
        public studentWindow()
        {
            InitializeComponent();
        }

        private void changeTheme_Click(object sender, RoutedEventArgs e)
        {

        }

        private void homeworks_Click(object sender, RoutedEventArgs e)
        {

        }

        private void info_Click(object sender, RoutedEventArgs e)
        {

        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
