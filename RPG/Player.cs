
using RPG;

public class Player
{
    public int health;

    public void Attack(Monster target)
    {
        target.health--;
        Console.WriteLine($"You attack the monster, It has {target.health} Health.");
    }

    public void Heal()
    {
        this.health = 3;
        Console.WriteLine($"You heal yourself. You have {this.health} left.");
    }
}