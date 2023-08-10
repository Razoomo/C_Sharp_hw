// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
void task54()
{
    int rows = 5;
    int columns = 6;
    int[,] numbers = new int[rows, columns];

    MyLibClass.FillArray(numbers, 0, 9);
    MyLibClass.PrintArray(numbers);
    
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < columns - j - 1; k++)
            {
                if (numbers[i, k] < numbers[i, k+1])
                {
                    (numbers[i, k], numbers[i, k+1]) = (numbers[i, k+1], numbers[i, k]);
                }
            }
        }
    }
    Console.WriteLine("Измененный массив:")
    MyLibClass.PrintArray(numbers);
}
task54();

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
void task56();
{
    int rows = 5;
    int columns = 6;
    int[,] numbers = new int[rows, columns];

    MyLibClass.FillArray(numbers, 0, 9);
    MyLibClass.PrintArray(numbers);
    int index = 0;
    int min_sum =  Int32.MaxValue;
    for (int j = 0; j < columns; j++)
    {
        int sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += numbers[i, j];
        }
        if (sum < min_sum)
        {
            min_sum = sum;
            index = i;
        }
    }

    Console.WriteLine($"Минимальная сумма на строке: {index}, которая равна {min_sum}");
}
void56();

// Заполните спирально массив 4 на 4 числами от 1 до 16

void task58()
{
    int rows = 4;
    int columns = 4;
    int[,] numbers = new int[rows, columns];

    int i = 0;
    int j = 0;

    int delta_i = 0;
    int delta_j = 1;
    int steps = columns;
    int turns = 0;

    for (int k = 0; k < numbers.Length; k++)
    {
        numbers[i,j] = k + 1;
        steps--;
        Console.Write($"{numbers[i, j] }")

        if (steps == 0)
        {
            steps = rows - 1 - turns/2;
            turns++;
            int temp = -delta_i;
            delta_i = delta_j;
            delta_j = temp;
        }
        i += delta_i;
        j += delta_j;

        
    }
}
task58();