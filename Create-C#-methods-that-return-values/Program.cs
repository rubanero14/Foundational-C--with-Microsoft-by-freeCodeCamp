Console.WriteLine("===========================================================");
// Exercise - Understand return type syntax
// Use methods to calculate the total purchase price
double total = 0;
double minimumSpend = 30.00;

double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

total -= TotalMeetsMinimum() ? 5.00 : 0.00;

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
    // Calculate the discounted price of the item
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum()
{
    // Check if the total meets the minimum
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    // Format the double so only 2 decimal places are displayed
    return input.ToString().Substring(0, 5);
}
Console.WriteLine("===========================================================");
// Exercise - Return numbers from methods
double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd)
{
    int rate = 23500;
    return (int)(rate * usd);
}

double VndToUsd(int vnd)
{
    double rate = 23500;
    return vnd / rate;
}
Console.WriteLine("===========================================================");
// Exercise - Return strings from methods
// Create a method that returns a string
string input = "snake";

Console.WriteLine(input);
Console.WriteLine(ReverseWord(input));

string ReverseWord(string word)
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }
    return result;
}
Console.WriteLine("===========================================================");
// Create a method to reverse words in a sentence
input = "there are snakes at the zoo";

Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));

string ReverseSentence(string input)
{
    string result = "";
    string[] words = input.Split(" ");
    foreach (string word in words)
    {
        result += ReverseWord(word) + " ";
    }
    return result.Trim();
}
Console.WriteLine("===========================================================");
// Exercise - Return Booleans from methods
// Create a method that returns a Boolean
string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

Console.WriteLine("Is it a palindrome?");
foreach (string word in words)
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

// bool IsPalindrome(string word)
// {
//     int start = 0;
//     int end = word.Length - 1;

//     while (start < end)
//     {
//         if (word[start] != word[end])
//         {
//             return false;
//         }
//         start++;
//         end--;
//     }

//     return true;
// }

// My Own Solution
bool IsPalindrome(string word)
{
    char[] wordArr = word.ToCharArray();
    Array.Reverse(wordArr);
    string reversedWord = "";

    foreach (var character in wordArr)
    {
        reversedWord += character;
    }

    return word == reversedWord;
}
Console.WriteLine("===========================================================");
// Exercise - Return arrays from methods
// Find coins to make change
int[] TwoCoins(int[] coins, int target)
{
    for (int curr = 0; curr < coins.Length; curr++)
    {
        for (int next = curr + 1; next < coins.Length; next++)
        {
            if (coins[curr] + coins[next] == target)
            {
                return new int[] { curr, next };
            }

        }
    }
    return new int[0];
}

// Test your solution
int target = 60;
int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
int[] result = TwoCoins(coins, target);

if (result.Length == 0)
{
    Console.WriteLine("No two coins make change");
}
else
{
    Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
}
Console.WriteLine("===========================================================");
// Find multiple pairs of coins that make change
int[,] Two_Coins(int[] coins, int target)
{
    int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
    int count = 0;

    for (int curr = 0; curr < coins.Length; curr++)
    {
        for (int next = curr + 1; next < coins.Length; next++)
        {
            if (coins[curr] + coins[next] == target)
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
            if (count == result.GetLength(0))
            {
                return result;
            }
        }
    }
    return (count == 0) ? new int[0, 0] : result;
}

// Capture the new return array
int Target = 30;
int[] Coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
int[,] Result = Two_Coins(Coins, Target);

if (Result.Length == 0)
{
    Console.WriteLine("No two coins make change");
}
else
{
    Console.WriteLine("Change found at positions:");
    for (int i = 0; i < Result.GetLength(0); i++)
    {
        if (Result[i, 0] == -1)
        {
            break;
        }
        Console.WriteLine($"{Result[i, 0]},{Result[i, 1]}");
    }
}
Console.WriteLine("===========================================================");
// 

Console.WriteLine("===========================================================");