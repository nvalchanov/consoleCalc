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

// There are some comments from the CC-1-remove-comments branch
// More comments from the CC-1-remove-comments branch