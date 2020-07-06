using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace student.entity
{
    /// <summary>
    /// نمرات
    /// </summary>
    public class selectCourses
    {
        public students st = new students();
        public courses cr = new courses();
        public int avg;

        public selectCourses()
        {
            // nothing
        }

        public selectCourses(students s, courses c, int av)
        {
            this.st = s;
            this.cr = c;
            this.avg = av;
        }

        public void Add(students s, courses c)
        {
            this.st = s;
            this.cr = c;
            Console.Write("Enter Avg: ");
            this.avg = Convert.ToInt32(Console.ReadLine());
        }
    }
}
