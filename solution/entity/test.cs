using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student.entity
{
    public class test
    {
        public List<students> st = new List<students>();
        public List<courses> cr = new List<courses>();
        public List<selectCourses> sc = new List<selectCourses>();

        public test()
        {
            // Add student
            st.Add(new students()
            {
                firstname = "ali",
                lastname = "amiri",
                num = "981551"
            });

            st.Add(new students()
            {
                firstname = "zahra",
                lastname = "sani",
                num = "981552"
            });

            st.Add(new students()
            {
                firstname = "saba",
                lastname = "sadat",
                num = "981553"
            });

            st.Add(new students()
            {
                firstname = "sina",
                lastname = "asrlak",
                num = "981554"
            });

            st.Add(new students()
            {
                firstname = "baabak",
                lastname = "sobhani",
                num = "981555"
            });

            st.Add(new students()
            {
                firstname = "amir",
                lastname = "ahmadi",
                num = "981556"
            });

            st.Add(new students()
            {
                firstname = "fahime",
                lastname = "afgham",
                num = "981557"
            });

            st.Add(new students()
            {
                firstname = "shima",
                lastname = "saleh",
                num = "981558"
            });

            st.Add(new students()
            {
                firstname = "nasim",
                lastname = "ghaiem",
                num = "981559"
            });

            st.Add(new students()
            {
                firstname = "bahar",
                lastname = "ahmadi",
                num = "981560"
            });

            // Add course
            cr.Add(new courses
            {
                nameCourse = "math",
                nameTeacher = "nader ahmadi",
                num = 1,
                vahed = 3
            });

            cr.Add(new courses
            {
                nameCourse = "dynamic",
                nameTeacher = "amin ahmadi",
                num = 2,
                vahed = 3
            });

            cr.Add(new courses
            {
                nameCourse = "mabani C",
                nameTeacher = "ehsan khosravi",
                num = 3,
                vahed = 3
            });

            cr.Add(new courses
            {
                nameCourse = "mabani C++",
                nameTeacher = "amir salarpur",
                num = 4,
                vahed = 3
            });

            // Add select course
            sc.Add(new selectCourses(
                st[0],
                cr[0],
                15
                ));

            sc.Add(new selectCourses(
                st[0],
                cr[3],
                15
                ));

            sc.Add(new selectCourses(
                st[1],
                cr[3],
                18
                ));

            sc.Add(new selectCourses(
                st[2],
                cr[3],
                12
                ));

            sc.Add(new selectCourses(
                st[3],
                cr[3],
                9
                ));

            sc.Add(new selectCourses(
                st[4],
                cr[3],
                8
                ));

            sc.Add(new selectCourses(
                st[5],
                cr[3],
                19
                ));

            sc.Add(new selectCourses(
                st[0],
                cr[2],
                15
                ));

            sc.Add(new selectCourses(
                st[1],
                cr[2],
                18
                ));

            sc.Add(new selectCourses(
                st[2],
                cr[2],
                9
                ));

            sc.Add(new selectCourses(
                st[3],
                cr[2],
                7
                ));

            sc.Add(new selectCourses(
                st[4],
                cr[2],
                8
                ));

            sc.Add(new selectCourses(
                st[5],
                cr[2],
                19
                ));

            sc.Add(new selectCourses(
                st[6],
                cr[2],
                2
                ));

            sc.Add(new selectCourses(
                st[6],
                cr[3],
                10
                ));

            sc.Add(new selectCourses(
                st[7],
                cr[3],
                19
                ));

            sc.Add(new selectCourses(
                st[8],
                cr[3],
                2
                ));

            sc.Add(new selectCourses(
                st[9],
                cr[3],
                15
                ));

            sc.Add(new selectCourses(
                st[5],
                cr[3],
                17
                ));
        }

        /// 
        /// add 10 Student
        public List<students> initial_students()
        {
            return st;
        }

        //
        /// add 4  Course
        public List<courses> initial_courses()
        {
            return cr;
        }

        //
        /// add 19 Select course
        public List<selectCourses> initial_selectCourses()
        {
            return sc;
        }
    }
}
