// Exercise - Build code with methods
// Use methods to structure code

/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/
string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555.1.0.555", "255.5.6.255", "255.5.6.255.9" };

// System.Console.WriteLine("ValidateLength(ipv4Input): " + ValidateLength(ipv4Input));
// System.Console.WriteLine("ValidateZeroes(ipv4Input): " + ValidateZeroes(ipv4Input));
// System.Console.WriteLine("ValidateRange(ipv4Input): " + ValidateRange(ipv4Input));

foreach (var ipv4 in ipv4Input)
{
    if (ValidateLength(ipv4) && ValidateZeroes(ipv4) && ValidateRange(ipv4))
    {
        Console.WriteLine($"ip => {ipv4} is a valid IPv4 address");
    }
    else
    {
        Console.WriteLine($"ip => {ipv4} is an invalid IPv4 address");
    }
}

bool ValidateLength(string ip)
{
    return ip.Split('.').Length == 4 ? true : false;
};

bool ValidateZeroes(string ip)
{
    string[] ipComponent = ip.Split('.');
    bool isValid = false;
    foreach (var ipc in ipComponent)
    {
        if (!ipc.StartsWith("0"))
        {
            isValid = true;
        }
        else
        {
            return isValid = false;
        }
    }
    return isValid;
};

bool ValidateRange(string ip)
{
    string[] ipComponent = ip.Split('.');
    int ipComps;
    bool isValid = false;

    foreach (var ipc in ipComponent)
    {
        int.TryParse(ipc, out ipComps);
        if (ipComps > -1 && ipComps < 256)
        {
            isValid = true;
        }
        else
        {
            return isValid = false;
        }
    }
    return isValid;
}