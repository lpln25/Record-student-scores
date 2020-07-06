using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student.entity
{
    /// <summary>
    /// دانشجو
    /// </summary>
    public class students
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        //شماره دانشجوی
        public string num { get; set; }

        public students()
        {
            this.firstname = string.Empty;
            this.lastname = string.Empty;
            this.num = string.Empty;
        }

        public students(string fname, string lname, string n)
        {
            this.firstname = fname;
            this.lastname = lname;
            this.num = n;
        }

        public void Add()
        {
            Console.Write("\nfirstname: ");
            this.firstname = Console.ReadLine();
            Console.Write("\nlasttname: ");
            this.lastname = Console.ReadLine();
            Console.Write("\nID Student: ");
            this.num = Console.ReadLine();
        }

        public void show()
        {

        }
    }
}
