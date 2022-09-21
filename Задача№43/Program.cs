/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, 
y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, 
k1 = 5,
b2 = 4, 
k2 = 9 -> (-0,5; -0,5)*/

Console.Clear();

Console.WriteLine($"Вычислим пересекаются ли две прямые по формуле: y = k1 * x + b1 - для каждой прямой! ");
string s1 = "Введите значение для первой прямой k и b: ";
string s2 = "Введите значение для второй прямой k и b: ";

Console.WriteLine(s1);
double k1 = Convert.ToDouble(Console.ReadLine()!);
double b1 = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine(s2);
double k2 = Convert.ToDouble(Console.ReadLine()!);
double b2 = Convert.ToDouble(Console.ReadLine()!);

double x = FindX(k1, b1, k2, b2);
CrossingPoint(k1, b1, k2, b2, x);

double FindX(double a1, double b1, double a2, double b2)
{
    double x = (b1 - b2) / (a2 - a1);
    return x;
}

void CrossingPoint(double n1, double m1, double n2, double m2, double x)
{
    double y1 = (n1 * x) + m1;
    double y2 = (n2 * x) + m2;
    if (y1 == y2) Console.WriteLine($" Точка пересечения прямой = ({x:f2}, {y2:f2})");
    if (n1 == n2 && m1 != m2) Console.WriteLine($" Прямые не пересекаются! ");
    if (n1 == n2 && m1 == m2) Console.WriteLine($" Точек пересечения бесконечное множество, т.к. все точки являются общими");
}
