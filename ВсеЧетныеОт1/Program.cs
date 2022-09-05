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
