// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
int[] size = FindSize();
int m = size[0];
int n = size[1];

double[,] array = FillArray(m, n);
PrintArr(array);

int[] FindSize()
{
    Console.WriteLine($"Введите размер массива, пожалуйста (кол-во строк и столбцов): ");
    int n1 = Convert.ToInt32(Console.ReadLine());
    int n2 = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[]{n1, n2};
    return arr;
}

double[,] FillArray (int rows, int columns)
{
    double[,] matrix = new double [rows, columns];
    Random r = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = r. Next(-50, 50);
        }
    }
    return matrix;
}

void PrintArr(double[,] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j], 5} ");   //цифра 5 делает 5 пробелов, чтобы выровнить столбцы
        }
        Console.WriteLine($" ");
    }
}

