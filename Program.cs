using System;

namespace Averagely
{
    class Programm
    {
        static void Main()
        {
            Console.WriteLine(@"
            1.Calculate score
            2.Exit");

            Console.Write("Your choice: ");
            int studentChoice = Convert.ToInt32(Console.ReadLine()!);

            while(studentChoice == 1)
            {
                Console.WriteLine("\nHow old are you student?: ");
                Console.Write("Old: ");
                int old = Convert.ToInt32(Console.ReadLine()!);
                if(old < 25)
                {
                    Console.WriteLine("How many subjects did you take this year?");
                    Console.Write("Number of subject: ");
                    int numberofItems = Convert.ToInt32(Console.ReadLine()!);

                    double totalScore = 0;

                    for(int scoring = 1; scoring <= numberofItems; scoring ++)
                    {
                        Console .Write($"subject {scoring}: ");
                        double subject = Convert.ToDouble(Console.ReadLine()!);

                        totalScore += subject;
                    }
                    double answer = totalScore / numberofItems;


                    Console.WriteLine($"\nYour avarege score = {answer}!\n");

                    switch(answer)
                    {
                        case >= 4:
                            Console.WriteLine("You're doing great!");
                            break;
                        default:
                            Console.WriteLine("You need to do better next year , apprentice!");
                            break;
                    }
                }
                else
                    Console.WriteLine("I am sorry , but you did not study with us...");

            }
        }
    }
}