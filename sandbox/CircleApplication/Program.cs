class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Hello World!");
        Circle myCircle = new Circle();

        myCircle.SetRadius(10);
        Console.WriteLine(myCircle.GetArea());

        Cylinder myCylinder = new Cylinder();
        myCylinder._circle = new Circle();
        myCylinder._circle.SetRadius(10);
        myCylinder._height = 30;
        Console.WriteLine(myCylinder.GetCylinderVolume());
    }
}