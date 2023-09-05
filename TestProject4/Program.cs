Console.WriteLine("===========================================================");

// Exercise: Complete a challenge to extract, replace, and remove data from an input string
// Extract, replace, and remove data from an input string
const string input = $@"
    <div>
        <h2>Widgets &trade;</h2>
        <span>5000</span>
    </div>
";

string quantity = "";
string output = "";

// Your work here
quantity = input.Remove(0, 61);
quantity = quantity.Remove(4);

output = input.Remove(45).Replace("\n", "").Replace(" ", "").Replace("<div>", "").Replace("&trade;", " &reg;");

Console.WriteLine(quantity);
Console.WriteLine(output);

Console.WriteLine("===========================================================");
