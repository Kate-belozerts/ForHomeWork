// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22


Console.Clear();

Console.WriteLine("Enter the number: "); 
int numA  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: "); 
int numB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number: "); 
int numC = Convert.ToInt32(Console.ReadLine());

int max = numA;

if(numB > max)
{
    max = numB;
}
if(numC > max)
{
    max = numC;
}
Console.WriteLine($"Максимальное число: {max}");

//Мое решение спустя пару недель: (тоже самое, но кратко)
// Console.Clear();
// int a = int.Parse(Console.ReadLine()!);
// int b = int.Parse(Console.ReadLine()!);
// int c = int.Parse(Console.ReadLine()!);

// int max = a;
// if (b > max) max = b;
// if (c > max) max = c; 

// Console.Write($"{max} - max");
