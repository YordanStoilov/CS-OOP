namespace CustomRandomList;

public class StartUp
{
    static void Main()
    {
        RandomList ls = new RandomList() { "sh", "ch", "dz"};

        Console.WriteLine(ls.RandomString());
    }
}