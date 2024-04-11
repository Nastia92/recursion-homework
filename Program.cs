Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void Main()
{
    System.Console.WriteLine("Введите значение m: ");
    int m = Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine("Введите значение n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    NumbersInRange(m, n);
}

void NumbersInRange(int m, int n)
{
    if (m == 0 || n == 0)
        return;

    if (m < n)
    {
        System.Console.Write($"{m}, ");
        NumbersInRange(m + 1, n);
    }
    else
    {
        if (m > n)
        {
            if (m > n)
                NumbersInRange(m - 1, n);
        }
        else
        {
            System.Console.Write($"{m}, ");
        }
    }
}
Main();

Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

void Main()
{
    System.Console.WriteLine("Введите неотрицательное m: ");
    int m = Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine("Введите неотрицательное n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int result = FAckerman(m, n);
    Console.Write($"A({m}, {n}) = {result}");
}

int FAckerman(int m, int n)
{
    if (m == 0)
    return n + 1;

    else

    if (m > 0 && n == 0)
    return FAckerman(m - 1, 1);

    else

    return FAckerman(m - 1, FAckerman(m, n - 1));
}

Main();


Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void Main()
{
    int[] array = { 1, 7, 9, 11, 27 };
    PrintArray(array, array.Length - 1);
}

void PrintArray(int[] array, int index)
{
    if (index < 0)
    return;

System.Console.Write(array[index] + " ");
PrintArray(array, index - 1);
}

Main();
