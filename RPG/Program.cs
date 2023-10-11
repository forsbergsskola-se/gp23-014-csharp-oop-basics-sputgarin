using RPG;

Player player = new Player();
player.health = 3;
Monster monster = new Monster();
monster.health = 3;

Console.WriteLine($@"You have: {player.health} Health.
You are fighting a monster with {monster.health} Health;");

while (player.health > 0)
{
    char userInput = GetUserInput();
    if (userInput == 'A')
    {
        player.Attack(monster);

    }
    else if (userInput == 'H')
    {
        player.Heal();
    }
    
    // Monsters Turn
    if (monster.health > 0)
    {
        monster.Attack(player);
    }
    else
    {
        monster = new Monster();
        monster.health = 3;
        Console.WriteLine($"A new monster spawns with {monster.health} Health.");
    }
    
}
Console.WriteLine("GAME OVER!");

char GetUserInput()
{
    Console.WriteLine("What do you want to do [A]ttack or [H]eal?");
    ConsoleKeyInfo key = Console.ReadKey();
    Console.WriteLine();
    return char.ToUpper(key.KeyChar);
}

