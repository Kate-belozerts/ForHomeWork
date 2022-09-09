// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.WriteLine("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());

string Pali(int n)
{
    int count = 0;
    int i = 0;
    int y = 0;
    int x = 0;
    
    count = n % 10;
    i = n / 10000;
    if (count == i)
    {
        y = n % 10000;
        x = y / 10;
        count = x % 10;
        i = x / 100;
        if (count == i) return "Yes";
        else return "No";
    }
    else return "No";
}



if (num > 9999 && num < 100000)
{
    string result = Pali(num);
    Console.WriteLine(result);
}
else 
{
    Console.WriteLine("Enter another number, please");
}

