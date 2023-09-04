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

// Exercise - Complete a challenge to parse a string of orders, sort the orders and tag possible errors
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderIDs = orderStream.Split(",");

Array.Sort(orderIDs);

foreach (string order in orderIDs)
{
    if (order.Length == 4)
        Console.WriteLine(order);
    else
        Console.WriteLine(order + " - Error");
}

Console.WriteLine("===========================================================");

// Exercise - Investigate string formatting basics
string FIRST = "Hello";
string SECOND = "World";
string RESULT = string.Format("{0} {1}!", FIRST, SECOND);

// Composite Formatting
Console.WriteLine(RESULT);
Console.WriteLine("{1} {0}!", FIRST, SECOND);
Console.WriteLine("{0} {0} {0}!", FIRST, SECOND);

// String interpolation
Console.WriteLine($"{FIRST} {SECOND}!");
Console.WriteLine($"{SECOND} {FIRST}!");
Console.WriteLine($"{FIRST} {FIRST} {FIRST}!");

Console.WriteLine("===========================================================");

// Formatting currency
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($@"Price: {price:C} (Save {discount:C})");

Console.WriteLine("===========================================================");

// Formatting numbers
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
Console.WriteLine($"Measurement: {measurement:N4} units"); // N4 to show four decimal points, can be changed according to :N(n) numbers formatting

Console.WriteLine("===========================================================");

// Formatting percentages
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

Console.WriteLine("===========================================================");

// Combining formatting approaches

Console.WriteLine("===========================================================");

decimal PRICE = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (PRICE - salePrice), PRICE);
yourDiscount += $"A discount of {(PRICE - salePrice) / PRICE:P2}!"; //inserted
Console.WriteLine(yourDiscount);

Console.WriteLine("===========================================================");

// Exercise - Explore string interpolation
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"Shares: {productShares:N3} Product");
Console.WriteLine($"Sub Total: {subtotal:C}");
Console.WriteLine($"Tax: {taxPercentage:P2}");
Console.WriteLine($"Total Billed: {total:C}");

Console.WriteLine("===========================================================");

// Formatting strings by adding whitespace before or after
string input = "Pad this";
Console.WriteLine(input.PadLeft(12));

// Using overloaded method
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

Console.WriteLine("===========================================================");

// Working with padded strings
string paymentId = "769C";

// Add the payee name to the output
string payeeName = "Mr. Stephen Ortega";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);

Console.WriteLine(formattedLine);

Console.WriteLine("===========================================================");

// Add the payment amount to the output
string paymentAmount = "$5,000.00";
formattedLine += paymentAmount.PadLeft(10);
Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);

Console.WriteLine("===========================================================");

// Exercise - Complete a challenge to apply string interpolation to a form letter
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
string comparisonMessage = "";
comparisonMessage += $"Dear {customerName},\n";
comparisonMessage += $"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n\n";
comparisonMessage += $"Currently, you own {currentShares:N} shares at a return of {currentReturn:P2}\n\n";
comparisonMessage += $"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.\n\n";
comparisonMessage += $"Here's a quick comparison:\n";
comparisonMessage += $"{currentProduct.PadRight(20)}{currentReturn:P2}{"".PadRight(6)}{currentProfit:C}\n";
comparisonMessage += $"{newProduct.PadRight(20)}{newReturn:P2}{"".PadRight(6)}{newProfit:C}";
// Your logic here

Console.WriteLine(comparisonMessage);

Console.WriteLine("===========================================================");

// Exercise - Use the string's IndexOf() and Substring() helper methods
// Write code to find parenthesis pairs embedded in a string
string Message11 = "Find what is (inside the parentheses)";

int openingPosition = Message11.IndexOf('(');
int closingPosition = Message11.IndexOf(')');

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);

// Add code to retrieve the value between parenthesis
openingPosition += 1;
int length = closingPosition - openingPosition;
Console.WriteLine(Message11.Substring(openingPosition, length));

Console.WriteLine("===========================================================");

// Exercise 2 - Use the string's IndexOf() and Substring() helper methods
string Message12 = "What is the value <span>between the tags</span>?";

int OpeningPosition = Message12.IndexOf("<span>");
int ClosingPosition = Message12.IndexOf("</span>");

Console.WriteLine(OpeningPosition);
Console.WriteLine(ClosingPosition);

OpeningPosition += 6;
int Length = ClosingPosition - OpeningPosition;
Console.WriteLine(Message12.Substring(OpeningPosition, Length));

Console.WriteLine("===========================================================");

// Avoid magic values
string Message13 = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int Opening_Position = Message13.IndexOf(openSpan);
int Closing_Position = Message13.IndexOf(closeSpan);

Console.WriteLine(Opening_Position);
Console.WriteLine(Closing_Position);

Opening_Position += openSpan.Length;
int LENGTH = Closing_Position - Opening_Position;
Console.WriteLine(Message13.Substring(Opening_Position, LENGTH));

Console.WriteLine("===========================================================");

// Exercise - Use the string's IndexOfAny() and LastIndexOf() helper methods
// Retrieve the last occurrence of a sub string
string Message14 = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition1 = Message14.LastIndexOf('(');

openingPosition1 += 1;
int closingPosition1 = Message14.LastIndexOf(')');
int length1 = closingPosition1 - openingPosition1;
Console.WriteLine(Message14.Substring(openingPosition1, length1));

Console.WriteLine("===========================================================");

// Retrieve all instances of substrings inside parentheses
string Message15 = "(What if) there are (more than) one (set of parentheses)?";
/*
    This time, you update the message to have three sets of parentheses, and you write code to extract any text inside of the parentheses. 
    You're able to reuse portions of the previous work, but need to add a while statement to iterate through the string until 
    all sets of parentheses are discovered, extracted, and displayed.
*/
while (true)
{
    int openingPosition2 = Message15.IndexOf('(');
    if (openingPosition2 == -1) break;

    openingPosition2 += 1;
    int closingPosition2 = Message15.IndexOf(')');
    int length2 = closingPosition2 - openingPosition2;
    Console.WriteLine(Message15.Substring(openingPosition2, length2));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    Message15 = Message15.Substring(closingPosition2 + 1);
}

Console.WriteLine("===========================================================");

// Work with different types of symbol sets
string Message16 = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {Message16}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 6;
int openingPosition3 = Message16.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {Message16.Substring(openingPosition3)}");

openingPosition3 = Message16.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition: {Message16.Substring(openingPosition3)}");

Console.WriteLine("===========================================================");

// Now that you found an opening symbol, you need to find its matching closing symbol.
string Message17 = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters.
// Use openSymbols from previous exercise
// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
// next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition4 = 0;

while (true)
{
    int openingPosition4 = Message17.IndexOfAny(openSymbols, closingPosition4);

    if (openingPosition4 == -1) break;

    string currentSymbol = Message17.Substring(openingPosition4, 1);

    // Now find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition4 += 1;
    closingPosition4 = Message17.IndexOf(matchingSymbol, openingPosition4);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length4 = closingPosition4 - openingPosition4;
    Console.WriteLine(Message17.Substring(openingPosition4, length4));
}

Console.WriteLine("===========================================================");

// Exercise - Use the Remove() methods

// Use the Remove() method
// Remove characters in specific locations from a string
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20); // The Remove() method works similarly to the Substring() method. You supply a starting position and the length to remove those characters from the string.
Console.WriteLine(updatedData);

Console.WriteLine("===========================================================");

// Exercise - Use the Replace() methods
// Use the Replace() method
// Remove characters no matter where they appear in a string
string Message18 = "This--is--ex-amp-le--da-ta";
Message18 = Message18.Replace("--", " ");
Message18 = Message18.Replace("-", "");
Console.WriteLine(Message18);

Console.WriteLine("===========================================================");