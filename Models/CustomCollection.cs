namespace ConsoleApp_.Models;

public class CustomCollection<T> where T : Person
{
    private List<T> list = new List<T>();
    public void Add(T entity)
    {
        list.Add(entity);
    }
    public void FindById(int id)
    {
        bool found = false;
        foreach (T entity in list)
        {
            if (entity.Id == id)
            {
                found = true;
                Console.WriteLine($"Name : {entity.Name}\nSurname : {entity.Surname}\nAge : {entity.Age}");
            }
        }
        if (!found) Console.WriteLine("Employee not found\n");
    }
    public void GetAll()
    {
        foreach (T entity in list)
        {
            Console.WriteLine($"Id : {entity.Id}\nName : {entity.Name}\nSurname : {entity.Surname}\nAge : {entity.Age}\n");
        }
    }
}
