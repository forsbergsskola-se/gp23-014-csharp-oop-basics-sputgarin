
// Creates an array. 
Person[] person = new Person[3];

// Instanziation of an object of a class
person[0] = new Person();
person[1] = new Person();
person[2] = new Person();

Print(person[0]);
Print(person[1]);
Print(person[2]);

void Print(Person person)
{
    Console.WriteLine(person);
}


// Class declaration
public class Person
{
    
}

