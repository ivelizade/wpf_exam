using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_exam
{
   
        public class Teacher
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Age { get; set; }
            public string Phone { get; set; }
            public string Adress { get; set; }
            public string Facebook { get; set; }
            public string Twitter { get; set; }
            public string LinkedIn { get; set; }
            public string ImagePath { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
        public ObservableCollection<HomeWork> HomeWorks{ get; set; }
        public ObservableCollection<Student> StudentList { get; set; }

        
    }
       
    
}
