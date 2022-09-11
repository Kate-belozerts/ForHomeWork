// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
int[] array = new int [8];

void Fill(int[] arr)
{
    int length = 8;
    Random fillNum = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = fillNum.Next(0, 999);
    }
}

void Print(int[] massiv)
{
    int length1 = massiv.Length;
    for (int i = 0; i < length1; i++)
    {
        if (i == 0) Console.Write("[");
        else Console.Write($"{massiv[i]}, ");
        if (i == length1-1) Console.Write($"{massiv[i]}]");
    }
}

Fill(array);
Print(array);
// Console.WriteLine("[{0}]", string.Join(", ", array));

