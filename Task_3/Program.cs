// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Сделать через функции 

int Promt(string? message)
{
    System.Console.Write(message + "-> ");
    return int.Parse(Console.ReadLine());
}

int[] CreatArray(int size, int lnt)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int x = 0; x < array.Length; x++)
    {
        array[x] = rand.Next(lnt);
    }
    return array;
}

void PrintArray(int[] m)
{
    for (int x = 0; x < m.Length; x++)
    {
        System.Console.Write(m[x] + "; ");
    }
}

int lenght = Promt("Введите длину массива");
int rnd = Promt("Введите верхний порог чисел для массива");
int[] myArray = CreatArray(lenght, rnd);
PrintArray(myArray);