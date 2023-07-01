// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа

Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine ());
int b;

if (a > 99 && a < 1000)
{
    b = a % 10;

    Console.WriteLine($"Последняя цифра числа = {b}");
}
else Console.WriteLine("Число неверное");