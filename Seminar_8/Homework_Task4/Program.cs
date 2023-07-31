// Сформируйте трёхмерный массив из неповторяющихся двузначных
// чисел. Напишите программу, которая будет построчно выводить 
// массив, добавляя индексы каждого элемента.

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void PrintIntArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.WriteLine($" {i} {j} {z} = {array[i, j, z]}");
            }
        }
    }

}
int[,,] GetRandomIntArray(int XArray, int YArray, int ZArray)
{
    int[,,] array = new int[XArray, YArray, ZArray];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                bool CheckRepet = false;
                int temp = 0;
                while (CheckRepet == false)
                {
                    temp = new Random().Next(10, 100);
                    CheckRepet = CheckRepetArray(array, temp, i, j, z);

                }
                array[i, j, z] = temp;
            }
        }
    }
    return array;
}
bool CheckRepetArray(int[,,] array, int num, int ii, int jj, int zz)
{
    for (int i = 0; i < ii; i++)
    {
        for (int j = 0; j < jj; j++)
        {
            for (int z = 0; z < zz; z++)
            {

                if (num == array[i, j, z])
                {
                    return false;
                }
            }
        }
    }
    return true;
}
//----------------------------------
int XArray = Prompt("Введите длинну массива");
int YArray = Prompt("Введите ширину массива");
int ZArray = Prompt("Введите высоту массива");
if (XArray * YArray * ZArray < 90)
{
    int[,,] array = GetRandomIntArray(XArray, YArray, ZArray);
    PrintIntArray(array);
}
else
{
    Console.WriteLine("Такой массив создать нельзя");
}