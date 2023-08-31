// For Loop Section

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(i);
}

System.Console.WriteLine("==========================================");

for (int i = 2; i >= 0; i--)
{
    Console.WriteLine(i);
}

System.Console.WriteLine("==========================================");

for (int i = 0; i < 9; i += 3)
{
    Console.WriteLine(i);
}

System.Console.WriteLine("==========================================");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 2) break;
}

System.Console.WriteLine("==========================================");

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

// System.Console.WriteLine("==========================================");

// string[] names1 = { "Alex", "Eddie", "David", "Michael" };
// foreach (var name in names1)
// {
//     // Can't do this:
//     if (name == "David") name = "Sammy";
// }

System.Console.WriteLine("==========================================");

string[] names2 = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names2.Length; i++)
{
    if (names2[i] == "David") names2[i] = "Sammy";
}


foreach (var name in names2)
{
    Console.WriteLine(name);
}

System.Console.WriteLine("==========================================");

for (int value = 1; value <= 20; value++)
{
    if(value % 3 == 0 && value % 5 == 0)
        Console.WriteLine($@"{value} - FizzBuzz");
    else if (value % 3 == 0)
        Console.WriteLine($@"{value} - Fizz");
    else if (value % 5 == 0)
        Console.WriteLine($@"{value} - Buzz");
    else
        Console.WriteLine($@"{value}");
}

System.Console.WriteLine("==========================================");

// Do While Section
Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

System.Console.WriteLine("==========================================");

// keyword continue in do-while
Random random2 = new Random();
int current2 = random2.Next(1, 11);;

do
{
    current2 = random2.Next(1, 11);
    if (current2 >= 8) continue;
    Console.WriteLine(current2);
} while (current2 != 7);

System.Console.WriteLine("==========================================");

Random random1 = new Random();
int current1 = random1.Next(1, 11);

while (current1 >= 3)
{
    Console.WriteLine(current1);
    current1 = random1.Next(1, 11);
}
Console.WriteLine($"Last number: {current1}");

System.Console.WriteLine("==========================================");

string? readResult;
Console.WriteLine("Enter a string:");
do
{
    readResult = Console.ReadLine();
} while (readResult != null && readResult.Length < 3);

// capture user input in a string variable named readResult
int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);
System.Console.WriteLine(validNumber);

System.Console.WriteLine("==========================================");