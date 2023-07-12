// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Please put 5 digits number: ");
int aByUser = int.Parse(Console.ReadLine());
string polindrom = Convert.ToString(aByUser);

if (polindrom.Length != 5)
{
    Console.WriteLine("You number is NOT 5 digits number");
}
else if (polindrom [0] == polindrom[4] && polindrom[1] == polindrom[3])
{
    Console.WriteLine($"You number: {polindrom} is the polindrom");
}
else
{
    Console.WriteLine("The number you put is not a polindrom");
}
