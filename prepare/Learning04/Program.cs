using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment myMathAssignment = new MathAssignment("2.1", "1-21", "Bob Bobbertson", "Differential Equations");
        WritingAssignment myWritingAssignment = new WritingAssignment("Effect of Phoenetic Spelling on the Naming of Countries", "Bob Bobbertson", "English 101");

        Console.WriteLine(myMathAssignment.GetSummary());
        Console.WriteLine(myMathAssignment.GetHomeworkList());

        Console.WriteLine(myWritingAssignment.GetSummary());
        Console.WriteLine(myWritingAssignment.GetWritingInformation());
    }
}