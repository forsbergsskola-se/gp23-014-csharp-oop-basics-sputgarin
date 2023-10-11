using System.Threading.Channels;

namespace P3_2People;

public class Person
{
    public string name;

    public void Greeting()
    {
        Console.WriteLine($"Hello {name}");
    }
}