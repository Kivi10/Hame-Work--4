// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Сделать через функции 

// int[] array = new int[8];
// Random rand = new Random();

// for (int x = 0; x < array.Length; x++)
// {
//     array[x] = rand.Next(2);
//     System.Console.Write(array[x] + "; ");
// }

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

int lenght = Promt("Введите длину массива");
int rnd = Promt("Введите верхний порог чисел для массива");
int [] myArray = CreatArray(lenght, rnd);

for (int x = 0; x < myArray.Length; x++)
    {
        System.Console.Write(myArray[x] + "; ");
    }