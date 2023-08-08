// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, 
// округлёнными до одного знака.
void Task47()
{
    int rows = 5;
    int columns = 6;
    double[,] numbers = new double[rows, columns];

    MyLibClass.FillArrayDouble(numbers, -100, 100);
    MyLibClass.PrintArrayDouble(numbers);
}
Task47();

//  Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
void Task50()
{
    int rows = 5;
    int columns = 6;
    int[,] numbers = new int[rows, columns];

    MyLibClass.FillArray(numbers, -100, 100);
    MyLibClass.PrintArray(numbers);

    int inputRow = MyLibClass.Input("Введите строку элемента: ") - 1;
    int inputColumn = MyLibClass.Input("Введите столбец элемента: ") - 1;

    if (inputRow >= 0 && inputRow < rows && inputColumn >= 0 && inputColumn < columns)
    {
        Console.WriteLine($"Ваш элемент: {numbers[inputRow, inputColumn]}");
    }
    else
    {
        Console.WriteLine("Некорректный ввод")
    }
}
Task50();

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void Task52()
{
    int rows = 5;
    int columns = 6;
    int[,] numbers = new int[rows, columns];

    MyLibClass.FillArray(numbers, 0, 9);
    MyLibClass.PrintArray(numbers);
    Console.WriteLine();

    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += numbers[i, j];
        }
        double result = sum/rows;
        result = Math.Round(result, 2);
        Console.WriteLine($"{result}\t");
    }
}
Tesr52();