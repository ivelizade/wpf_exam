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
    /// Interaction logic for TeacherInfo.xaml
    /// </summary>
    public partial class TeacherInfo : Window
    {
        public TeacherInfo()
        {
        
            InitializeComponent();
            DataContext = this;
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri("contact.PNG", UriKind.Relative);
            bi3.EndInit();
            contact.Stretch = Stretch.Fill;
            contact.Source = bi3;
            
            name.Text = Login.loggedInTeacher.Name;
            surname.Text = Login.loggedInTeacher.Surname;
            age .Text = Login.loggedInTeacher.Age;
            adress.Text = Login.loggedInTeacher.Adress;
            phone.Text = Login.loggedInTeacher.Phone;
            facebook.Text = Login.loggedInTeacher.Facebook;
            twitter.Text = Login.loggedInTeacher.Twitter;
            linkedin.Text = Login.loggedInTeacher.LinkedIn;
            username.Text = Login.loggedInTeacher.Username;
            password.Password = Login.loggedInTeacher.Password;

        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            name.Text = Login.loggedInTeacher.Name;
            surname.Text = Login.loggedInTeacher.Surname;
            age.Text = Login.loggedInTeacher.Age;
            adress.Text = Login.loggedInTeacher.Adress;
            phone.Text = Login.loggedInTeacher.Phone;
            facebook.Text = Login.loggedInTeacher.Facebook;
            twitter.Text = Login.loggedInTeacher.Twitter;
            linkedin.Text = Login.loggedInTeacher.LinkedIn;
            username.Text = Login.loggedInTeacher.Username;
            password.Password = Login.loggedInTeacher.Password;

        }

        private void changepicture_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri(imagepath.Text, UriKind.Relative);
            bi3.EndInit();
            contact.Stretch = Stretch.Fill;
            contact.Source = bi3;
        }
    }
}
