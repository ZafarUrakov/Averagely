namespace Averagely.Classes;

public class Average
{
    private int StudentsOld { get; set; }
    
    public Average(int studentsOld)
    {
        StudentsOld = studentsOld;
    }
    
    public void AverageSecurity()
    {
        while(StudentsOld > 20)
        {
                Console.Clear();
                Report.AgeLimit();
                StudentsOld = ValueManipulator.
                    GetUserValueByMassageToInt("How old are you student?\nMy age: ");
        }
        Scoring();
    }

    private void Scoring()
    {
        Console.Clear();
        int numberOfItems = ValueManipulator.GetUserValueByMassageToInt
            ( "How many subjects did you take this year?\nNumber of subject: ");

        double totalScore = 0;

        for(int scoring = 1; scoring <= numberOfItems; scoring ++)
        {
            Console .Write($"subject {scoring}: ");
            double subject = Convert.ToDouble(Console.ReadLine()!);

            totalScore += subject;
        }
        double answer = totalScore / numberOfItems;
        
        Console.WriteLine($"\nYour average score = {answer}!\n");

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