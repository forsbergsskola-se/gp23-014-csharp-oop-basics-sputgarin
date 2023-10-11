namespace RPG;

public class Monster
{
    public int health;

    public void Attack(Player target)
    {
        target.health--;
        Console.WriteLine($"The monster attacks you. You have {target.health} Health");
    }
    
}