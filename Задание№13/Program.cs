//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.WriteLine("Пожалуйста, введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100)
{
    Console.WriteLine("Третьей цифры нет!");
}
else if (num > 1000)
{
    while (num > 1000)
    {
        num = num / 10;        
    }
    int num1 = num % 10;
    Console.WriteLine($"Третяя цифра = {num1}");
}
else
{
    int num1 = num % 10;
    Console.WriteLine($"Третяя цифра = {num1}");
}

//Мое новое краткое решение спустя пару недель:
// Console.Clear();

// int number = new Random().Next(1, 10000);
// System.Console.WriteLine(number);

// string Third (int num)
// {
//     if (num < 100 && num > 0) System.Console.WriteLine("This number doesn't have third number");
//     if (num < 0) num = num * -1;
//     if (num >= 1000) num = num / 10;
//     if (num > 99 && num < 1000)
//     {
//         num = num % 10;
//     }
//     return ($"{num} - the third number");
// }

// string res = Third(number);
// System.Console.WriteLine(res);

//______________________________________________________________________________________________________________________
//Старое решение:

// if (num < 100)
//     {
//         Console.WriteLine("Третьей цифры нет!");
//     }
// while(num > 1000)
// {
//     num = num / 10;
// }
// if (num > 100 && num < 1000)
// {
//     int num1 = num % 10;
//     Console.WriteLine($"Третяя цифра = {num1}");
// }
