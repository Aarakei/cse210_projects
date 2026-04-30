using System;
using System.Reflection.Emit;

class Program
{
    
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        int numberInput = 1;
        Console.WriteLine("Input a list of numbers. Type 0 when finished.");

        while(numberInput != 0)
        {
            Console.Write("Input a number: ");
            numberInput = int.Parse(Console.ReadLine());

            if (numberInput != 0)
            {
                numberList.Add(numberInput);
            }
        }

        int sum = numberList.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double average = numberList.Average();
        Console.WriteLine($"The average is: {average}");

        int maximum = numberList.Max();
        Console.WriteLine($"The largest number is: {maximum}");

        int minPositive = numberList.FindAll(number => number > 0).Min();
        Console.WriteLine($"The smallest positive number is {minPositive}");

        numberList.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numberList)
        {
            Console.WriteLine(number);
        }
    }
}