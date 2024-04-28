namespace ConsoleApp_.Models;

public abstract class Person
{
    private static int _id;
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public byte Age { get; set; }
    public Person()
    {
        Id = ++_id;
    }
}
