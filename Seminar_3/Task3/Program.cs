/* Методы (Функции, процедуры)
 [Возвращаемый тип] [Имя метода - глагол]([Параметры метода])
 {
    Код метода
}*/

void PrintIntervals(int n)
{
        switch (n)
        {
            case 1:
                Console.WriteLine("X > 0, y > 0");
                break;
            case 2:
                Console.WriteLine("X < 0, y > 0");
                break;
            case 3:
                Console.WriteLine("X < 0, y < 0");
                break;
            case 4:
                Console.WriteLine("X > 0, y < 0");
                break;
                default:
                Console.WriteLine("Error");
                break;
        }
    }

// -----------------------------------------

Console.WriteLine("Please, enter integer number of quater: ");
int Num = int.Parse(Console.ReadLine());

PrintIntervals(Num);