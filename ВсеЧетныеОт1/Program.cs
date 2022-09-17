// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.WriteLine("Введите другое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 0;

while (count < num)
{
    if (num % 2 == 1)
    {
        num = (num - 1);
    }
    count = (count + 2);
    Console.Write($"{count}, ");
}

//Мое новое краткое решение спустя пару недель:
// Console.Clear();
// int a = int.Parse(Console.ReadLine()!);
// int otr = a;

// if (a < 0) a = a * -1;
// if (a % 2 == 1) a = a-1;
// if(a % 2 == 0)
// {
//     for (int i = 2; i <= a; i = i + 2)
//     {
//         if (otr < 0) Console.Write($"-{i}, ");
//         if (otr > 0) Console.Write($"{i}, ");

//     }
// }



//Старое решение:

// int count = 0;

// while (count < num)
// {
//      if(num % 2 == 0)
//      {
//      count = (count + 2);
//      }

//      else
//      {
//      count = (count + 2);
//      num = (num-1);
//      }
//  Console.Write($"{count}, ");
// }
