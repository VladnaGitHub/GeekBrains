// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int max;

Console.Write ("Введите первое число: ");
int a = int.Parse(Console.ReadLine ());

Console.Write ("Введите второе число: ");
int b = int.Parse(Console.ReadLine ());

Console.Write ("Введите третье число: ");
int c = int.Parse(Console.ReadLine ());

max = a;

if (b > max){
    max = b;
}
    else if (c > max){
    max = c;
}

Console.WriteLine ($"Максимальным числом является {max}");