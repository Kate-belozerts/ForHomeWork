// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[10];

void Fill (int[] arr1)
{
    Random r = new Random();
    for (int i = 0; i < arr1.Length; i++)
    {
        arr1[i] = r.Next(-20, 21);
    }
}

void Show (int[] arr2)
{
    for (int i = 0; i < arr2.Length; i++)
    {
        Console.Write($"{arr2[i]} ");
    }
}

Console.Clear();
Fill(array);
Show(array);

int SumArr (int[] arr3)
{
    int res = default;
    for (int i = 1; i < arr3.Length; i = i + 2)
    {
        res = res + arr3[i];
    }
    return res;
}

Console.WriteLine();
int result = SumArr(array);
Console.WriteLine($"Сумма всех элементов, стоящих на нечетных индексах = {result}");

