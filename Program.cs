// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int from, int to)
{
    if (from == to)
    {
        return from;
    }
    var direction = to > from ? 1 : -1;
    return SumNumbers(from + direction, to) + from;
}

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int sum = SumNumbers(firstNumber, secondNumber);
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");


// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return Ackermann(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    else
    {
        return n + 1;
    }
}

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = Ackermann(m, n);
Console.WriteLine($"Ackermann({m}, {n}) = {result}");