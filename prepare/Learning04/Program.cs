using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment myMathAssignment = new MathAssignment("2.1", "1-21", "Bob Bobbertson", "Differential Equations");
        Console.WriteLine(myMathAssignment.GetSummary());
        Console.WriteLine(myMathAssignment.GetHomeworkList());
    }
}