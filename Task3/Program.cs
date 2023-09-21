// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.Write("Введите целое число: ");
if (!int.TryParse(Console.ReadLine(), out var number))
{
    Console.WriteLine("Некорректный ввод");
    Environment.Exit(0);
}

if (number % 2 == 0)
{
    Console.Write($"Да, число {number} является четным");
}
else
{
    Console.Write($"Нет, число {number} является нечетным");
}
