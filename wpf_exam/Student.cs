using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_exam
{
   public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string Photo { get; set; }
        public string GroupName { get; set; }
        public double Performance { get; set; }
        public int Attendance { get; set; }
        public int Crystal { get; set; }
        public int Coin { get; set; }
        public int Badges { get; set; }
        public double AverageMark { get; set; }
        public ObservableCollection<HomeWork> HomeWorks { get; set; }

        public Student() { }


    }
}
