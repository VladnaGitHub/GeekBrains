// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double GetLength(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)));
}

Console.WriteLine("Введите координату x1: ");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z1: ");
double z1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату x2: ");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z2: ");
double z2 = double.Parse(Console.ReadLine());

Console.Write($"Расстояние между точками {GetLength(x1, y1, z1, x2, y2, z2) }");