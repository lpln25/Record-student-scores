using student.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    class Program
    {
        /*
         سلام. موضوع پروژه
برنامه ای که اطلاعات تعدادی دانشجو را به همراه نمرات دانشجو از وردی دریافت میکند و امکانات زیر را فراهم میکند
۱. با در یافت ش. دانشجویی معدل دانشجو را نمایش میدهد
۲. اسم دانشجویانی کابیشترین و کمترین نمرات را داشته اند نماش میدهد
۳. برای هر دانسجو تعداد دروسی که مردود شده است را محاسبه کرده و نماش میدهد
تاریخ تحویل ۲۱ تیر ماه
         */

        static int Main(string[] args)
        {
            // help class
            myService service = new myService();
            test _test = new test();

            // globle variable
            List<students> _student = new List<students>();
            List<courses> _course = new List<courses>();
            List<selectCourses> _selectSourse = new List<selectCourses>();

            // constructor variable
            _student = _test.initial_students();
            _course = _test.initial_courses();
            _selectSourse = _test.initial_selectCourses();

            // loop menu
            while (true)
            {
                service.clearScrean();
                service.showMenu();

                string sel = Console.ReadLine();
                switch (sel)
                {
                    case "1":
                        {
                            students s = new students();
                            s.Add();
                            _student.Add(s);
                        }
                        break;
                    case "2":
                        {
                            courses c = new courses();
                            c.Add();
                            _course.Add(c);
                        }
                        break;
                    case "3":
                        {
                            selectCourses selectcourse = new selectCourses();
                            students student = new students();
                            courses course = new courses();

                            student = service.GetByNum(_student);
                            course = service.GetByNum(_course);
                            selectcourse.Add(student, course);

                            _selectSourse.Add(selectcourse);

                        }
                        break;
                    case "4":
                        {
                            students s = new students();
                            s = service.GetByNum(_student);
                            
                            service.showAvgBynum(s, _selectSourse);
                        }
                        break;
                    case "5":
                        {
                            service.showMinMax(_student, _selectSourse);
                        }
                        break;
                    case "6":
                        {
                            service.showCountReject(_student, _selectSourse);
                        }
                        break;
                    case "7":
                        {
                            goto exit;
                        }
                    case "8":
                        {
                            service.ShowAll(_student);
                        }
                        break;
                    case "9":
                        {
                            service.ShowAll(_course);
                        }
                        break;
                    case "10":
                        {
                            service.ShowAll(_selectSourse);
                        }
                        break;
                    case "11":
                        {
                            service.showAvg(_student, _selectSourse);
                        }
                        break;
                    default:
                        break;
                }



            }
        exit:

            return 0;

        }


    }
}
