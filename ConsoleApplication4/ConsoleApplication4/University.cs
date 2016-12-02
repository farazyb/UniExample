using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class University
    {
        private Student[] students;


        public Student getStudentDetails()
        {
            Console.Write("Student number:");
            String studentNumber = Console.ReadLine();
            Student student = new Student(studentNumber);
             Console.Write("how many course do you want:");
            int courseCount =Convert.ToInt16( Console.ReadLine());
            student.Courses = new Course[courseCount];
            for (int i = 0; i < courseCount; i++)
            {
                student.Courses[i] = student.getCourses();
            }

            return student;
        }
        public Student[] Students
        {
            get { return students; }
            set { students = value; }
        }
        
        
    }
}
