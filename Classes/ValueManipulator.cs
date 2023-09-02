namespace Averagely.Classes;
public class ValueManipulator
{
    public static double GetUserValueByMassage(string text)
    {
        Console.Write(text);
        double result;

        while (!double.TryParse(Console.ReadLine(), out result))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input. Please enter valid numeric values.");
            Console.ResetColor();
            Console.Write(text);
        }
        return result;
    }
    
    public static int GetUserValueByMassageToInt(string text)
    {            
        Console.Write(text);
        int result;

        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input. Please enter valid numeric values.");
            Console.ResetColor();
            Console.Write(text);
        }
        return result;
    }
    
    public static string AppLogin() 
    { 
        Console.Write("\nLaunch the application? yes or no\nChoice: "); 
        string choice = Console.ReadLine()!; 
        return choice;
    }
}
    
