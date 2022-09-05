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
