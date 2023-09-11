Console.WriteLine("====================================================");
// Exercise - Use parameters in methods
// Add parameters to methods
CountTo(5);

void CountTo(int max)
{

    for (int i = 0; i < max; i++)
    {
        string commaDelimiter = i == (max - 1) ? "" : ", ";
        Console.Write($@"${i}{commaDelimiter}");
    }
    Console.WriteLine();
}

Console.WriteLine("====================================================");
// Create a method with parameters
int[] schedule = { 800, 1200, 1600, 2000 };

DisplayAdjustedTimes(schedule, 6, -6);

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
{
    int diff = 0;
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
        Console.WriteLine("Invalid GMT");
    }
    else
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }

    for (int i = 0; i < times.Length; i++)
    {
        int newTime = ((times[i] + diff)) % 2400;
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
}

Console.WriteLine("====================================================");
// Exercise - Understand method scope
// Test variable scope
string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };

DisplayStudents(students);
DisplayStudents(new string[] { "Robert", "Vanya" });

void DisplayStudents(string[] students)
{
    int count = 0;
    foreach (string student in students)
    {
        count++;
        string commaDelimiter = count == students.Length ? "" : ", ";
        Console.Write($"{student}{commaDelimiter} ");
    }
    Console.WriteLine();
}

Console.WriteLine("====================================================");
// Another example

// Top-level Statemement or Global Variable
double pi = 3.14159;

PrintCircleInfo(12);
PrintCircleInfo(24);

void PrintCircleArea(int radius)
{
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircleCircumference(int radius)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}

void PrintCircleInfo(int radius)
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
    Console.WriteLine();
}

Console.WriteLine("====================================================");
// Exercise - Use value and reference type parameters

// Test pass by value
int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
Console.WriteLine($"global statement: {a} x {b} = {c}");

void Multiply(int a, int b, int c)
{
    c = a * b;
    Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
}

Console.WriteLine("====================================================");
// Test pass by reference
int[] array = { 1, 2, 3, 4, 5 };

PrintArray(array);
Clear(array);
PrintArray(array);

void PrintArray(int[] array)
{
    foreach (int a in array)
    {
        Console.Write($"{a} ");
    }
    Console.WriteLine();
}

void Clear(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0;
    }
}

Console.WriteLine("====================================================");
// Test with strings
string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(status, false);
Console.WriteLine($"End: {status}");

void SetHealth(string status, bool isHealthy)
{
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
}

Console.WriteLine("====================================================");
// Create an RSVP application
string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
string[] rsvps = new string[10];
int count = 0;

// RSVP("Rebecca", 1, "none", true);
// RSVP("Nadia", 2, "Nuts", true);
// RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);  // Use named arguments
// RSVP("Tony", 1, "Jackfruit", true);
// RSVP("Noor", 4, "none", false);
// RSVP("Jonte", 2, "Stone fruit", false);
// ShowRSVPs();

// Declare optional parameters
RSVP("Rebecca");
RSVP("Nadia", 2, "Nuts");
RSVP(name: "Linh", partySize: 2, inviteOnly: false);
RSVP("Tony", allergies: "Jackfruit");
RSVP("Noor", 4, inviteOnly: false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
{
    if (inviteOnly)
    {
        bool found = false;
        foreach (string guest in guestList)
        {
            if (guest.Equals(name))
            {
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
        }
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}
Console.WriteLine("====================================================");


