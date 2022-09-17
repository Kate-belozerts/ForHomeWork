// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.WriteLine("Пожалуйста, введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 5 && num > 0 || num == 5)
    {
        Console.WriteLine("Будний день");
    }
else if(num < 8 && num > 5)
    {
        Console.WriteLine("Этот день - выходной!");        
    } 
else 
{
    Console.WriteLine("Такого дня недели не существует :)");
}

//Мое новое краткое решение спустя пару недель:
// Console.Clear();

// int day = Convert.ToInt32(Console.ReadLine()!);

// string Week(int n)
// {
//     if (n < 6 && n > 0) return "Not a weekend";
//     if (n < 8 && n > 5) return "Holiday!!!";
//     return "This day doesn't exist((";
// }

// System.Console.WriteLine(Week(day));



//____________________________________________________________________________________________________________________
//Старый вариант:

// while(num > 0 && num < 8)
// {
//     if (num < 5 || num == 5)
//     {
//         Console.WriteLine("Будний день");
//     }
//     else
//     {
//         Console.WriteLine("Этот день - выходной!");
//     }
//     break;
// }

// if (num < 1 || num > 7)
// {
//     Console.WriteLine("Такого дня недели не существует :)");
// }
