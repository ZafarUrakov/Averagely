using System;

namespace Averagely
{
    class Programm
    {
        static void Main()
        {

            Console.WriteLine("\tHi student,please enter your grades for this year.\n");

            Console.Write("English: ");
            double english = double.Parse(Console.ReadLine()!);

            Console.Write("Mathematics: ");
            double math = double.Parse(Console.ReadLine()!);

            Console.Write("Geography: ");
            double geography = double.Parse(Console.ReadLine()!);

            Console.Write("Biology: ");
            double biology = double.Parse(Console.ReadLine()!);

            Console.Write("Chemistry: ");
            double chemistry = double.Parse(Console.ReadLine()!);

            double allBall = english + math + geography + biology + chemistry;
            double answer = allBall / 5;
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
    }
}