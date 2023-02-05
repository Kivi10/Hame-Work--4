// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Promt(string? message)
{
    System.Console.Write($"{message} -> ");
    return int.Parse(Console.ReadLine());
}

int Sum(int nums)
{
    int result = 0;
    while (nums > 0)
    {
        int temp = nums % 10;
        nums = nums / 10;
        result = result + temp;
    }
    return result;
}

int number = Promt("Введите число");
System.Console.WriteLine($"Сумма цифр в числе {number} = {Sum(number)}");