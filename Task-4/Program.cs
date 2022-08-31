//Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.Clear();

Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int C = Convert.ToInt32(Console.ReadLine()); 
int max = A;

if(B>A)
{
    max = B;
}
if(C>B)
{
    max = C;
}
if(A>C)
{
    max = A;
}

Console.WriteLine($"Максимальное число = {max}");

