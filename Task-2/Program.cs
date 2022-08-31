//Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.

Console.Clear();

Console.WriteLine("Введите первое число - ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число - ");
int numB = Convert.ToInt32(Console.ReadLine());

if(numA > numB)
{
    Console.WriteLine($"Число {numA} больше, чем {numB}");
}
else
{
    Console.WriteLine($"Число {numB} больше, чем {numA}");
}
