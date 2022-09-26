/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] CreateMatrix(int rows, int col, int min, int max)
{
    Random r = new Random();
    int[,] matr = new int[rows, col];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = r.Next(min, max + 1);
        }
    }
    return matr;
}

void ShowMatrix(int[,] matr)
{
    Console.WriteLine($"_____________________________________");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],5} ");
        }
        Console.WriteLine($" ");
    }
    Console.WriteLine($"_____________________________________");
}

void Calculate(int[,] matr)
{
    int[] temp = new int[matr.GetLength(0)];
    int sum = default;
    int i = 0;
    int k = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        sum += matr[i, j];
        if (j == matr.GetLength(1) - 1 
        && i < matr.GetLength(0) 
        && k < matr.GetLength(0))
        {
            //++k;
            temp[k] += sum;
            k++;
            i++;
            sum = 0;
            j = -1;
        }
        if (i == matr.GetLength(1)-1) break;
    }
    FindMin(temp);
}

void FindMin(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    Console.WriteLine($" Сумма строки = {min} ");
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j] == min) Console.Write($" Строка номер {j} с наименьшей суммой элементов!");
    }
}



int[,] matrix = CreateMatrix(4, 5, 0, 50);
ShowMatrix(matrix);
Calculate(matrix);

