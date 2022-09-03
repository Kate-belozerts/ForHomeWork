// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);

if(num < 1000 && num > 100)
{
    int num1 = num % 100;
    int num2 = num1 / 10;

    Console.WriteLine($"{num2}");
}

else
{
    Console.WriteLine("Число не является трехзначным");
}
