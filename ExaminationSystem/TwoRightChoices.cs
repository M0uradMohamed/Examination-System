using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class TwoRightChoices : MultiChoice
    {
        public TwoRightChoices()
        {
            QuestionKind = "two right ansers";
        }
        public override void enterQuePart()
        {

            string input;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("enter the two right anser letters (A,b,c,d) : ");
                string firstAnser;
                while (true)
                {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("enter the first right anser");
                    input = Console.ReadLine();
                    if (input.ToLower() == "a" || input.ToLower() == "b" || input.ToLower() == "c" || input.ToLower() == "d")
                    {
                        firstAnser = input;
                        break;
                    }
                    else
                    {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("unknown input");
                    }
                }
            string secondAnser;
            while (true)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("enter the second right anser");
                input = Console.ReadLine();
                if ( input.ToLower() == "a" || input.ToLower() == "b"|| input.ToLower() == "c" || input.ToLower() == "d")
                {
                    if (input.ToLower() != firstAnser)
                    {
                        secondAnser = input;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine($"it is the same letter as first anser ({firstAnser})");
                        Console.WriteLine("please enter another letter");
                    }
                }
                else
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("unknown input");
                }
            }
            RightAnser = $"{firstAnser} , {secondAnser}";
        }

        public override void displayQuestionsPart(int i, Student student)
        {
            string anser1;
            string anser2;
            while (true)
            {

                Console.WriteLine("-----------------------------");
                Console.WriteLine("enter the first right anser from (A,B,C,D)");
                anser1 = Console.ReadLine();
                if (anser1.ToLower() == "a" || anser1.ToLower() == "b" || anser1.ToLower() == "c" || anser1.ToLower() == "d")
                {
                    if (RightAnser.ToLower().Contains(anser1.ToLower() ))
                    {
                        student.FullScore += Mark / 2;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("unknown input");
                }
            }

            while (true)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("enter the second right anser fron (A,B,C,D)");
                anser2 = Console.ReadLine();
                if (anser2.ToLower() == "a" || anser2.ToLower() == "b" || anser2.ToLower() == "c" || anser2.ToLower() == "d")
                {
                    if (anser2.ToLower() == anser1.ToLower())
                    {
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine($"it is the same letter as first anser ({anser1})");
                        Console.WriteLine("please enter another letter");
                    }
                    else 
                    {
                        if (RightAnser.ToLower().Contains(anser2.ToLower()))
                        {
                            student.FullScore += Mark / 2;
                            
                        }
                        break;
                    }
                    
                }
                else
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("unknown input");
                }
            }

        }
    }
}
