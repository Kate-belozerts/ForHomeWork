// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.WriteLine("Enter number: ");
int N = Convert.ToInt32(Console.ReadLine());

void Cube (int num)
{
    int count = 1;
    int result = 0;
    while(count <= num)
    {
        Console.Write($"{count} ");
        result = count * count * count;
        count++;
        Console.WriteLine(result);
    }
}
Cube(N);
