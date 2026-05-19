class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Angle World");

        Angle myAngle = new Angle();
        myAngle.SetRadians(5);
        Console.WriteLine(myAngle.GetRadians());
    }
}