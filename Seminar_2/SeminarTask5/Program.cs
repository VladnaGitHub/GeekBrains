// Напишите прогармму, которая на вход принимает два числа и проверяет, является ли одно число квадратом другого.

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if ((a * a == b) || (b * b == a))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}