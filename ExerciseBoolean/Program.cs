Random adminRandom = new Random();
int adminLevel = adminRandom.Next(54, 57);

Random managerRandom = new Random();
int managerLevel = managerRandom.Next(19, 22);

Random index = new Random();
int rolesIndex = index.Next(0, 3);

string[] roles = { "Admin", "Manager", "Others" };

if(roles[rolesIndex] == "Admin" && (adminLevel > 55))
{
    System.Console.WriteLine("Welcome, Super Admin user.");
}
else if (roles[rolesIndex] == "Admin" && (adminLevel <= 55))
{
    System.Console.WriteLine("Welcome, Admin user.");
}
else if (roles[rolesIndex] == "Manager" && (adminLevel >= 20))
{
    System.Console.WriteLine("Contact an Admin for access.");
}
else
{
    System.Console.WriteLine("You do not have sufficient privileges.");
}