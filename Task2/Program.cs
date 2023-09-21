//  Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое целое число: ");
if (!int.TryParse(Console.ReadLine(), out var number_one))
{
    Console.WriteLine("Некорректный ввод");
    Environment.Exit(0);
}

Console.Write("Введите второе целое число: ");
if (!int.TryParse(Console.ReadLine(), out var number_two))
{
    Console.WriteLine("Некорректный ввод");
    Environment.Exit(0);
}

Console.Write("Введите третье целое число: ");
if (!int.TryParse(Console.ReadLine(), out var number_three))
{
    Console.WriteLine("Некорректный ввод");
    Environment.Exit(0);
}

int max = number_one;

if (max < number_two)
{
    max = number_two;
}

if (max < number_three)
{
    max = number_three;
}
Console.Write($"max = {max}");
