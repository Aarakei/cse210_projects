abstract class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    private int _weight;

    public Person(string firstName, string lastName, int age, int weight)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
        _weight = weight;
    }

    public virtual string GetPersonInformation()
    {
        return $"Name: {_firstName} {_lastName}, age: {_age}, weight: {_weight}";
    }

    public void ChangeWeight(int change)
    {
        SetWeight(_weight + change);
    }

    public bool SetAge(int age)
    {
        _age = age;

        if (age < 0 || age > 120)
        {
            _age = 0;
            return false;
        }

        return true;
    }

    public bool SetWeight(int weight)
    {
        _weight = weight;

        if (weight < 0 || weight > 500)
        {
            _weight = 0;
            return false;
        }

        return true;
    }

    public abstract double GetSalary();
}