Random rand = new Random();

var coinFlip = rand.Next(0, 2);

string result = coinFlip == 0 ? "Heads" : "Tails";

Console.WriteLine(result);


