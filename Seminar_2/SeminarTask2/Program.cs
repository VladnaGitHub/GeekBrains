// Напишите программу, которая принимает на вход трёхзначное число и на выходе удаляет вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int randomNumber = new Random().Next(100, 1000);
Console.WriteLine(randomNumber);

int result = ((randomNumber/100)*10)+(randomNumber % 10);
Console.WriteLine(result);

