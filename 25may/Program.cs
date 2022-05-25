using System;

namespace İnheritanceHomeWorks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Sahib = new Student

            {
                Grade = 90,
                UserName = "sahibmemmedzade",
                Name = "Sahib",
                Surname = "Məmmədzade",
                Password = "sahib123"
            };
            Student Sadiq = new Student

            {
                Grade = 10,
                UserName = "sadiqaslanov",
                Name = "Sadiq",
                Surname = "Aslanov",
                Password = "sadiq123"
            };
            Student Yusif = new Student
            {
                Grade = 100,
                UserName = "yusifabilov",
                Name = "Yusif",
                Surname = "Abilov",
                Password = "yusif123"
            };
            Student Revan = new Student
            {
                Grade = 80,
                UserName = "revanbabayev",
                Name = "Revan",
                Surname = "Babayev",
                Password = "revan123"
            };
            Student[] students = { Revan, Yusif, Sadiq, Sahib };
            Console.WriteLine("Zehmet olmasa istifadeci adi daxil edin: ");
            string username = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa sifre daxil edin: ");
            string password = Console.ReadLine();

            foreach (Student student in students)
            {
                if (username == student.UserName && password == student.Password)
                {
                    Console.WriteLine(student.Grade);
                }
                else
                {
                    Console.WriteLine("Istifadeci adi ve ya sifre yanlisdir.");
                    break;
                }
            }

        }
    }
}
