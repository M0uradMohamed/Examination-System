using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Student
    {
        public string Name { get; set; } = null!;

        public double FullScore { get; set; } = 0 ;

        public void insertStudentProps()
        {
            Console.WriteLine("-----------------------------");
            Console.Write("enter you name :");
            Name = Console.ReadLine();
        }

        public void displayStudentScore(double fullExamScore)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("the exam ended");
            Console.WriteLine($"student name : {Name}");
            Console.WriteLine($"student exam mark : {FullScore}/{fullExamScore}");
        }
    }
}
