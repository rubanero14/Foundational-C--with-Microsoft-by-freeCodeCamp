/* 
This code uses a names array and corresponding methods to display
greeting messages
*/

string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };
int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
string messageText = "";

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(i);
}

foreach (string name in names)
{
    if (name == "Sophia")
        messageText = SophiaMessage();
    else if (name == "Andrew")
        messageText = AndrewMessage();
    else if (name == "AllGreetings")
        messageText = SophiaMessage();
    messageText = messageText + "\n\r" + AndrewMessage();

    Console.WriteLine(messageText + "\n\r");
}

bool pauseCode = true;
while (pauseCode == true) ;

static string SophiaMessage()
{
    return "Hello, my name is Sophia.";
}

static string AndrewMessage()
{
    return "Hi, my name is Andrew. Good to meet you.";
}