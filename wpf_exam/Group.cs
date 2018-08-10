using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_exam
{
   public class Group
    {
        public static string Name { get; set; }
        static public ObservableCollection<Teacher> teachers { get; set; }
        static public ObservableCollection<Student> students { get; set; }
    }
}
