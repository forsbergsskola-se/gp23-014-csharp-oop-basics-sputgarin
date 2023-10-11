using P2Fields;

Player player = new Player();
player.gold = 200;
player.stone = 110;
player.wood = 53;
player.lvl = 12;
player.xp = 123;
player.activeVIPSub = true;
player.pvpEnabled = false;
player.displayName = "Marc";
player.emailAddress = "marc@zaku.de";

Console.WriteLine($"Gold {player.gold}");
Console.WriteLine($"Stone {player.stone}");
Console.WriteLine($"Wood {player.wood}");
Console.WriteLine($"LVL {player.lvl}");
Console.WriteLine($"XP {player.xp}");
Console.WriteLine($"VIP {player.activeVIPSub}");
Console.WriteLine($"PVP {player.pvpEnabled}");
Console.WriteLine($"Name {player.displayName}");
Console.WriteLine($"Email {player.emailAddress}");
Console.WriteLine($"Gold {player.gold}");


