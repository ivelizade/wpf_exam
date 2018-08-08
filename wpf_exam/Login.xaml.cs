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

        static ObservableCollection<Teacher> teachers { get; set; }
        static public ObservableCollection<Student> students { get; set; }
        public Login()
        {
            InitializeComponent();
            loginAs.SelectedIndex = 0;


            students = new ObservableCollection<Student>();
            teachers = new ObservableCollection<Teacher>();
            students.Add(new Student
            {
                Name = "Fatime",
                Surname = "Mirzeyeva",
                Email = "mirzeyeva90@mail.ru",
                Adress = "Baki",
                Username="fatime",
                Password = "123321",
                Photo = "Photos\\girl.ico",
                Phone = "0512102132",
                GroupName = "2721_AZ",
                HomeWorks = new ObservableCollection<HomeWork> { new HomeWork { TeacherName="Elnur", Comment="Yaxsi hazirlayin",
                    Date =new DateTime(2018,07,08), DeadLine=new DateTime(2018,07,09), Subject="SQL" }}
            });
            students.Add(new Student
            {
                Name = "Fatma",
                Surname = "Fatehqizi",
                Email = "Fatehqizi90@mail.ru",
                Adress = "Baki",
                Username="fatma",
                Password = "3652632",
                Photo = "Photos\\girl.ico",
                Phone = "0554698525",
                GroupName = "2714_AZ",
                HomeWorks = new ObservableCollection<HomeWork> { new HomeWork { TeacherName="Elnur", Comment="Yaxsi hazirlayin",
                    Date =new DateTime(2018,07,08), DeadLine=new DateTime(2018,07,09), Subject="SQL" }}
            });

            teachers.Add(new Teacher
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
                ImagePath = @"Icons/contact.png",
                StudentList = new ObservableCollection<Student> { new Student { Name = "Fatime", Surname = "Mirzeyeva", Email = "mirzeyeva90@mail.ru",
                    Adress = "Baki", Password = "1232132",Username="fatime", Photo = "Photos\\girl.ico", Attendance = 80, GroupName="2721_AZ",
                    HomeWorks = new ObservableCollection<HomeWork>{ new HomeWork { Date=new DateTime(2018,08,20),
                             Comment ="Imtahan isi", DeadLine=new DateTime(2018,09,02), Subject="Yekun" , TeacherName="Elnur" } }, AverageMark=9.1, Performance=8, Badges=19, Coin=500, Crystal=995, Phone="0554225125"  },


                    new Student { Name = "Fatma", Surname = "Fatehqizi", Email = "Fatehqizi90@mail.ru",
                    Adress = "Beyleqan",Username="fatma", Password = "3652632", Photo = "Photos\\girl.ico", Attendance = 90, GroupName="2714_AZ",
                    HomeWorks = new ObservableCollection<HomeWork>{ new HomeWork { Date=new DateTime(2018,08,04),
                             Comment ="Dersleri yaxshi hazirlayin", DeadLine=new DateTime(2018,10,02), Subject="Tab Controls" , TeacherName="Elnur" } },Phone="0554698525", AverageMark=7.3, Performance=9, Badges=21, Coin=360, Crystal=604 },


                     new Student { Name = "Elovset", Surname = "Kerimov", Email = "Kerimov90@mail.ru",
                    Adress = "Sumqayit", Password = "1236589", Photo = "Photos\\boy.ico", Attendance = 95, GroupName="2714_AZ",
                    HomeWorks = new ObservableCollection<HomeWork>{ new HomeWork { Date=new DateTime(2018,08,04),
                             Comment ="Dersleri yaxshi hazirlayin", DeadLine=new DateTime(2018,10,02), Subject="Tab Controls" , TeacherName="Elnur" } },Phone="0554589635", Performance=8.8, AverageMark=8.6, Badges=12, Coin=400, Crystal=905 },


                      new Student { Name = "Ibrahim", Surname = "Agazade", Email = "Agazade90@mail.ru",
                    Adress = "Culfa",Username="ibrahim", Password = "3215963", Photo = "Photos\\boy.ico", Attendance = 82, GroupName="2716_AZ",
                    HomeWorks = new ObservableCollection<HomeWork>{ new HomeWork { Date=new DateTime(2018,08,04),
                             Comment ="Dersleri yaxshi hazirlayin", DeadLine=new DateTime(2018,10,02), Subject="Tab Controls" , TeacherName="Elnur"  } },Phone="0554625465", AverageMark=7.9, Performance=5, Badges=30, Coin=562, Crystal=499 },



                       new Student { Name = "Mamed", Surname = "Ceferov", Email = "Ceferov45@mail.ru",
                    Adress = "Berde", Username="mamed",Password = "1478547", Photo = "Photos\\boy.ico", Attendance = 70, GroupName="2716_AZ",
                    HomeWorks = new ObservableCollection<HomeWork>{ new HomeWork { Date=new DateTime(2018,08,04),
                             Comment ="Dersleri yaxshi hazirlayin", DeadLine=new DateTime(2018,10,02), Subject="Tab Controls" , TeacherName="Elnur"  } },Phone="0554625895", AverageMark=8.2, Performance=8, Badges=26, Coin=700, Crystal=800 }

                }
            });
            teachers.Add(new Teacher
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
                ImagePath = @"Icons/contact.png",
                StudentList = new ObservableCollection<Student> { new Student { Name = "asasasa", Surname = "Mirzeyeva", Email = "mirzeyeva90@mail.ru",
                    Adress = "Baki", Password = "1232132", Photo = "Photos\\girl.ico", Attendance = 80, GroupName="2721_AZ",
                    HomeWorks = new ObservableCollection<HomeWork>{ new HomeWork { Date=new DateTime(2018,08,20),
                             Comment ="Database", DeadLine=new DateTime(2018,09,02), Subject="coxun coxa elaqe" , TeacherName="Eli" } }, AverageMark=9, Performance=7, Badges=20, Coin=120, Crystal=90, Phone="0708565623"  }

                }
            });

        }
        public static Teacher loggedInTeacher{ get; set; }
        public static Student loggedInStudent { get; set; }
        private void login_Click(object sender, RoutedEventArgs e)
        {
            bool sucsess = false;
            if (loginAs.SelectedIndex==0)
            {
                foreach (var item in teachers)
                {
                    if (item.Username.Equals(usertext.Text)&&item.Password.Equals(passwordtext.Password))
                    {
                        TeacherWindow teacherWindow = new TeacherWindow();
                        teacherWindow.Show();
                        sucsess = true;
                        loggedInTeacher=item;
                    }
              
                    
                }
                if (!sucsess)
                {
                    MessageBox.Show("Wrong Username or Password");
                }
                

            }
            if (loginAs.SelectedIndex== 1)
            {
                foreach (var item in students)
                {
                    if (item.Username.Equals(usertext.Text) && item.Password.Equals(passwordtext.Password))
                    {
                        studentWindow studentWindow = new studentWindow();
                        studentWindow.Show();
                        sucsess = true;
                    }
                   
                    
                }
                if (!sucsess)
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
