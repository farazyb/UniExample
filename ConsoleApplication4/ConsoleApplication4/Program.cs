using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            University University = new University();
            Console.WriteLine("how many Student do you want to register :");
            int studentCount=Convert.ToInt16(Console.ReadLine());
            University.Students = new Student[studentCount];
            for (int i = 0; i < studentCount; i++)
            {
                University.Students[i] = University.getStudentDetails();
                Console.WriteLine(i + "- " + "student with name :" + University.Students[i].PersonProp.Name+" is registered");
                
            }
            Console.ReadKey();
        }
    }
}
