// Задача 13 по 2-му семинару. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите любое целое число: ");
int userNumber = int.Parse(Console.ReadLine());

while (userNumber >= 1000)
{
    userNumber = userNumber / 10;
}
int thirdDigit = userNumber % 10;
Console.WriteLine($"Третья цифра числа {thirdDigit}");