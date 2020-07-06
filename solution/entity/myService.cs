using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace student.entity
{
    public class myService
    {
        public students GetByNum(List<students> st)
        {
            Console.WriteLine("Enter ID student: ");
            string num = Console.ReadLine();

            foreach (var item in st)
            {
                if (item.num == num)
                {
                    return item;
                }
            }
            return null;
        }

        public courses GetByNum(List<courses> cr)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            foreach (var item in cr)
            {
                if (item.num == num)
                {
                    return item;
                }
            }
            return null;
        }

        public void ShowAll(List<students> st)
        {
            this.clearScrean();

            Console.WriteLine("ftname\tltname\tID");
            Console.WriteLine("---------------------------------------");
            foreach (var item in st)
            {
                Console.WriteLine("{0}\t{1}\t{2}", item.firstname, item.lastname, item.num);
            }
            Console.Write("press Enter to continue...");
            Console.ReadLine();
        }

        public void ShowAll(List<courses> cr)
        {
            this.clearScrean();

            Console.WriteLine("name\tteacher\tID\tvahed");
            Console.WriteLine("---------------------------------------");
            foreach (var item in cr)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", item.nameCourse, item.nameTeacher, item.num, item.vahed);
            }
            Console.Write("press Enter to continue...");
            Console.ReadLine();
        }

        public void ShowAll(List<selectCourses> selcr)
        {
            this.clearScrean();

            Console.WriteLine("fname\tlname\tcourse\t\tavg");
            Console.WriteLine("---------------------------------------");
            foreach (var item in selcr)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", item.st.firstname, item.st.lastname, item.cr.nameCourse, item.avg);
            }
            Console.Write("press Enter to continue...");
            Console.ReadLine();
        }

        public void showAvg(List<students> st, List<selectCourses> sc)
        {
            this.clearScrean();

            Console.WriteLine("fname\tlname\t\tavg");
            Console.WriteLine("---------------------------------------");
            foreach (var s in st)
            {
                int vahed_all = 0;
                int sum_all = 0;
                float avg = 0;
                foreach (var item in sc)
                {
                    if (s == item.st)
                    {
                        vahed_all += item.cr.vahed;
                        sum_all += (item.avg * item.cr.vahed);
                    }
                }

                try
                {
                    avg = (sum_all / vahed_all);
                }
                catch
                {
                    // zero division
                    avg = 0;
                }
                Console.WriteLine("{0}\t{1}\t{2}", s.firstname, s.lastname, avg);
            }

            Console.Write("press Enter to continue...");
            Console.ReadLine();

        }

        public void showAvgBynum(students s, List<selectCourses> sc)
        {
            this.clearScrean();

            if (s == null)
            {
                Console.WriteLine("Not found strudent\n");
                goto exit;
            }

            Console.WriteLine("fname\tlname\t\tavg");
            Console.WriteLine("---------------------------------------");

            int vahed_all = 0;
            int sum_all = 0;
            float avg = 0;

            foreach (var item in sc)
            {
                if (s.num == item.st.num)
                {
                    vahed_all += item.cr.vahed;
                    sum_all += (item.avg * item.cr.vahed);
                }
            }

            try
            {
                avg = (sum_all / vahed_all);
            }
            catch
            {
                // zero division
                avg = 0;
            }


            Console.WriteLine("{0}\t{1}\t{2}", s.firstname, s.lastname, avg);

        exit:
            Console.Write("press Enter to continue...");
            Console.ReadLine();

        }

        public void showMinMax(List<students> st, List<selectCourses> sc)
        {
            this.clearScrean();

            List<studentAvg> listStudent = new List<studentAvg>();

            Console.WriteLine("fname\tlname\t\tavg");
            Console.WriteLine("---------------------------------------");

            foreach (var s in st)
            {
                int vahed_all = 0;
                int sum_all = 0;
                float avg = 0;
                foreach (var item in sc)
                {
                    if (s == item.st)
                    {
                        vahed_all += item.cr.vahed;
                        sum_all += (item.avg * item.cr.vahed);
                    }
                }

                try
                {
                    avg = (sum_all / vahed_all);
                }
                catch
                {
                    // zero division
                    avg = 0;
                }
                listStudent.Add(new studentAvg()
                {
                    firstname = s.firstname,
                    lastname = s.lastname,
                    avg = avg
                });
            }
            // sort ascending - صعودی
            listStudent = listStudent.OrderBy(s => s.avg).ToList();
            // sort descending - نزولی
            //listStudent = listStudent.OrderByDescending(s => s.avg).ToList();

            // get min avg
            studentAvg minAvg = listStudent[listStudent.Count - 1];
            // get max avg
            studentAvg maxAvg = listStudent[0];

            Console.WriteLine("{0}\t{1}\t{2}", minAvg.firstname, minAvg.lastname, minAvg.avg);
            Console.WriteLine("{0}\t{1}\t{2}", maxAvg.firstname, maxAvg.lastname, maxAvg.avg);


            Console.Write("press Enter to continue...");
            Console.ReadLine();
        }

        public void showCountReject(List<students> st, List<selectCourses> sc)
        {
            this.clearScrean();

            Console.WriteLine("fname\tlname\tcount");
            Console.WriteLine("---------------------------------------");

            foreach (var s in st)
            {
                int countReject = 0;
                foreach (var item in sc)
                {
                    if(item.st == s)
                    {
                        if (item.avg < 10)
                            countReject++;
                    }
                }
                Console.WriteLine("{0}\t{1}\t{2}", s.firstname, s.lastname, countReject);

            }


            Console.Write("press Enter to continue...");
            Console.ReadLine();
        }

        public void showMenu()
        {
            Console.WriteLine("--------------------\n");
            Console.WriteLine("     menu\n");
            Console.WriteLine("--------------------\n");
            Console.WriteLine("1. add student\n");
            Console.WriteLine("2. add sourse\n");
            Console.WriteLine("3. add avg\n");
            Console.WriteLine("4. show avg by num\n");
            Console.WriteLine("5. min| max avg student\n");
            Console.WriteLine("6. count reject student\n");
            Console.WriteLine("7. **** Exit program\n");
            Console.WriteLine("8. show all students\n");
            Console.WriteLine("9. show all courses\n");
            Console.WriteLine("10. show all selected courses\n");
            Console.WriteLine("11. show All avg\n");

            Console.WriteLine("Enter Number: ");
        }

        public void clearScrean()
        {
            Console.Clear();
        }


        class studentAvg
        {
            public string firstname { get; set; }
            public string lastname { get; set; }
            public float avg { get; set; }
        }
    }
}
