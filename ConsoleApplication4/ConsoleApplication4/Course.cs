using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Course
    {
        private String name;
        private String teacherName;
        private int unit;
        public Course()
        {

        }
        public Course(String name, String teacherName, int unit)
        {
            this.name = name;
            this.teacherName = teacherName;
            this.unit = unit;
        }
        public int Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        

        public String TeacherName
        {
            get { return teacherName; }
            set { teacherName = value; }
        }


        public String Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
