

namespace CustomStack;
public class StartUp
{
    static void Main()
    {
        StackOfStrings sos = new StackOfStrings();

        sos.AddRange(new List<string>() { "ch", "sh" });

        Console.WriteLine(sos.IsEmpty());

        foreach (string s in sos)
        {
            Console.WriteLine(s);
        }
    }
}
