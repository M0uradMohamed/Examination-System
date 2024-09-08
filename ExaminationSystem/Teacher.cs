using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Teacher
    {
        public string Name { get; set; } = null!;

        public List<Question> questions { get; set; } = null!;

        public double FullExamScore { get; set; } = 0;

        public Teacher() 
        {
           
            questions = new List<Question>();
        }

        public void insertTeacherProps()
        {
            Console.WriteLine("-----------------------------");
            Console.Write("Enter teacher name : ");
            Name = Console.ReadLine();
        }

        public int takeQuestionCount()
        {
            while (true)
            {
                Console.WriteLine("-----------------------------");
                Console.Write("Enter the number of quetions = ");
              var  result = InputsAndOutputs.isInputInt();
               int listQuesSize = result.Item1;

                if (result.Item2 == true && result.Item1 >=3)
                {
                    return listQuesSize;
                    break;
                }
                else if (result.Item2==true)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("you can not Enter less than 3 questions");
                }
            }
        }

        public void insetQuestions(int listQuesSize, Teacher teacher)
        {
            for (int i = 1; i <= listQuesSize;)
            {
                InputsAndOutputs.displayQuesTypes();

                string queInput = Console.ReadLine();

                if (queInput == "1" || queInput == "2" || queInput == "3")
                {
                   Question queTemp = null;

                    if (queInput == "1")
                    {
                        queTemp = new TrueOrfalse();
                    }
                    else if (queInput == "2")
                    {
                        queTemp = new MultiChoice();
                    }
                    else if (queInput == "3")
                    {
                        queTemp = new TwoRightChoices();
                    }
                    queTemp.enterQue(i);
                    teacher.FullExamScore += queTemp.Mark;

                    teacher.questions.Add(queTemp);
                }
                else
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("unknowen input");
                    continue;
                }

                i++;
            }
        }

    }
}
