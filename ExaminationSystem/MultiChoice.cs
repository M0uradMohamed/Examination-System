using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class MultiChoice : Question
    {
        public string anserA { get; set; } = null!;
        public string anserB { get; set; } = null!;
        public string anserC { get; set; } = null!;
        public string anserD { get; set; } = null!;

        public MultiChoice()
        {
            QuestionKind = "multiple choice";
        }
        public override void enterQue(int i)
        {

            base.enterQue(i);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("enter choices");

            Console.Write("a : ");
            anserA = Console.ReadLine();  
            Console.Write("b : ");
            anserB = Console.ReadLine();   
            Console.Write("c : ");
            anserC = Console.ReadLine(); 
            Console.Write("d : ");
            anserD = Console.ReadLine();

             enterQuePart();

        }
        public virtual void enterQuePart()
        {
            while (true)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("enter the right anser letter (A,b,c,d) : ");
                string input = Console.ReadLine();
                if (input.ToLower() == "a" || input.ToLower() == "b" || input.ToLower() == "c" || input.ToLower() == "d")
                {
                    RightAnser = input;
                    break;
                }
                else
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("unknown input");
                }
            }
        }
        public override void displayQuestions(int i, Student student)
        {
            base.displayQuestions(i, student);

            Console.WriteLine("-----------------------------");
            Console.WriteLine($"A : {anserA}");
            Console.WriteLine($"B : {anserB}");
            Console.WriteLine($"C : {anserC}");
            Console.WriteLine($"D : {anserD}");

            displayQuestionsPart( i, student);


        }
        public virtual void displayQuestionsPart(int i, Student student)
        {
            while (true)
            {
                Console.WriteLine("-----------------------------");
                Console.Write("choose from (A,B,C,D) : ");
                string anser = Console.ReadLine();
                if (anser.ToLower() == "a" || anser.ToLower() == "b" || anser.ToLower() == "c" || anser.ToLower() == "d")
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
                    Console.WriteLine("unknown input");
                }
            }
        }
    }
}





