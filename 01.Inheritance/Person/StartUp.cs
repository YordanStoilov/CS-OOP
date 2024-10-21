using System;

namespace Person;

public class StartUp
{
    public static void Main()
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        if (age > 15)
        {
            Person person = new(name, age);
            Console.WriteLine($"Person -> {person.ToString()}");
        }
        else if (age <= 0)
        {
            Console.WriteLine("Age must be positive!");
        }
        else
        {
            Child child = new(name, age);
            Console.WriteLine($"Child -> {child.ToString()}");
        }
    }
}