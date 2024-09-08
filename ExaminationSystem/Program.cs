using System.Threading.Channels;

namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<Teacher> teachers = new List<Teacher>();
          List<Student> students = new List<Student>();
            string input="0";
            do
            {
 
                InputsAndOutputs.startOutput();

                    input = Console.ReadLine();

                   //choose teacher
                    if (input =="1")
                    {
                    InputsAndOutputs.createTeacher(teachers);

                    }
                    //choose student
                    else if(input =="2")
                    {
                        if (teachers.Count() == 0)
                        {
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("there is not any exam");
                        }
                        else
                        {
                        Student student = new Student();

                        InputsAndOutputs.createStudent(students, teachers);
                        }

                    }
                    else if (input == "Q" || input == "q")
                    {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("thank you");
                    Console.WriteLine("-----------------------------");
                    break;
                    }
                    else
                    {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("unknown input");
                    Console.WriteLine("please , try again");
                    }
                Console.WriteLine("-----------------------------");



            } while (input!="q" && input !="Q");
        }
    }
}
