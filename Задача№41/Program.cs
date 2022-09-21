// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3 (здесь должно быть 4:) )

int[] EnterNum()
{
    Console.Clear();
    System.Console.WriteLine($"Введите количество чисел(массива) и нажмите enter: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] num = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите целое число, пожалуйста (для завершения ввода нажмите enter): ");
        num[i] = Convert.ToInt32(Console.ReadLine())!;
    }
    return num;
}

int CountNum(int[] arr)
{
    int result = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) result = result + 1;
    }
    return result;
}

int[] numbers = EnterNum();
Console.Clear();
int positiveNum = CountNum(numbers);
Console.WriteLine($"Количество чисел больше ноля = {positiveNum} ");
