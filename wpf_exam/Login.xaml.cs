using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        static public ObservableCollection<Group> Groups { get; set; }
        static public ObservableCollection<HomeWork> homeWorks { get; set; }
        public Login()
        {
            InitializeComponent();
            loginAs.SelectedIndex = 0;
            
            homeWorks = new ObservableCollection<HomeWork>();

            homeWorks.Add(new HomeWork
            {
                TeacherName = "Elnur",
                Comment = "Yaxsi hazirlayin",
                Date = new DateTime(2018, 07, 08),
                DeadLine = new DateTime(2018, 07, 09),
                Subject = "SQL"
            });
            homeWorks.Add(
                new HomeWork
                {
                    TeacherName = "Elnur",
                    Comment = "Yaxsi hazirlayin",
                    Date = new DateTime(2018, 07, 08),
                    DeadLine = new DateTime(2018, 07, 09),
                    Subject = "SQL"
                }
                );
            homeWorks.Add
                (
                new HomeWork
                {
                    Date = new DateTime(2018, 08, 04),
                    Comment = "Dersleri yaxshi hazirlayin",
                    DeadLine = new DateTime(2018, 10, 02),
                    Subject = "Tab Controls",
                    TeacherName = "Elnur"
                }
                );
            Group.students = new ObservableCollection<Student>();
            Group.teachers = new ObservableCollection<Teacher>();
            Group.students.Add(new Student
            {
                Name = "Fatime",
                Surname = "Mirzeyeva",
                Email = "mirzeyeva90@mail.ru",
                Adress = "Baki",
                Username = "fatime",
                Password = "123321",
                Photo = "contact.png",
                Phone = "0512102132",
                GroupName = "2721_AZ",
                HomeWorks = new ObservableCollection<HomeWork> { homeWorks[0] }
            });
            Group.students.Add(new Student
            {
                Name = "Fatma",
                Surname = "Fatehqizi",
                Email = "Fatehqizi90@mail.ru",
                Adress = "Baki",
                Username = "fatma",
                Password = "3652632",
                Photo = "contact.png",
                Phone = "0554698525",
                GroupName = "2714_AZ",
                HomeWorks = new ObservableCollection<HomeWork> { homeWorks[1]
            }
            });
            Group.students.Add
                (
                 new Student
                 {
                     Name = "Fatma",
                     Surname = "Fatehqizi",
                     Email = "Fatehqizi90@mail.ru",
                     Adress = "Beyleqan",
                     Username = "fatma",
                     Password = "3652632",
                     Photo = "contact.png",
                     Attendance = 90,
                     GroupName = "2714_AZ",
                     HomeWorks = new ObservableCollection<HomeWork>{ homeWorks[1] },
                     Phone = "0554698525",
                     AverageMark = 7.3,
                     Performance = 9,
                     Badges = 21,
                     Coin = 360,
                     Crystal = 604
                 }
                );
            Group.students.Add
                (
                 new Student
                 {
                     Name = "Elovset",
                     Surname = "Kerimov",
                     Username="elovset",
                     Email = "Kerimov90@mail.ru",
                     Adress = "Sumqayit",
                     Password = "1236589",
                     Photo = "contact.png",
                     Attendance = 95,
                     GroupName = "2714_AZ",
                     HomeWorks = new ObservableCollection<HomeWork>{ homeWorks[2] },
                     Phone = "0554589635",
                     Performance = 8.8,
                     AverageMark = 8.6,
                     Badges = 12,
                     Coin = 400,
                     Crystal = 905
                 }
                );
            Group.students.Add
                (
                 new Student
                 {
                     Name = "Ibrahim",
                     Surname = "Agazade",
                     Email = "Agazade90@mail.ru",
                     Adress = "Culfa",
                     Username = "ibrahim",
                     Password = "3215963",
                     Photo = "contact.png",
                     Attendance = 82,
                     GroupName = "2716_AZ",
                     HomeWorks = new ObservableCollection<HomeWork>{homeWorks[2] },
                     Phone = "0554625465",
                     AverageMark = 7.9,
                     Performance = 5,
                     Badges = 30,
                     Coin = 562,
                     Crystal = 499
                 }
                );
            Group.students.Add
                (
                  new Student
                  {
                      Name = "Mamed",
                      Surname = "Ceferov",
                      Email = "Ceferov45@mail.ru",
                      Adress = "Berde",
                      Username = "mamed",
                      Password = "1478547",
                      Photo = "contact.png",
                      Attendance = 70,
                      GroupName = "2716_AZ",
                      HomeWorks = new ObservableCollection<HomeWork>{ homeWorks[0] },
                      Phone = "0554625895",
                      AverageMark = 8.2,
                      Performance = 8,
                      Badges = 26,
                      Coin = 700,
                      Crystal = 800
                  }
                );
           Group.teachers.Add(new Teacher
            {
                Name = "Elnur",
                Surname = "Agabeyli",
                Adress = "Merdekan",
                Age = "26",
                Facebook = "elnuragabeyli12",
                LinkedIn = "elnuragabeyli",
                Twitter = "elnuragabeyli85",
                Phone = "0554880085",
                Username = "abc",
                Password = "123",
                ImagePath = "contact.png",
                StudentList = new ObservableCollection<Student> { Group.students[1],
                Group.students[2],Group.students[3], Group.students[4],Group.students[5]
                }
            });
            Group.teachers.Add(new Teacher
            {
                Name = "Eli",
                Surname = "Mirzeyev",
                Adress = "Baki",
                Age = "25",
                Facebook = "elimirzeyev12",
                LinkedIn = "elimirzeyev",
                Twitter = "elimirzeyev20",
                Phone = "0556655085",
                Username = "eli",
                Password = "321",
                ImagePath = "contact.png",
                StudentList = new ObservableCollection<Student> { Group.students[0]
                }
            });

        }
        public static Teacher loggedInTeacher { get; set; }
        public static Student loggedInStudent { get; set; }
        public static int loggedInTeacherIndex { get; set; }
        public static int loggedInStudentIndex { get; set; }
        private void login_Click(object sender, RoutedEventArgs e)
        {
            bool success = false;
            if (loginAs.SelectedIndex == 0)
            {
                loggedInTeacherIndex = 0;
                foreach (var item in Group.teachers)
                {
                    
                    if (item.Username.Equals(usertext.Text) && item.Password.Equals(passwordtext.Password))
                    {
                        loggedInTeacher = item;
                        TeacherWindow teacherWindow = new TeacherWindow();
                        teacherWindow.Show();
                        success = true;

                    }
                    else
                    {
                        loggedInTeacherIndex++;
                    }

                }
                if (!success)
                {
                    MessageBox.Show("Wrong Username or Password");
                }


            }
            if (loginAs.SelectedIndex == 1)
            {
                loggedInStudentIndex = 0;
                foreach (var item in Group.students)
                {
                    if (item.Username.Equals(usertext.Text) && item.Password.Equals(passwordtext.Password))
                    {
                        loggedInStudent = item;

                        studentWindow studentWindow = new studentWindow();
                        studentWindow.Show();
                        success = true;
                    }
                    else
                    {
                        loggedInStudentIndex++;
                    }

                }
                if (!success)
                {
                    MessageBox.Show("Wrong Email or Password");
                }


            }
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
    }
}
