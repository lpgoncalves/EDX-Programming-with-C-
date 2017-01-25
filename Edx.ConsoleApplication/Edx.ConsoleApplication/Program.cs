using Edx.ConsoleApplication.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edx.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student() 
            { 
                AddressLine1 = "Higino Ribeiro Carvalho", 
                Birthdate = "21/03/1993" 
            });

            students.Add(new Student()
            {
                AddressLine1 = "Higino Ribeiro Carvalho",
                Birthdate = "21/03/1993"
            });

            foreach (var student in students)
            {
                Console.WriteLine("First Name: {0}", student.FirstName);
            }
        }
    }
}
