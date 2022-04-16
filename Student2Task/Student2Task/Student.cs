using System;
using System.Collections.Generic;
using System.Text;

namespace Student2Task
{
    class Student
    {
        public Student()
        {
            _no++;
            No = _no;
        }
        private static int _no;
        public int No { get; set; }
        public string FullName { get; set; }

        public Dictionary<string, double> Exams = new Dictionary<string, double>();

        public void AddExam(string examName, double point)
        {
            Exams.Add(examName, point);
        }

        public GetExamResult(string examName)
        {
            foreach (var item in Exams)
            {
                if(item.Value.)
            }
        }
    }
}
