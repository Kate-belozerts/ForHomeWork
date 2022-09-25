// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = NewMatrix();
PrintMatrix(array);
FindAverage(array);

int[,] NewMatrix()
{
    int[,] matrix = new int[5, 5];
    Random r = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = r.Next(1, 55);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] arr)
{
    Console.WriteLine($"_____________________________________________");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],7}");
        }
        Console.WriteLine($" ");
    }
    Console.WriteLine($"_____________________________________________");

}

void FindAverage(int[,] matrix)
{
    double sum = default;
    double res = default;
    int j = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
        if (i == matrix.GetLength(0)-1 && j < matrix.GetLength(1))
        {
            res = sum / matrix.GetLength(0);
            Console.WriteLine($"Среднее арифметическое для столбца {j} = {res:f1}");
            j++;
            i = -1;
            sum = 0;
        }
    }
}

