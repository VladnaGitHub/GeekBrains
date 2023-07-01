// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine ("Введите первое число: ");
int a = int.Parse(Console.ReadLine ());

Console.WriteLine ("Введите второе число: ");
int b = int.Parse(Console.ReadLine ());

if (a > b){
    Console.WriteLine ($"Наибольшее число: {a} ");
    Console.WriteLine ($"Наименьшее число: {b} ");
}
else {
    Console.WriteLine ($"Наибольшее число: {b} ");
    Console.WriteLine ($"Наименьшее число: {a} ");
}