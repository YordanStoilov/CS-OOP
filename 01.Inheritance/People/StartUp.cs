namespace Person;

public class StartUp
{
    public static void Main()
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        if (age > 15)
        {
            Person person = new Person(name, age);
            Console.WriteLine($"Person -> {person.ToString()}");
        }
        else
        {
            Child child = new Child(name, age);
            Console.WriteLine($"Child -> {child.ToString()}");
        }
    }
}
