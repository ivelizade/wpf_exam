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
    /// Interaction logic for TeacherWindow.xaml
    /// </summary>
    public partial class TeacherWindow : Window
    {
        public static Teacher loggedInTeacher  { get; set; }
        public TeacherWindow()
        {
            InitializeComponent();
            loggedInTeacher = Login.loggedInTeacher;
        }
        
        private void changeTheme_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addStudent_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void teacherInfo_Click(object sender, RoutedEventArgs e)
        {
            TeacherInfo teacherInfo = new TeacherInfo();
            teacherInfo.Show();

        }

        private void students_Click(object sender, RoutedEventArgs e)
        {

        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
