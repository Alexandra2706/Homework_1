// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите положительное целое число больше 1: ");
if (!int.TryParse(Console.ReadLine(), out var number))
{
    Console.WriteLine("Некорректный ввод");
    Environment.Exit(0);
}

if (number <= 1)
{
    Console.WriteLine("Число должно быть больше 1");
    Environment.Exit(0);
}

int counter = 2;
while (counter <= number)
{
    Console.Write($"{counter} ");
    counter += 2;
}