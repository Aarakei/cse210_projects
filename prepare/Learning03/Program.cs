using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine($"Blank initializer: {fraction1.GetFractionString()} or {fraction1.GetDecimalValue()}");

        Fraction fraction2 = new Fraction(25);
        Console.WriteLine($"Whole number initializer: {fraction2.GetFractionString()} or {fraction2.GetDecimalValue()}");
        
        Fraction fraction3 = new Fraction(22,3);
        Console.WriteLine($"Blank initializer: {fraction3.GetFractionString()} or {fraction3.GetDecimalValue()}");

        Random generator = new Random();
        int randomNumber;
        Fraction randomFraction = new Fraction();

        for(int i = 0; i < 30; i++)
        {
            randomNumber = generator.Next(-100,101);
            randomFraction.SetTop(randomNumber);

            randomNumber = generator.Next(1,101);
            randomFraction.SetBottom(randomNumber);

            string fractionString = randomFraction.GetFractionString();
            double decimalValue = randomFraction.GetDecimalValue();

            Console.WriteLine($"Fraction {i+1}: string: {fractionString} Number: {decimalValue}");
        }
    }
}