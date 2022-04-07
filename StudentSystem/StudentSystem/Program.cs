using System;
using Models;

using System.Collections.Generic;
namespace StudentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Student> students = new Dictionary<int, Student>();

            string fullName = " ";
            int point = 0;
            int answer = 0;
            bool check = false;
            int key;

            do
            {
                check = true;

                Console.WriteLine(" 1. Add student \n 2. Show students \n 0. Exit");
                answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Enter full name of student:");
                            fullName = Console.ReadLine();
                        } while (String.IsNullOrWhiteSpace(fullName));

                        Console.WriteLine("Enter point of student:");
                        point = int.Parse(Console.ReadLine());

                        do
                        {
                            Console.WriteLine("Enter no of student");
                            key = int.Parse(Console.ReadLine());
                        } while (students.ContainsKey(key));

                        Student student = new Student
                        {
                            FullName = fullName,
                            Point = point
                        };

                        students.Add(key,student);
                        break;

                    case 2:
                        foreach (var item in students)
                        {
                            Console.WriteLine($"{ item.Key} - {item.Value.FullName} - {item.Value.Point}");
                        }
                        break;

                    case 0:
                        check = false;
                        break;
                    default:
                        Console.WriteLine("wrong input");
                        break;
                }


            } while (check);

        }
    }
}
