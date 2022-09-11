// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Enter the number, please: ");
int num = Convert.ToInt32(Console.ReadLine());

int Sum (int n)
{
    if (n > 10)
    {
        int res = default;
        for (int i = 0; i < n; i++)
        {
            res = n % 10 + res;
            n = n / 10;
        }
        return res;
    }
    else return n;
}

int result = Sum(num);
Console.WriteLine(result);

