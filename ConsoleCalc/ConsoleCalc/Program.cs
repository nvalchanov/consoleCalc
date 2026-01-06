Console.Write("A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("B: ");
int b = Convert.ToInt32(Console.ReadLine());

string op = "";
Console.Write("Operation (+, -, *, /): ");
op = Console.ReadLine();

if (op == "+")
{
    Console.WriteLine($"A + B = {a + b}");
}
else if (op == "-")
{
    Console.WriteLine($"A - B = {a - b}");
}
else if (op == "*")
{
    Console.WriteLine($"A * B = {a * b}");
}
else if (op == "/")
{
    if (b != 0)
    {
        Console.WriteLine($"A / B = {a / b}");
    }
    else
    {
        Console.WriteLine("Error: Division by zero");
    }
}

Console.ReadKey(true);