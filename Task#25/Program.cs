// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// По задаче 25 решение рабочее. Не учтено возведение в степень <= 0, нужно или реализовать эту возможность или ограничить ввод натуральными числами. Программа не должна выдавать некорректных результатов.


Console.Clear();
Console.WriteLine("Enter two numbers, please: ");
double a = Convert.ToDouble(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

void Square(double n1, int n2)
{
    if (n2 == 0 && n1 > 0) Console.WriteLine($"1");
    if (n2 == 0 && n1 < 0) Console.WriteLine($"-1");
    if (n1 > 0 && n2 > 0)
    {
        double res = n1;
        for (int i = 1; i < n2; i++)
            res = res * n1;
        Console.WriteLine(res);
    }
    if (n1 < 0 && n2 > 0)
    {
        double res = n1;
        for (int i = 1; i < n2; i++)
            res = res * n1;
        Console.WriteLine($"{res * -1}");
    }
    if (n1 > 0 && n2 < 0)
    {
        double res = n1;
        n2 = n2 * -1;
        for (int i = 1; i < n2; i++)
            res = res * n1;
        Console.WriteLine($"{res = 1 / res}");
    }
    if (n1 < 0 && n2 < 0)
    {
        double res = n1;
        n1 = n1 * -1;
        n2 = n2 * -1;
        for (int i = 1; i < n2; i++)
            res = res * n1;
            res = res * -1;
            res = 1 / (1 / (1 / res));
        Console.WriteLine($"{res * -1} ");
    }
}

Square(a, b);


// Console.Clear();
// Console.WriteLine("Enter two numbers, please: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// void Square(int n1, int n2)
// {
//     if (n2 == 0 && n1 > 0) Console.WriteLine($"1");
//     if (n2 == 0 && n1 < 0) Console.WriteLine($"-1");
//     if (n1 > 0 && n2 > 0)
//     {
//         int res = n1;
//         for (int i = 1; i < n2; i++)
//         res = res * n1;
//         Console.WriteLine(res);
//     }
//     if (n1 < 0 && n2 > 0)
//     {
//         int res = n1;
//         for (int i = 1; i < n2; i++)
//         res = res * n1;
//         Console.WriteLine($"{res * -1}");        
//     }
//     if (n1 > 0 && n2 < 0)
//     {
//         int res = n1;
//         for (int i = 1; i < n2; i++)
//         res = res * n1;
//         Console.WriteLine(Convert.ToDouble(res = 1 / res));
//     }
// }

// Square(a, b);

