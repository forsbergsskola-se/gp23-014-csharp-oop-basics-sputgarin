
Knight attacker = new Knight();
Knight defender = new Knight();
defender.shield = new Shield();

attacker.Attack(defender);

Console.WriteLine("Equipping Sword...");
attacker.sword = new Sword();
attacker.Attack(defender);

attacker.Attack(defender);
