//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int Prompt(string messege)
{
    System.Console.Write(messege);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Введите трехзначное число: ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Неправильно! Повторите попытку");
    return;
}
Console.WriteLine($"Ваше число: '{number}'");
int secondRenk = number / 10 % 10;
Console.WriteLine($"Вторая цифра: '{secondRenk}'");

// Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int Prompt(string messege)
{
    System.Console.Write(messege);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;

}
int GetThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}
bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}
int number = Prompt("Введите число: ");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int Prompt(string messege)
{
    System.Console.Write(messege);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;

}
bool IsWeekend(IReadOnlySet weekDay)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Это не дни недели!");
    return false;
}
int weekDay = Prompt("Введите день недели: ");
if (VaidateWeekday(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine("Наконец-то выходной!");
    }
    else
    {
        Console.WriteLine("Работай");
    }                            
}