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
string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555.1.0.555", "255.5.6.255", "255.5.6.255.9", "555..0.555", "255...255" };

foreach (var ipv4 in ipv4Input)
{
    // System.Console.WriteLine("ValidateLength(ipv4Input): " + ValidateLength(ipv4));
    // System.Console.WriteLine("ValidateZeroes(ipv4Input): " + ValidateZeroes(ipv4));
    // System.Console.WriteLine("ValidateRange(ipv4Input): " + ValidateRange(ipv4));

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
    return ip.Split('.', StringSplitOptions.RemoveEmptyEntries).Length == 4 ? true : false;
};

bool ValidateZeroes(string ip)
{
    string[] ipComponent = ip.Split('.', StringSplitOptions.RemoveEmptyEntries); // Using StringSplitOptions.RemoveEmptyEntries omits empty entries from the address array and prevent attempts to parse empty strings.
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
    string[] ipComponent = ip.Split('.', StringSplitOptions.RemoveEmptyEntries); // Using StringSplitOptions.RemoveEmptyEntries omits empty entries from the address array and prevent attempts to parse empty strings.
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