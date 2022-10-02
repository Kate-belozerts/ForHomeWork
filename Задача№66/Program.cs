// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = 1;
int n = 15;
int sum = SumBetween(n, m);
Console.WriteLine($"{sum}");

int SumBetween(int n, int m)
{
    if (m > n) return m + SumBetween(n, m - 1);
    if (n == m) return m;
    else return n + SumBetween(n - 1, m);
}

