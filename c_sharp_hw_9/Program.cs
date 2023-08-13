// Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные 
// числа кратные 3-ём в промежутке от M до N.
void task64()
{
    int start_number = MyLibClass.Input("Введите начальне число: ");
    int end_number = MyLibClass.Input("Введите конечное число: ");

    while (start_number <= end_number)
    {
        if (start_number % 3 == 0)
        {
            Console.Write($"{start_number} ");
        }
        start_number++;
    }
}
task64();


// Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму 
// натуральных элементов в промежутке от M до N.
void task66()
{
    int start_number = MyLibClass.Input("Введите начальное число: ");
    int end_number = MyLibClass.Input("Введите конечное число");

    int sum = 0;
    int i = end_number - start_number;
    if (start_number > end_number)
    {
        Console.WriteLine("Введите числа наоборот");
    }
    else
    {
        while (i > 0)
        {
            sum += start_number;
            start_number++;
            i--;
        }
        Console.WriteLine($"Сумма равна: {sum}");
    }
}
task66();

// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
void task68()
{
    int m = MyLibClass.Input("Введите начальне число: ");
    int n = MyLibClass.Input("Введите конечное число: ");

    int AkkermanFunc(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        if (m > 0 && n == 0)
        {
            return AkkermanFunc(m - 1, 1);
        }
        return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
    }

    Console.WriteLine(AkkermanFunc(m, n));
}
task68();