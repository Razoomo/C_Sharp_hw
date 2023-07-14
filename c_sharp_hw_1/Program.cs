// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int number_1_1 = 7;
int number_2_1 = 5;

if(number_1_1 > number_2_1)
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(number_1_1);
    Console.Write("Минимальное число: ");
    Console.WriteLine(number_2_1);
}
else if(number_2_1 > number_1_1)
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(number_2_1);
    Console.Write("Минимальное число: ");
    Console.WriteLine(number_1_1);
}
else
{
    Console.Write("Они равны");
}

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int number_1_2 = 8;
int number_2_2 = 7;
int number_3_2 = 4;

int max = number_1_2;

if ( number_1_2 > max ) max = number_1_2;
if ( number_2_2 > max ) max = number_2_2;
if ( number_3_2 > max ) max = number_3_2;
Console.Write("max = ");
Console.WriteLine(max);

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int number_1_3 = new Random().Next(1, 100);
if ( number_1_3 % 2 == 0 )
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int N = new Random().Next(1, 100);
int count = 0;

while ( count < N )
{
    if ( count % 2 == 0)
    {
        Console.WriteLine(count);
    }
    count++;
}