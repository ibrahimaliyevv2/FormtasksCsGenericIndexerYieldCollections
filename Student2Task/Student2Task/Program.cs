using System;

namespace Student2Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.AddExam("Math", 51);
            student.AddExam("History", 62);
            student.AddExam("Biology", 34);
            student.AddExam("Geography", 45);
            student.AddExam("Physics", 78);
            student.AddExam("Chemistry", 92);

            student.GetExamResult("Physics");

            Console.WriteLine(student.GetExamAvg());
        }
    }
}
