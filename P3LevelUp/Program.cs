using P3LevelUp;

Player player = new Player();

Console.WriteLine("How much experience do you want to give the player.");
int userInput = int.Parse(Console.ReadLine());

player.grantExperience(userInput);


Console.WriteLine($"You are lvl {player.playerLvl}");
Console.WriteLine($"You have {player.playerExperience} XP");

