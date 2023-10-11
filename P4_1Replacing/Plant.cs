namespace P4_1Replacing;

public class Plant
{
    bool isGrown;

    public void PrintStatus()
    {
        if (isGrown)
        {
            Console.WriteLine("Plant is a tree");
        }
        else
        {
            Console.WriteLine("Plant is a seed");
        }
    }

    public void Grow()
    {
        isGrown = true;
        Console.WriteLine("Plant is growing");
        
    }
    
    
}