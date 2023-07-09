//

Console.WriteLine("Введите любое целое число: ");
int userNumber = int.Parse(Console.ReadLine());

string userNumberStr = Math.Abs(userNumber).ToString();
if (userNumberStr.Length < 3)
{
    Console.WriteLine("В вашем числе нет третьей цифры");
}
else
{
    Console.WriteLine($"Третья цифра числа: {userNumberStr[2]}");
}