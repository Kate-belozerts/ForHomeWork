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
