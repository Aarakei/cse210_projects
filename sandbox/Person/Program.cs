class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("Bob", "Roberts", 57, 198);
        Console.WriteLine(myPerson.GetPersonInformation());
    }
}