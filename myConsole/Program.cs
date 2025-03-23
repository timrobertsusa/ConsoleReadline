// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

while (true)
{
    Console.WriteLine("Enter input (type 'exit' to quit):");
    string? input = Console.ReadLine();
    if (input?.ToLower() == "exit")
    {
        break;
    }
    Console.WriteLine($"You entered: {input}");
}
