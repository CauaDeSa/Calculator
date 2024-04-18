float n1, n2;

Console.Write("Type number 1: ");
n1 = int.Parse(Console.ReadLine());

Console.Write("Type number 2: ");
n2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Summed: {n1 + n2}");
Console.WriteLine($"Subtracted: {n1 - n2}");
Console.WriteLine($"Multiplied: {n1 * n2}");
Console.WriteLine($"Divided: {n1 / n2}");

Console.ReadKey();