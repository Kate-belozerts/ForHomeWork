/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)*/

int[,,] matrix = NewMatrix3D(2, 2, 2);
Show(matrix);

int[,,] NewMatrix3D(int rows, int col, int depth)
{
    int[,,] matr = new int[rows, col, depth];
    int result = default;
    int num = 15;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                int number = RecRandom(num);
                num = number;
                result = CheckList(matr, num);
                if (result == 1)
                {
                    number = RecRandom(num);
                }
                else matr[i, j, k] = num;
            }
        }
    }
    return matr;
}

void Show(int[,,] matr)
{
    Console.WriteLine($"__________________________________________________");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]} ({i},{j},{k})   ");
            }
        }
        Console.WriteLine($" ");

    }
    Console.WriteLine($"__________________________________________________");
}

int RecRandom(int num)
{
    int n = new Random().Next(10, 100);
    if (n == num
    || n < 10 // условия проставила из-за ноля, периодически проявляющего в ответе, хотя это и не решает проблему((
    || n > 99) return RecRandom(num);
    else return n;
}

int CheckList(int[,,] arr, int num)
{
    int result = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (arr[i, j, k] == num) result = 1;
            }
        }
    }
    return result;
}






// Чужое решение:
// number = temp[i];
//  while (temp[i] == temp[j])
//         {
//           temp[i] = new Random().Next(10, 100);
//           j = 0;
//           number = temp[i];
//    }

