﻿
Player player1 = new Player();
Player player2 = new Player();

Console.WriteLine("Player 1 attack Player 2");
player1.Attack(player2);
Console.WriteLine($"Player 1 damage: {player1.damage}");
Console.WriteLine($"Player 2 damage {player2.damage}");


Console.WriteLine("Player 2 attack Player 1");
player2.Attack(player1);
Console.WriteLine($"Player 1 damage: {player1.damage}");
Console.WriteLine($"Player 2 damage {player2.damage}");


Console.WriteLine("Player 1 attack Player 1");
player1.Attack(player1);
Console.WriteLine($"Player 1 damage: {player1.damage}");
Console.WriteLine($"Player 2 damage {player2.damage}");

Player player3 = new Player();
player1 = player3;

Console.WriteLine("Player 2 attack Player 1");
player2.Attack(player3);
Console.WriteLine($"Player 1 damage: {player1.damage}");
Console.WriteLine($"Player 2 damage {player2.damage}");
Console.WriteLine($"Player 3 damage {player3.damage}");
