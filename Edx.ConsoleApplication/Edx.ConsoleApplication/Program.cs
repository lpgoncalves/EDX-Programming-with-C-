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
                AddressLine1 = "Higino Ribeiro de Carvalho st, 254", 
                AddressLine2 = "Higino Ribeiro de Carvalho st, 250",
                Birthdate = "21/03/1993",
                City = "Jacareí",
                Country = "Brazil",
                FirstName = "Luís Paulo",
                LastName = "Gonçalves",
                State_Province= "São Paulo",
                Zip_Postal = "12335-100"
            });

            students.Add(new Student()
            {
                AddressLine1 = "Higino Ribeiro de Carvalho st, 254",
                AddressLine2 = "Neymar Santos st, 250",
                Birthdate = "21/03/1993",
                City = "São José dos Campos",
                Country = "Brazil",
                FirstName = "Kerlen",
                LastName = "Nunes",
                State_Province = "São Paulo",
                Zip_Postal = "34552-630"
            });

            int count = 1;
            foreach (var student in students)
            {
                Console.WriteLine("Student {0}", count++);
                Console.WriteLine("First Name: {0}", student.FirstName);
                Console.WriteLine("Last Name: {0}", student.LastName);
                Console.WriteLine("Birthday: {0}", student.Birthdate);
                Console.WriteLine("Country: {0}", student.Country);
                Console.WriteLine("City: {0}", student.City);
                Console.WriteLine("State: {0}", student.State_Province);
                Console.WriteLine("Address Line1: {0}", student.AddressLine1);
                Console.WriteLine("ZIP: {0}", student.Zip_Postal);
                Console.WriteLine("");
            }

            Console.Write("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
