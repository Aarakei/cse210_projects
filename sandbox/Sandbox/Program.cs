using System;

class Program
{
    static void PrintIntList(List<int> list)
    {
        Console.WriteLine("Int List:");
        foreach(int i in list)
        {
            Console.WriteLine($"[{list.IndexOf(i)}]: {i}");
        }
    }
    static void Main(string[] args)
    {
        // This is a comment in C#. It's just like a comment in C
        /* This is a block comment
        you can add multiple lines to the comment
        and close it with */
        // Console.WriteLine("Hello Sandbox World!");


        List<int> intList = new List<int>();
        List<float> floatList = new List<float>();
        List<int> anothaList = new List<int>();
        anothaList = [1,2,3];

        floatList.Add((float)3.14159);
        floatList.Add((float)2.71828);

        float e_plus_pi = floatList[0] + floatList[1];
        intList.Add(5);

        Console.WriteLine($"intList[0] = {intList[0]}");
        Console.WriteLine($"e plus pi  = {e_plus_pi}");

        intList.Insert(0,257);
        intList.Insert(1,15);

        PrintIntList(intList);

        intList.Remove(15);
        intList.RemoveAt(1);

        PrintIntList(intList);

        int num_1 = 3;
        int num_2 = 1;

        int result = num_1 & num_2;

        Console.WriteLine(result);
    }
}