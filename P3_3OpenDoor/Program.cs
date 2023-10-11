using P3_3OpenDoor;

House redHouse = new House();
House blueHouse  = new House();

Console.WriteLine($"Red house door is: {redHouse.door} Blue house door is: {blueHouse.door}");
blueHouse.OpenDoor();
Console.WriteLine($"Red house door is: {redHouse.door} Blue house door is: {blueHouse.door}");
redHouse.OpenDoor();
Console.WriteLine($"Red house door is: {redHouse.door} Blue house door is: {blueHouse.door}");
