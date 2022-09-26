/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int[,] CreateMatrix(int rows, int col, int min, int max)
{
    int[,] arr = new int[rows, col];
    Random r = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = r.Next(min, max);
        }
    }
    return arr;
}

void ShowMatrix(int[,] matr)
{
    Console.WriteLine($"_____________________________");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],5} ");
        }
        Console.WriteLine($" ");
    }
    Console.WriteLine($"_____________________________");
}

int[,] SumOfMatrix(int[,] arr, int[,] matr)
{
    int[,] final = new int[arr.GetLength(0), arr.GetLength(1)];
    if (arr.GetLength(0) == matr.GetLength(0)
        && arr.GetLength(1) == matr.GetLength(1))
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                final[i,j] = arr[i,j] + matr[i,j];
            }
        }
    }
    else Console.WriteLine($"Чтобы сложить два массива, нужны массивы одинакового размера.");
    return final;
}


int[,] matrixOne = CreateMatrix(5, 5, 0, 10);
ShowMatrix(matrixOne);
int[,] matrixSec = CreateMatrix(5, 5, 0, 10);
ShowMatrix(matrixSec);
int [,] result = SumOfMatrix(matrixOne, matrixSec);
Console.WriteLine($"Result:  ");
ShowMatrix(result);

