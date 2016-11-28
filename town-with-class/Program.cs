using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace town_with_class
{
    class Program : school
    {
        public static object Name { get; private set; }

        static void Main(string[] args)
        {

            var x = 5 % 20;
            var y = 4 % 24;
            var z = 50 % 5;
            
            var highSchool = new school { Students = 20, Teachers = 5 };
            var middleSchool = new school { Students = 10, Teachers = 2 };
            var elementary = new school { Students = 42, Teachers = 5 };

            var ratio = highSchool.TeacherStudentRatio();
            var ratio2 = middleSchool.TeacherStudentRatio();
            var ratio3 = elementary.TeacherStudentRatio();

            Console.WriteLine(ratio);
            Console.WriteLine(ratio2);
            Console.WriteLine(ratio3);
            Console.ReadLine();

          

        }
    }
}
