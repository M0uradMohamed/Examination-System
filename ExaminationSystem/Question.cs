using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Question
    {
        public string QueSenten { get; set; } = null!;
        public string Diffculty { get; set; } = null!;
        public int Mark { get; set; }
        public string RightAnser { get; set; } = null!;

        public string QuestionKind { get; set; } = null!;
        public string AnserStore { get; set; } = null!;

        public virtual void  enterQue (int i )
        {

            Console.WriteLine("-----------------------------");
            Console.WriteLine($"{i}- {QuestionKind}");
            while (true)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("enter the question diffculty ( Easy , Medium , Hard )");
                string diff = Console.ReadLine();
                if (diff.ToLower() == "easy" || diff.ToLower() == "medium" || diff.ToLower() == "hard")
                {
                    Diffculty = diff;
                    break;
                }
                else
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("unknow difficulty");
                }
            }
            while (true)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("enter the question mark ");
                var mark = InputsAndOutputs.isInputInt();
                if(mark.Item2 == true && mark.Item1<=0)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("the input is <=0  , enter a positive number");
                }
                else if(mark.Item2== true)
                {
                    Mark= mark.Item1;

                    break;
                }
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("enter the question form ");
            QueSenten = Console.ReadLine();


        }

        public virtual void displayQuestions(int i ,Student student)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"{i + 1}-{QuestionKind}  | {Mark} marks");
                Console.WriteLine($"{QueSenten}");            
        }
    }
}
