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

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
    // display internal email addresses
    createEmail(firstName: corporate[i, 0], lastName: corporate[i, 1]);
}

for (int i = 0; i < external.GetLength(0); i++)
{
    // display external email addresses
    createEmail(firstName: external[i, 0], lastName: external[i, 1], domainPostFix: externalDomain);
}

void createEmail(string firstName, string lastName, string domainPostFix = "contoso.com")
{
    // display internal email addresses
    Console.WriteLine((firstName.Substring(0, 2) + lastName + '@' + domainPostFix).ToLower());
}

Console.WriteLine("====================================================");
