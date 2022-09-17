// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[10];

void Fill(int[] arr)
{
    Random r = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = r.Next(100, 1000);
    }
}

void Show(int[] list)
{
    for (int i = 0; i < list.Length; i++)
    {
        Console.Write($"{list[i]} ");
    }
}

Fill(array);
Show(array);
Console.WriteLine();

int Count(int[] mas)
{
    int res = default;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] % 2 == 0)
        {
            res = res + 1;
        }
    }
    return res;
}

int result = Count(array);
Console.WriteLine(result);
