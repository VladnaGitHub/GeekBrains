// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void PrintCubTab(int N)
{
    if (N < 1)
    {
        Console.WriteLine("Некорректно заданно число!!!");
    }
    else
    {
        Console.Write($"{N} -> ");
        for (int i = 1; i <= N; i++)
        {
            Console.Write($"{Math.Pow(i, 3)}; ");
        }
    }
}

// -----------

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
PrintCubTab(N);