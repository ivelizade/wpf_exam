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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
            
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
             Login.students.Add(new Student { Name = textBlockFirstname.Text, Surname = textBlockLastName.Text,
                 Username=textBlockUsername.Text,
                 Password = textBlockPassword.Text, Email = textBoxEmail.Text, Adress = textBoxAddress.Text, Photo = "contact.png" });
            Close();
        }
    }
}
