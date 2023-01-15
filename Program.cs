// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Welcome! To the largest number finder!");
Console.WriteLine("Please, insert first number:");
var firstInput = Console.ReadLine();
var first = default(int);
if (!int.TryParse(firstInput, out first))
{
    Console.WriteLine("Sorry, program could not handle inserted value... Bye!");
    return;
}

var secondInput = Console.ReadLine();
var second = default(int);
if (!int.TryParse(secondInput, out second))
{
    Console.WriteLine("Sorry, program could not handle inserted value... Bye!");
    return;
}

var max = Math.Max(first, second);
Console.WriteLine($"max = {max}");