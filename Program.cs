
using ConsoleApp_.Models;
CustomCollection<Employee> cc = new();
Console.WriteLine("Welcome to ConsoleApp\n");
start:
Console.WriteLine("Please choose the option you want\n");
Console.WriteLine("1. Add employee\n");
Console.WriteLine("2. Find employee by Id\n");
Console.WriteLine("3. Display all employees\n");
int choice = int.Parse(Console.ReadLine());

do
{
    switch (choice)
    {
        case 1:
            Console.Write("Enter employee name : ");
            string name = Console.ReadLine();
            Console.Write("Enter employee surname : ");
            string surname = Console.ReadLine();
            Console.Write("Enter employee age : ");
            byte age = byte.Parse(Console.ReadLine());
            Employee employee = new(name,surname,age);
            cc.Add(employee);
            Console.WriteLine("Employee added!\n");
            break;
        case 2:
            Console.Write("Enter employee Id : ");
            int id = int.Parse(Console.ReadLine());
            cc.FindById(id);
            break;
        case 3:
            cc.GetAll();
            break;
    }
    Console.WriteLine("Do you want continue?(Yes/no)");
    string answer = Console.ReadLine().ToLower();
    if (answer == "yes") goto start;
    else if (answer == "no") choice = 0;
} while (choice != 0);


