using System;

class Program
{
    static void Main(string[] args)
    {
        Square mySquare = new Square("red", 4);
        Console.WriteLine($"Color: {mySquare.GetColor()}");
        Console.WriteLine($"Area: {mySquare.GetArea()}");

        Rectangle myRectangle = new Rectangle("blue", 5, 4);
        Console.WriteLine($"Color: {myRectangle.GetColor()}");
        Console.WriteLine($"Area: {myRectangle.GetArea()}");

        Circle myCircle = new Circle("green", 3);
        Console.WriteLine($"Color: {myCircle.GetColor()}");
        Console.WriteLine($"Area: {myCircle.GetArea()}");
    }
}