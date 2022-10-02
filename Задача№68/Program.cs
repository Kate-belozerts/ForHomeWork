// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
//Ackermann function

double m = 2; // A (2,3)    
double n = 3;
double a = default;

if (m < 0 || n < 0) Console.WriteLine($"Необходимо ввести положительные числа");
else {a = Ackermann(m, n); Console.WriteLine($"{a}");}


double Ackermann(double m, double n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Ackermann(m - 1, 1);
    else if (m > 0 && n > 0) return Ackermann(m - 1, Ackermann(m, n - 1));
    else return n + 1;
}

