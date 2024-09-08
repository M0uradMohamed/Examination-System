using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class TrueOrfalse : Question
    {
        public TrueOrfalse()
        {
            QuestionKind = "true or false";
        }
        public override void enterQue(int i)
        {       

            base.enterQue(i);

            while (true)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Enter the right anser (true or false) ");
                string enter = Console.ReadLine();
                if (enter.ToLower() == "true" || enter.ToLower() == "false")
                {
                    RightAnser = enter;
                    break;
                }
                else
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("unknowen input");
                }
            }
        }
        public override void displayQuestions(int i , Student student)
        {
            base.displayQuestions(i,student);

            while (true)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("choose true or false");

                string anser = Console.ReadLine();
                if (anser.ToLower() == "true" || anser.ToLower() == "false")
                {
                    if (anser.ToLower() == RightAnser)
                    {
                        student.FullScore += Mark;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("unknowen input");
                }
            }
        }
    }
}
