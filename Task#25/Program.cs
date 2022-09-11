// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Enter two numbers, please: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int Square(int n1, int n2)
{
    int res = n1;
    for (int i = 1; i < n2; i++)
    res = res * n1;
    return res;
}

int result = Square(a, b);
Console.WriteLine(result);

