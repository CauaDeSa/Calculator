﻿float n1, n2, n3, n4;
char operation;

Console.Write("Type number 1: ");
n1 = int.Parse(Console.ReadLine());

//n2 = getNumber(2);
//n3 = getNumber(3);
//n3 = getNumber(4);

do {
    Console.Write("Type number 2 (cant be 0): ");
    n2 = int.Parse(Console.ReadLine());
} while (n2 == 0);

do
{
    Console.Write("Type number 3 (cant be 0): ");
    n3 = int.Parse(Console.ReadLine());
} while (n3 == 0);

do
{
    Console.Write("Type number 4 (cant be 0): ");
    n4 = int.Parse(Console.ReadLine());
} while (n4 == 0);

do
{
    Console.Write("Type operation ('x' or '/' or '+' or '-'):  ");
    operation = char.Parse(Console.ReadLine());
} while (operation != '+' && operation != '-' && operation != 'x' && operation != '/');

if (operation == '+')
    Console.WriteLine($"Summed: {n1 + n2 + n3 + n4}");
else if (operation == '-')
        Console.WriteLine($"Subtracted: {n1 - n2 -n3 - n4}");
    else if (operation == 'x')
            Console.WriteLine($"Multiplied: {n1 * n2 * n3 * n4}");
        else
            Console.WriteLine($"Divided: {n1 / n2 / n3 / n4}");

Console.ReadKey();

//float getNumber(int option) {
//    float result;
//    do
//    {
//        Console.Write($"Type number {option} (cant be 0): ");
//        result = int.Parse(Console.ReadLine());
//    } while (result == 0);
//    return result;
//}