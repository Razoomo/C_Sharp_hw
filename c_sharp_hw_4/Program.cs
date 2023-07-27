// Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
int Prompt(string messege)
{
    System.Console.Write(messege);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int Power(int powerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power;
}
bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        System.Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}
int powerBase = Prompt("Введите основание: ");
int exponent = Prompt("Введите показатель: ");
if (ValidateExponent(exponent))
{
    System.Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int Prompt(string messege)
{
    System.Console.Write(messege);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int SumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}
int number = Prompt("Введите число: ");
System.Console.WriteLine($"Сумма всех чисел в цифре {number} = {SumAllDigit(number)}");

// Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
int Prompt(string messege)
{
    System.Console.Write(messege);
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}
int[] GenerateArray(int Length, int minValue, nint maxValue);
{
    int[] array = new int[Lenght];
    Random random = new Random();
    for (int i = 0; i < Lenght; i++)
    {
        array[i] = random.Next(minValue, maxValue +1);
    }
    return array;
}
void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length = 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.WriteLine("]");
}
int Lenght = Prompt("Длина массива: ");
int min = Prompt("Начальное значение, для диапазона случайного числа: ");
int max = Prompt("Конечное значение, для диапазона случайного числа: ");
int[] array = GenerateArray(Length, min, max);
PrintArray(array);