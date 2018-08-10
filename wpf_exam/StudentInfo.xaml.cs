using Microsoft.Win32;
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
    /// Interaction logic for StudentInfo.xaml
    /// </summary>
    public partial class StudentInfo : Window
    {
        public StudentInfo()
        {
            InitializeComponent();
            DataContext = this;
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri(Login.loggedInStudent.Photo, UriKind.Relative);
            bi3.EndInit();
            contact.Stretch = Stretch.Fill;
            contact.Source = bi3;
            name.Text = Login.loggedInStudent.Name;
            surname.Text = Login.loggedInStudent.Surname;
            phone.Text = Login.loggedInStudent.Phone;
            email.Text = Login.loggedInStudent.Email;
            adress.Text = Login.loggedInStudent.Adress;
            groupname.Text = Login.loggedInStudent.GroupName;
            performance.Text = Login.loggedInStudent.Performance.ToString();
            attendance.Text = Login.loggedInStudent.Attendance.ToString();
            avaragemark.Text = Login.loggedInStudent.AverageMark.ToString();
            username.Text = Login.loggedInStudent.Username;
            password.Password = Login.loggedInStudent.Password;

            coin.Content = Login.loggedInStudent.Coin.ToString();
            badges.Content = Login.loggedInStudent.Badges.ToString();
            crystal.Content = Login.loggedInStudent.Crystal.ToString();
        }

        private void changepicture_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.ico)|*.png;*.jpeg;*.ico";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();
                bi3.UriSource = new Uri(openFileDialog.FileName, UriKind.Relative);
                bi3.EndInit();
                contact.Stretch = Stretch.Fill;
                contact.Source = bi3;
                Login.loggedInStudent.Photo = openFileDialog.FileName;
            }
            

           
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            name.Text = Login.loggedInStudent.Name;
            surname.Text = Login.loggedInStudent.Surname;
            phone.Text = Login.loggedInStudent.Phone;
            email.Text = Login.loggedInStudent.Email;
            adress.Text = Login.loggedInStudent.Adress;
            groupname.Text = Login.loggedInStudent.GroupName;
            performance.Text = Login.loggedInStudent.Performance.ToString();
            attendance.Text = Login.loggedInStudent.Attendance.ToString();
            avaragemark.Text = Login.loggedInStudent.AverageMark.ToString();
            username.Text = Login.loggedInStudent.Username;
            password.Password = Login.loggedInStudent.Password;
        }
    }
}
