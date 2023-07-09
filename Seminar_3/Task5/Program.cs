// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N

void PrintSgrTab(int N)
{
    if (N < 1)
    {
        Console.WriteLine("There are no valid numbers");
    }
    else
    {
        Console.Write($"{N} -> ");
        for (int i = 1; i <= N; i++)
        {
            Console.Write($"{Math.Pow(i, 2)} ");
        }
    }
}

// -----------

Console.Write("Please, n: ");
int N = int.Parse(Console.ReadLine());
PrintSgrTab(N);