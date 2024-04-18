float n1, n2;
char operation;

Console.Write("Type number 1: ");
n1 = int.Parse(Console.ReadLine());

do {
    Console.Write("Type number 2 (cannot be 0): ");
    n2 = int.Parse(Console.ReadLine());
} while (n2 == 0);

do
{
    Console.Write("Type operation ('x' or '/' or '+' or '-'):  ");
    operation = char.Parse(Console.ReadLine());
} while (operation != '+' && operation != '-' && operation != 'x' && operation != '/');

if (operation == '+')
    Console.WriteLine($"Summed: {n1 + n2}");
else 
    if (operation == '-')
        Console.WriteLine($"Subtracted: {n1 - n2}");
    else
        if (operation == 'x')
            Console.WriteLine($"Multiplied: {n1 * n2}");
        else
            if (operation == '/')
                Console.WriteLine($"Divided: {n1 / n2}");

Console.ReadKey();