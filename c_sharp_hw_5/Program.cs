void FillArray(int[] array, int minValue = -9, int maxValue = 9)
{
    maxValue++;
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue);
    }
}
void FillArrayDouble(double[] array, int minValue = -9, int maxValue = 9)
{
    maxValue++;
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * 18 - 9;
        array[i] = Math.Round(array[i], 2);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}
void PrintArrayDouble(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}


// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
int size_1 = 6;
int[] numbers_1 = new int[size_1];

FillArray(numbers_1);
PrintArray(numbers_1);

int count = 0;
for (int i = 0; i < numbers_1.Length; i++)
{
    if (numbers_1[i] % 2 == 0) count++;
}
Console.WriteLine("Количество четных чисел равно: " + count);

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
// элементов с нечётными индексами.
int size_2 = 6;
int[] numbers_2 = new int[size_2];

FillArray(numbers_2);
PrintArray(numbers_2);

int sum = 0;
for (int i = 0; i < numbers_2.Length; i++)
{
    if (i % 2 == 1) sum += numbers_2[i];
}
Console.WriteLine("сумма равна: " + sum);

// Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементами массива.
int size = 6;
double[] numbers_3 = new double[size];

FillArrayDouble(numbers_3);
PrintArrayDouble(numbers_3);

double max = numbers_3[0];
double min = numbers_3[0];

for (int i = 0; i < numbers_3.Length; i++)
{
    if (numbers_3[i] > max) max = numbers_3[i];
    else if (numbers_3[i] < min) min = numbers_3[i];

}
Console.WriteLine($"Разность между максимальным и минимальным числами равна: {max - min}");