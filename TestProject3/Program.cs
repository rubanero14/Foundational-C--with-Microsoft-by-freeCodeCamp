// This will throw exception, ie: error CS0029: Cannot implicitly convert type 'string' to 'int', 
// int first = 2;
// string second = "4";
// int result = first + second;
// Console.WriteLine(result);
Console.WriteLine("===========================================================");

//String concatenation
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

Console.WriteLine("===========================================================");
// Widening conversion - conversion without data loss
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

Console.WriteLine("===========================================================");
// narrowing conversion - conversion wuth data loss

decimal myDecimal1 = 3.14m;
Console.WriteLine($"decimal: {myDecimal1}");

int myInt1 = (int)myDecimal1;
Console.WriteLine($"int: {myInt1}");

Console.WriteLine("===========================================================");

decimal myDecimal2 = 1.23456789m;
float myFloat = (float)myDecimal2;

Console.WriteLine($"Decimal: {myDecimal2}");
Console.WriteLine($"Float  : {myFloat}");

Console.WriteLine("===========================================================");

// Use a helper method on the variable :- Use .ToString() method to for conversion from int to string data type
int first1 = 5;
int second1 = 7;
string message = first1.ToString() + second1.ToString();
Console.WriteLine(message);

Console.WriteLine("===========================================================");

// Use a helper method on the data type :- Use .Parse() helper method to for conversion from string into the given data type. In this case its int type
string first2 = "5";
string second2 = "7";
int sum = int.Parse(first2) + int.Parse(second2);
Console.WriteLine(sum);

Console.WriteLine("===========================================================");

// Use the Convert class' methods :- Convert a string to a int using the Convert class
string value1 = "5";
string value2 = "7";
int Result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(Result);

Console.WriteLine("===========================================================");

// The following example demonstrates what happens when you attempt to cast a decimal into an int (a narrowing conversion) versus using the Convert.ToInt32() method to convert the same decimal into an int.
int Value = (int)1.5m; // casting truncates
Console.WriteLine(Value);

int Value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(Value2);

int Value3 = Convert.ToInt32(1.4999m); // converting rounds down
Console.WriteLine(Value3);

Console.WriteLine("===========================================================");

// Exercise - Examine the TryParse() method - This breaks and outputs System.FormatException: 'Input string was not in a correct format.'

// string name = "Bob";
// Console.WriteLine(int.Parse(name));

Console.WriteLine("===========================================================");

// Use TryParse()
// Using TryParse() a string into an int
string strNum = "102";
int output = 0;
if (int.TryParse(strNum, out output))
{
    Console.WriteLine($"Measurement: {output}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

if (output > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + output}");

Console.WriteLine("===========================================================");
// Exercise
string[] values4 = { "12.3", "45", "ABC", "11", "DEF" };
string words = "";
decimal nums = 0m;
decimal prevNum = 0m;

foreach (var value in values4)
{
    if (decimal.TryParse(value, out nums))
    {
        nums += prevNum;
        prevNum = nums;
    }
    else
    {
        words += value;
    }
}

Console.WriteLine($@"Message: {words}");
Console.WriteLine($@"Total: {prevNum}");

Console.WriteLine("===========================================================");

int v1 = 12;
decimal v2 = 6.2m;
float v3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
int Result1 = (int)v1 / (int)v2;
Console.WriteLine($"Divide value1 by value2, display the result as an int: {Result1}");

// Your code here to set result2
decimal Result2 = (decimal)v2 / (decimal)v3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {Result2}");

// Your code here to set result3
float Result3 = (float)v3 / (float)v1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {Result3}");

Console.WriteLine("===========================================================");

// Exercise - Discover Sort() and Reverse()
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Before Sorted...");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine();
Array.Sort(pallets);
Console.WriteLine("After Sorted...");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine();
Console.WriteLine("After Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("===========================================================");

// Exercise - Explore Clear() and Resize()
Console.WriteLine("");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("===========================================================");

// Access the value of a cleared element
Console.WriteLine($"Before: {pallets[3].ToLower()}");
Array.Clear(pallets, 0, 4);
// Fix the null execption
if (pallets[3] != null)
    Console.WriteLine($"After: {pallets[3].ToLower()}"); // Will throw an null exception due to value cleared and assigned to null

Console.WriteLine("===========================================================");

// Resize the array to add more elements
Console.WriteLine();
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("===========================================================");

// Resize the array to remove elements
Console.WriteLine();
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("===========================================================");

// Remove null values
string[] pallets1 = { "B14", "A11", "B12", "A13" };
string[] pallets2 = new string[4];

Array.Clear(pallets1, 0, 2);

foreach (var item in pallets1)
{
    if (item != null)
    {
        Console.WriteLine(item);
        // Using the .Append() method and converting it back to a string array, copying into new array
        pallets2 = pallets2.Append(item).ToArray();
    }
}

foreach (string item in pallets2)
{
    if (item != null)
        Console.WriteLine(item);
}

Console.WriteLine("===========================================================");

// Exercise - Discover Split() and Join()
string strV1 = "abc123";
char[] valueArray = strV1.ToCharArray(); // Use the ToCharArray() to reverse a string
Console.WriteLine(valueArray);
Array.Reverse(valueArray);
string result3 = new string(valueArray);
Console.WriteLine(result3);

// string result4 = new string(valueArray);
string result4 = String.Join(",", valueArray);
Console.WriteLine(result4);

Console.WriteLine("===========================================================");

// Split() the comma-separated-value string into an array of strings
string[] items = result4.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}

Console.WriteLine("===========================================================");

// Exercise - Complete a challenge to reverse words in a sentence
string pangram1 = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] Message10 = pangram1.Split(' ');

//Step 2
string[] newMessage = new string[Message10.Length];

// Step 3
for (int i = 0; i < Message10.Length; i++)
{
    char[] letters = Message10[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

//Step 4
string result5 = String.Join(" ", newMessage);
Console.WriteLine(result5);

Console.WriteLine("===========================================================");