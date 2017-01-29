using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edx.ConsoleApplication3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Who do you want to add?");
            Console.WriteLine("1 - Student");
            Console.WriteLine("2 - Teacher");

            //To do: Implement degree and program

            try
            {
                if (Console.ReadLine() == "1")
                {
                    PrintStudentDetails(GetStudentInformation());
                }
                else
                {
                    PrintTeacherDetails(GetTeacherInformation());
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\nSomething went wrong, please close the application and try again later.");
            }
 
            finally
            {
                Console.WriteLine("\nPress any key to exit.");
                Console.ReadKey();
            }
        }

        static Student GetStudentInformation()
        {
            Student student = new Student();

            Console.Write("Enter the student's first name: ");
            student.FirstName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter the student's last name: ");
            student.LastName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter the student's birthday(day/month/year): ");
            student.Birthdate = Console.ReadLine();
            Console.WriteLine();

            ValidateBirthday(student.Birthdate);

            return student;
        }

        static Teacher GetTeacherInformation()
        {
            Teacher teacher = new Teacher();

            Console.WriteLine();
            Console.Write("Enter the teacher's first name: ");
            teacher.FirstName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter the teacher's last name: ");
            teacher.LastName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter the teacher's birthday(day/month/year): ");
            teacher.Birthdate = Console.ReadLine();
            Console.WriteLine();

            ValidateBirthday(teacher.Birthdate);

            return teacher;
        }

        static void PrintStudentDetails(Student student)
        {
            Console.WriteLine("{0} {1} was born on: {2}", student.FirstName, student.LastName, student.Birthdate);
        }

        static void PrintTeacherDetails(Teacher teacher)
        {
            Console.WriteLine("{0} {1} was born on: {2}", teacher.FirstName, teacher.LastName, teacher.Birthdate);
        }

        static bool ValidateBirthday(string birthday)
        {
            throw new NotImplementedException();
        }
    }
}
