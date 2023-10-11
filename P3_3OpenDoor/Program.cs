using P3_3OpenDoor;

House redHouse = new House();
House blueHouse  = new House();

Console.WriteLine($"Red house door is: {redHouse.isDoorOpen} Blue house door is: {blueHouse.isDoorOpen}");
blueHouse.OpenDoor();
Console.WriteLine($"Red house door is: {redHouse.isDoorOpen} Blue house door is: {blueHouse.isDoorOpen}");
redHouse.OpenDoor();
Console.WriteLine($"Red house door is: {redHouse.isDoorOpen} Blue house door is: {blueHouse.isDoorOpen}");
