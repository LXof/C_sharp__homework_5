// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


Console.Clear();

Console.Write("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Массив случайных положительных трехзначных чисел:\n\t\t");
int[] array = FillArray(number);
PrintArray(array);
Console.WriteLine($"Количество четных чисел: {SearchAmountEvenNumberArray(array)}");



int[] FillArray(int amoundNumber)
{
    Random rand = new Random();
    int[] crateArray = new int[amoundNumber];
    for (int i = 0; i < crateArray.Length; i++)
    {
        crateArray[i] = rand.Next(100, 1000);
    }
    return crateArray;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int SearchAmountEvenNumberArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}