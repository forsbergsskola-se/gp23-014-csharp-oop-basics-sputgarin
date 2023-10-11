using P3_2People;

Person[] person = new Person[3];

for (int i = 0; i < person.Length; i++)
{
    person[i] = new Person();
}

for (int i = 0; i < person.Length; i++)
{
    Console.WriteLine("Please enter a name: ");
    person[i].name = Console.ReadLine();
}

for (int i = 0; i < person.Length; i++)
{
    Console.WriteLine();
    Console.WriteLine("You name is:");
    Console.WriteLine(person[i].name);
}
