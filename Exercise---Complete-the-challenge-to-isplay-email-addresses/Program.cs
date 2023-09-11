Console.WriteLine("====================================================");
// Exercise - Complete the challenge to display email addresses
string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

// display internal email addresses
createEmail(names: corporate);

// display external email addresses
createEmail(names: external, domainPostFix: "hayworth.com");

void createEmail(string[,] names, string domainPostFix = "contoso.com")
{
    // display internal email addresses
    for (int i = 0; i < names.GetLength(0); i++)
    {
        Console.WriteLine((names[i, 0].Substring(0, 2) + names[i, 1] + '@' + domainPostFix).ToLower());
    }
}

Console.WriteLine("====================================================");
