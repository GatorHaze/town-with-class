using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace town_with_class
{
    public class school : buildings
    {
        public bool inSession { get; set; } = true;
        public int Teachers { get; set; }
        public int Students { get; set; }
    
        private static int GCD(int a, int b)
        {
            while (b > 0)
            {
                var rem = a % b;
                a = b;
                b = rem;
            }
            return a;
        }
        public string TeacherStudentRatio()
        {
            var biggest = 0d;
            var smallest = 0d;
            if (Teachers >= Students)
            {
                biggest = Teachers;
                smallest = Students;
            }
            else
            {
                biggest = Students;
                smallest = Teachers;
            }

            var gcd = GCD((int)smallest, (int)biggest);
            
            var teacher = this.Teachers / gcd;
            var students = this.Students / gcd;
            var rv = $"{teacher} : {students}";
            return rv;
        }

        public bool InSession
        {
            get
            {
                return (this.inSession);
            }
        }

    }
    }

}

        