using P4_2AllTheSame;

ScoreCounter scoreCounter = new ScoreCounter();
var one = scoreCounter;
var two = one;
var three = two;
var four = three;

one.IncreaseScore();
two.IncreaseScore();
three.IncreaseScore();
four.IncreaseScore();

Console.WriteLine(one.score);
Console.WriteLine(two.score);
Console.WriteLine(three.score);
Console.WriteLine(four.score);