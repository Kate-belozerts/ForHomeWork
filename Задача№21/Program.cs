// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Введите последовательно координаты первой точки: x, y, z  ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите последовательно координаты второй точки: x, y, z  ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

// формула ab = √(x2 - x1)2 + (y2 - y1)2
double Dist (int xa, int ya, int za, int xb, int yb, int zb)
{
    double result = (xb-xa) * (xb-xa) + (yb-ya) * (yb-ya) + (zb-za) * (zb-za);
    return Math.Round(Math.Sqrt(result), 2, MidpointRounding.ToZero);
}

Console.WriteLine(Dist (x1, y1, z1, x2, y2,z2));

