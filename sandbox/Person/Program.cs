class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("Bob", "Roberts", 57, 198);
        Console.WriteLine(myPerson.GetPersonInformation());

        Police myPoliceman = new Police("gun", "Robert", "Bob", 43, 187);
        Console.WriteLine(myPoliceman.GetPersonInformation());
        Console.WriteLine(myPoliceman.GetPolicemanInformation());

        Doctor myDoctor = new Doctor("PhD", "Bob", "Chop", 43, 186);
        Console.WriteLine(myDoctor.GetDoctorInformation());
    }
}