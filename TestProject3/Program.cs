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