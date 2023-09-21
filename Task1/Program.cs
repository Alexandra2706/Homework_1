// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

try
{
    Console.Write("Введите первое целое число: ");
    int number_one = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе целое число: ");
    int number_two = Convert.ToInt32(Console.ReadLine());
    if (number_one > number_two)
    {
        Console.Write($"max = {number_one}");
    }
    else
    {
        Console.Write($"max = {number_two}");
    }

}
catch
{
    Console.WriteLine("Некорректный ввод");
}
