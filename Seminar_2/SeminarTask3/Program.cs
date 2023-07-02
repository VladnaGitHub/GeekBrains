// 

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a % b == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно, остаток {a % b}");
}