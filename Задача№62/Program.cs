// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] matrix = NewArray();
PrintArray(matrix);
SpiralMatrix(matrix);


int[,] NewArray()
{
    int[,] arr = new int[4, 4];
    Random r = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = r.Next(10, 90);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    Console.WriteLine($"  ");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],5} ");
        }
    }
    Console.WriteLine($" ");
}

void SpiralMatrix(int[,] arr)
{
    bool sq = false;
    if (arr.GetLength(0) != arr.GetLength(1)) sq = true;
    int size = arr.GetLength(0);
    int x = 0;
    int y = 0;
    int count = 1;
    if (!sq)
    {
        while (size > 0)
        {
            for (int i = y; i <= y + size - 1; i++)
            {
                arr[x, i] = count++;
            }
            for (int j = x + 1; j <= x + size - 1; j++)
            {
                arr[j, y + size - 1] = count++;
            }
            for (int i = y + size - 2; i >= y; i--)
            {
                arr[x + size - 1, i] = count++;
            }
            for (int j = x + size - 2; j >= x + 1; j--)
            {
                arr[j, y] = count++;
            }
            x = x + 1;
            y = y + 1;
            size = size - 2;
        }
        Console.WriteLine($"Result: ");
        PrintArray(arr);
    }
    else Console.WriteLine($"Необходим квадратный массив");
}

