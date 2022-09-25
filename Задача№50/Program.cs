/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int[] size = FindSize();
int n = size[0];
int m = size[1];
int[,] array = FillMatrix(n, m);
PrintMatrix(array);
FindNumber(array);
FindIndex(array);


int[] FindSize()
{
    Console.Clear();
    Console.WriteLine($"Введите, пожалуйста, размер массива (кол-во строк и столбцов): ");
    int n1 = Convert.ToInt32(Console.ReadLine());
    int n2 = Convert.ToInt32(Console.ReadLine());
    int[] size = new int[] { n1, n2 };
    return size;
}

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.WriteLine($"Введите число для заполнения массива: ");
            matrix[i, j] = Convert.ToInt32(Console.ReadLine()!);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],7}");
        }
        Console.WriteLine($" ");
    }
}

void FindNumber(int[,] arr)
{
    Console.WriteLine($"________________________________");
    Console.WriteLine($"Какое число вы хотели бы найти?");
    int num = Convert.ToInt32(Console.ReadLine());
    bool find = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (num == arr[i, j]) find = true;
        }
    }
    if (find == true) Console.WriteLine($"Есть такое! :) ");
    else Console.WriteLine($"К сожалению, такого элемента в нашем массиве нет :( ");
}

void FindIndex(int[,] arr)
{
    Console.WriteLine($"Какую позицию Вы хотели бы найти? (Введите поочередно номер строки, затем столбца)");
    int n1 = Convert.ToInt32(Console.ReadLine());
    int n2 = Convert.ToInt32(Console.ReadLine());
    bool find = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == n1 && j == n2)
            {
                find = true;
                Console.WriteLine($" На позиции [{n1}, {n2}] находится элемент {arr[i, j]} ");
            }
        }
    }
    if (find == false) Console.WriteLine($"Такого индекса в массиве нет :( ");
}

