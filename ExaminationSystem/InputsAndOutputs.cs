using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    static public class InputsAndOutputs
    {
        public static void startOutput()
        {
            Console.WriteLine($"type (1) to Enter as a teacher");
            Console.WriteLine($"type (2) to Enter as a student");
            Console.WriteLine($"type (Q) to exit");
            Console.Write($"Enter : ");
        }
        public static void createTeacher ( List<Teacher> teachers )
        {
            Teacher teacher = new Teacher();

            teacher.insertTeacherProps();

         int questAmout =teacher.takeQuestionCount();

            teacher.insetQuestions(questAmout, teacher);

            teachers.Add(teacher);
            Console.WriteLine("the exam entered successfully");
        }
        public static void displayQuesTypes()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"choose question type");
            Console.WriteLine("Enter 1 for True and false");
            Console.WriteLine("Enter 2 for multiple choice");
            Console.WriteLine("Enter 3 for choose the two right ansers");
            Console.Write("your input = ");

        }
        public static void createStudent(List<Student>students,List<Teacher>teachers)
        {
            Student student = new Student();
            student.insertStudentProps();

            displayTeachers(teachers);

            int examNum = chooseTeacherExam(teachers);

            Console.WriteLine("the exam started");

            enterExam(teachers, examNum,student);
            students.Add(student);
            student.displayStudentScore(teachers[examNum].FullExamScore);
        }
        public static void enterExam(List<Teacher> teachers, int examNum, Student student)
        {
            for (int i = 0; i < teachers[examNum].questions.Count; i++)
            {
                teachers[examNum].questions[i].displayQuestions(i,student);
            }
        }
        public static int chooseTeacherExam(List<Teacher> teachers)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"enter a number for 1 to {teachers.Count()}");
            Console.Write($"to enter the test : ");
            var result = isInputInt();
            return result.Item1-1;
            
        }

        public static void displayTeachers( List<Teacher> teachers )
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"there is {teachers.Count()} exams in the system");
            for (int i = 0; i < teachers.Count; i++)
            {
                Console.WriteLine($"{i+1}- teacher : {teachers[i].Name}");
            }
        }
        public static (int, bool) isInputInt ()
        {
            while (true)
            {
                int number = 0;
                try
                {
                    number = int.Parse(Console.ReadLine());
                    return ( number , true);
                }
                catch (FormatException)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("unknown input");
                    return ( number , false);
                }
            }


        }
    }
}
