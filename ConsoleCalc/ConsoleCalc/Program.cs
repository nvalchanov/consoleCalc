Console.Write("A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Operation (+, -, *, /): ");
string operation = Console.ReadLine();

if(operation == "/")
{
    Console.WriteLine($"Result: {a / b}");
}
else if(operation == "+")
{
    Console.WriteLine($"Result: {a + b}");
}
else if(operation == "*")
{
    Console.WriteLine($"Result: {a * b}");
}
else if(operation == "-")
{
    Console.WriteLine($"Result: {a - b}");
}
else
{
    Console.WriteLine("Error: Invalid operation");
}

// Това беше променено в CA-2 клона с първи commit
// Това беше променено в CA-2 клона с втори commit
