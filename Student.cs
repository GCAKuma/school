using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    internal class Student
    {
        public int id { get; set; }
        public string name { get; set; }

        public Student(int aid, string aname)
        {
            id = aid;
            name = aname;
        }

        public void crazy(string aname)
        {
            Console.WriteLine("welcome  " + aname);
        }
    }

    
}
