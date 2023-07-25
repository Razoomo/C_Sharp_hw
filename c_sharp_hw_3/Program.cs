// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int number_1 = 12321;
string numberStr_1 = Convert.ToString(number_1);
if (numberStr_1[0] == numberStr_1[4] && numberStr_1[1] == numberStr_1[3])
{
    Console.WriteLine($"Число {number_1} является полиндромом");

}
else
{
    Console.WriteLine($"Число {number_1} не является полиндромом");
}

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int x_1 = 1;
int y_1 = 2;
int z_1 = 3;

int x_2 = 4;
int y_2 = 5;
int z_2 = 6;

double result = Math.Sqrt( Math.Pow(x_2 - x_1, 2) + Math.Pow(y_2 - y_1, 2) + Math.Pow(z_2 - z_1, 2) );
result = Math.Round(result, 3);
Console.WriteLine($"Расстояние между двумя точками равно: {result}");

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int N = 5;
int n = 1;
while (n <= N)
{
    Console.WriteLine($"{n} * {n} * {n} = {Math.Pow(n, 3)}");
    n++;
}