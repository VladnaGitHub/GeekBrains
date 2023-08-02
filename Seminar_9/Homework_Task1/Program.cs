// Дан одномерный массив целых чисел, элементом 
// которого, может быть либо 1, либо 0.
// Ваша задача вывести на экран максимальное 
// количество следующих друг за другом 1

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int[] GetDoubleArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}
void PrintIntArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
}
int SearchArray(int[] array)
{
    int Start = 0;
    int sum = 0;
    int TempSum = 0;
    int finish = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == 1)
        {
            finish = GetLengthArray(array, i);
            //Console.Write($"finish=   {finish}   ");

            TempSum = finish - i + 1;
            //Console.Write($"TempSum= {TempSum}  ");
            if (TempSum > sum)
            {
                sum = TempSum;
            }
            i = finish + 1;
        }
    }
    return sum;
}

int GetLengthArray(int[] array, int index)
{
    int i = 0;
    for (i = index; i < array.Length; i++)
    {
        if (array[i] == 0)
        {
            return i - 1;
        }
    }
    return i;
}
//----------------------------------------
int length = Prompt("Введите длину массива");
int[] array = GetDoubleArray(length);
PrintIntArray(array);
int sum = SearchArray(array);
Console.WriteLine($"Длина наибольшей последовательности {sum}");