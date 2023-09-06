Console.WriteLine("===========================================================");

// Understand the syntax of methods
void SayHello()
{
    Console.WriteLine("Hello World!");
}

SayHello();

Console.WriteLine("===========================================================");

// Calling a method
SayOla();

void SayOla()
{
    Console.WriteLine("Ola Mundo!"); // still callable even method declared after invoking
}

Console.WriteLine("===========================================================");

/*
    Notice that it isn't necessary to have the method defined before you call it. 
    This flexibility allows you to organize your code as you see fit. 
    It's common to define all methods at the end of a program. For example:
*/
int[] a = { 1, 2, 3, 4, 5 };

Console.WriteLine("Contents of Array:");
PrintArray();

void PrintArray()
{
    foreach (int x in a)
    {
        Console.Write($"{x} ");
    }
    Console.WriteLine();
}

Console.WriteLine("===========================================================");

// Method execution
Console.WriteLine("Before calling a method");
SayHi();
Console.WriteLine("After calling a method");

void SayHi()
{
    Console.WriteLine("Hi World!");
}

Console.WriteLine("===========================================================");

// Best practices
/*
    When choosing a method name, it's important to keep the name concise and make it clear what task the method performs. 
    Method names should be Pascal case and generally shouldn't start with digits. 
    Names for parameters should describe what kind of information the parameter represents. 
    Consider the following method signatures:
*/
// void ShowData(string a, int b, int c);
// void DisplayDate(string month, int day, int year); // Considered Best Practice

// Console.WriteLine("===========================================================");