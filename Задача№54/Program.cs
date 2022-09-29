// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] matrix = CreateMatrix(0, 10, 4, 4);
ShowMatrix(matrix);
int[,] matrix2 = OrderedMatrix(matrix);
ShowMatrix(matrix2);


int[,] CreateMatrix(int min, int max, int size1, int size2)
{
    Random r = new Random(0);
    int[,] matrix = new int[size1, size2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = r.Next(min, max);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matr)
{
    Console.WriteLine($"______________________________");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],5} ");
        }
    }
    Console.WriteLine($" ");
    Console.WriteLine($"______________________________");
}

int[] TransformToArray(int[,] matr, int num) //num - номер строки, которую нужно преобразовать
{
    int[] arr = new int[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        arr[j] += matr[num, j];
        // Console.Write($"{arr[j],7} ");
    }
    return arr;
}

void ChangePlace(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length-1; j++)
        {
            if (arr[i] > arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
}

int[,] OrderedMatrix(int[,] matr)
{
    int[,] matrNew = new int[matr.GetLength(0), matr.GetLength(1)];
    int[] temp = new int[matr.GetLength(1)];
    int i = 0;
    int k = 0;

    for (int j = 0; j < matrNew.GetLength(1); j++)
    {
        temp = TransformToArray(matr, i);
        ChangePlace(temp);

        matrNew[k, j] += temp[j];

        if (j == matrNew.GetLength(1) - 1) { k++; j = -1; i++; }
        if (k == matrNew.GetLength(0)) break;
        if (i == matr.GetLength(1)) break;
    }
    return matrNew;
}




//TODO (Позже подумаю, возможно ли что-нибудь с ним сделать)) )
// void ChangePlace(int[] arr)
// {
//     int k = 0;
//     for (int i = arr.Length - 1; i > k; i--)
//     {
//         if (arr[i] > arr[k])
//         {
//             int temp = arr[k];
//             arr[k] = arr[i];
//             arr[i] = temp;
//             k++;
//         }
//         if (i == k)
//         {
//             k++;
//             i = arr.Length - 1;
//         }
//         if (k == arr.Length) break; 
//     }
// }