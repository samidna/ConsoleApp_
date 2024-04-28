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
                Console.WriteLine($"Name : {entity.Name}\nSurname : {entity.Surname}\nAge : {entity.Age}");
                found = true;
            }
        }
        if(!found) Console.WriteLine("Employee not found\n");
    }
    public void GetAll()
    {
        foreach (T entity in list)
        {
            Console.WriteLine($"Id : {entity.Id}\nName : {entity.Name}\nSurname : {entity.Surname}\nAge : {entity.Age}\n");
        }
    }
}
