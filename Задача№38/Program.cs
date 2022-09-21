// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();
double[] array = new double[10];

Fill(array);
Show(array);
Console.WriteLine();

double result = Difference(array);
Console.WriteLine($"Разница между минимальным и максимальным элементом массива = {result} ");


void Fill(double[] arr1)
{
    Random r = new Random();
    for (int i = 0; i < arr1.Length; i++)
    {
        arr1[i] = r.NextDouble() * 100;
    }
}

void Show(double[] arr2)
{
    for (int i = 0; i < arr2.Length; i++)
    {
        Console.Write($"{arr2[i]:f2}   ");
    }
}

double Difference(double[] arr3)
{
    double min = arr3[0];
    double max = arr3[0];
    double res = default;
    for (int i = 0; i < arr3.Length; i++)
    {
        if(arr3[i] < min) min = arr3[i];
        if(arr3[i] > max) max = arr3[i];
    }
    return res = max - min;
}

