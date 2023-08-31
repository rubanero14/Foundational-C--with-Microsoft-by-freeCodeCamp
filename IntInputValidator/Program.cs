System.Console.WriteLine("==========================================");

// Code project 1 - write code that validates integer input
Console.WriteLine("Enter an integer value between 5 and 10");

int number = 0;

do
{
    string? userInput = Console.ReadLine();
    bool isNumber = int.TryParse(userInput, out number);

    if (!isNumber) 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
        continue;
    }
    else if (number < 5 || number > 10)
    {
        Console.WriteLine($@"You entered {number}. Please enter a number between 5 and 10.");
        continue;
    }
    else
    {
        Console.WriteLine($@"Your input value ({number}) has been accepted.");
        break;
    }
    
} while (number < 5 || number > 10);

System.Console.WriteLine("==========================================");

// Code project 2 - write code that validates string input

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

string? userInput1;

do
{
    userInput1 = Console.ReadLine();

    switch (userInput1)
    {
        case "Administrator":
        case "Manager":
        case "User":
            Console.WriteLine($@"Your input value ({userInput1}) has been accepted.");
            break;
        default:
            Console.WriteLine($"The role name that you entered, \"{userInput1}\" is not valid. Enter your role name (Administrator, Manager, or User)");
            break;
    }

} while (userInput1 != "Administrator" && userInput1 != "Manager" && userInput1 != "User");

System.Console.WriteLine("==========================================");

// Code project 3 - Write code in the code editor to implement code that achieves the project conditions

string[] myStrings = { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
string formattedSentence;

foreach (string myString in myStrings)
{   
    if(myString.Contains(".")){
        string[] nestedSentences = myString.Split(". ");
        foreach (string nestedSentence in nestedSentences)
        {
            formattedSentence = nestedSentence.Trim();
            Console.WriteLine($@"{nestedSentence}");
        }
    } 
    else
    {
        formattedSentence = myString.TrimStart().Replace('.', ' ');
        Console.WriteLine($@"{formattedSentence}"); 
    }
}

System.Console.WriteLine("==========================================");