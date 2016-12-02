using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Student
    {
        private Person person;
        private String studentNumber;
        private Course[] courses;

        public Student(String studentNumber)
        {
            this.person = getPersonDetails();
            this.studentNumber = studentNumber;
        }
        public Person getPersonDetails()
        {
            Person person = new Person();
            Console.Write("name of person : ");
            person.Name = Console.ReadLine();
            Console.Write("family of person : ");
            person.Family = Console.ReadLine();
            Console.Write("age of person : ");
            person.Age = Console.ReadLine();
            Console.Write("address of person : ");
            person.Address = Console.ReadLine();
            Console.Write("phone number of person : ");
            person.PhoneNumber = Console.ReadLine();
            return person;
        }
        public Course getCourses()
        {
            Course course = new Course();
            Console.Write("course name:");
            course.Name = Console.ReadLine();
            Console.Write("course teacher name:");
            course.TeacherName = Console.ReadLine();
            Console.Write("course unit:");
            course.Unit = Convert.ToInt16(Console.ReadLine());
            return course;

        }      

        public Course[] Courses
        {
            get { return courses; }
            set { courses = value; }
        }
        public String StudentNumber
        {
            get { return studentNumber; }
            set { studentNumber = value; }
        }


        public Person PersonProp
        {
            get { return person; }
            set { person = value; }
        }

    }
}
