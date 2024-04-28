namespace ConsoleApp_.Models;

public class Employee : Person
{
    public int Salary { get; set; }
    public Employee(string name,string surname,byte age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }
}
