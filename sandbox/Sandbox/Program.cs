using System;

class Program
{
    static void Main(string[] args)
    {
        // This is a comment in C#. It's just like a comment in C
        /* This is a block comment
        you can add multiple lines to the comment
        and close it with */
        // Console.WriteLine("Hello Sandbox World!");


        for(int i=0; i<=65; i++)
        {
            long x = (long)Math.Pow(2,i);
            Console.WriteLine($"2^{i}: {x}");
        }
    }
}