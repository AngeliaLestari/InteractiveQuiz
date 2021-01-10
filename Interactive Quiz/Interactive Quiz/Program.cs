using System;

namespace Interactive_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            

            string[] questions = new string [] { "Monkey is an animal", "5 is bigger than 4", "Sunflower is a fruit", "Alexander Fleming discovered penicillin", "There are five different blood groups" };
            bool[] answers = new bool[] { true, true, false, true, false };
            bool[] responses = new bool [questions.Length];
            
                if (questions.Length != responses.Length)
                {
                Console.WriteLine("warning question is not the same with response");
                }

            int askingIndex = 0;
            foreach (string question in questions)
            {
                string input;
                bool isbool;
                bool inputbool;
                Console.WriteLine(question);
                Console.WriteLine("TRUE OR FALSE?");
                input = Console.ReadLine();
                isbool = Boolean.TryParse(input, out inputbool);
                while (!isbool)
                    {
                    Console.WriteLine("The only accepted answer is True or False");
                    input = Console.ReadLine();
                    isbool = Boolean.TryParse(input, out inputbool);
                    }
                inputbool = responses[askingIndex];
                askingIndex++;
            }

            foreach (bool inp in responses) 
            {
                Console.WriteLine(inp);
            } 

            int scoringindex = 0;
            int scoring = 0;

            foreach (bool ans in answers) 
            {
                bool response = responses [scoringindex];
                Console.Write(scoringindex + 1 + ".");
                Console.WriteLine($"Input {response}|Answer {ans}");

                if (ans == response) 
                    {
                        scoring++;
                    }
                scoringindex++;
                
            }
            Console.WriteLine($"You Got {scoring} of {scoringindex} correct");




            }

        }
    }

