using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student.entity
{
    //
    // درس
    public class courses
    {
        public string nameCourse { get; set; }
        public string nameTeacher { get; set; }
        // شماره درس
        public int num { get; set; }
        // واحد درس
        public int vahed { get; set; }

        public courses()
        {
            num = 0;
            nameCourse = string.Empty;
            nameTeacher = string.Empty;
            vahed = 0;
        }

        public void Add()
        {
            Console.Write("ID course: ");
            this.num = Convert.ToInt32(Console.ReadLine());
            Console.Write("name course: ");
            this.nameCourse = Console.ReadLine();
            Console.Write("name teacher: ");
            this.nameTeacher = Console.ReadLine();
            Console.Write("vahed: ");
            this.vahed = Convert.ToInt32(Console.ReadLine());
        }


    }
}
