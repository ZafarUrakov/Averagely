using System;
using System.Diagnostics;
using Averagely.Classes;

namespace Averagely
{
    class Programm
    {
        static void Main()
        {
            string backToMenu;
            var report = new Report();
            do
            {
                Console.Clear();
                report.ShowMenu();
                int studentChoice = report.FormatExceptionMessage();

                switch (studentChoice)
                {
                    case 1:
                        Console.Clear();
                        int studentsAge =
                            ValueManipulator.GetUserValueByMassageToInt("How old are you student?\nMy age: ");
                        var average = new Average(studentsAge);
                        average.AverageSecurity();
                        break;
                    case 2:
                        Console.Clear();
                        report.Exit();
                        break;
                    default:
                        report.DefaultProgress();
                        break;
                }

                backToMenu = ValueManipulator.AppLogin();
            } while (backToMenu == "yes");
        }
    }
}