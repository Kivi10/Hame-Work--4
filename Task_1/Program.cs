// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать Math.Pow.

int Promt(string? message)
{
    System.Console.Write($"{message} -> ");
    return int.Parse(Console.ReadLine());
}

int Pow(int num1, int num2)
{
    int pow = 1;
    for (int i = 1; i <= num2; i++)
    {
        pow = pow * num1;
    }
    return pow;
}

int number1 = Promt("Введите первое число");
int number2 = Promt("Введите второе число");
System.Console.WriteLine($"{number1} в степени {number2} = {Pow(number1, number2)}");