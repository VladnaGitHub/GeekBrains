﻿// Напишите программу, которая заполнит спирально массив 4 на 4. 

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
void PrintIntArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] GetSpiralArray(int countColum, int countRow)
{
    int[,] array = new int[countRow, countColum];
    int indent = 0;
    int CheckIndent = 0;
    if (countRow < countColum) //определяем длинную сторону 
    {
        CheckIndent = countRow;
    }
    else
    {
        CheckIndent = countColum;
    }
    int index = 0;
    while (indent < CheckIndent / 2)
    {
        array = GetRoundSpiral(array, indent, index);
        index = index + (countColum - indent * 2) * 2 + (countRow - indent * 2) * 2 - 4;
        indent++;
    }
    return array;

}
int[,] GetRoundSpiral(int[,] array, int indent, int index)
{
    for (int i = indent; i < array.GetLength(1) - indent; i++, index++) // верхняя горизонталь
    {
        array[indent, i] = index;
    }
    for (int i = indent + 1; i < array.GetLength(0) - indent; i++, index++) //левая вертикаль
    {
        array[i, array.GetLength(1) - 1 - indent] = index;
    }
    for (int i = array.GetLength(1) - 2 - indent; i > indent; i--, index++) // нижняя горизонталь
    {
        array[array.GetLength(0) - 1 - indent, i] = index;
    }
    for (int i = array.GetLength(0) - 1 - indent; i > indent; i--, index++) // правая вертикаль
    {
        array[i, indent] = index;
    }
    //PrintIntArray(array);
    return array;
}


//-----------------
int LengthArray = Prompt("Введите ширину массива");
int HigthhArray = Prompt("Введите высоту массива");
int[,] array = GetSpiralArray(LengthArray, HigthhArray);
PrintIntArray(array);