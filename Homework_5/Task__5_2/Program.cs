// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int amoundNumber = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(amoundNumber);
Console.Write($"Массив: \n\t");
PrintArray(array);
Console.WriteLine($"Сумма нечетных чисел массива: {FindSumUnevenNumerArray(array)}");


int[] CreateArray(int amound)
{
    int[] createArray = new int[amound];
    Random random = new Random();
    for (int i = 0; i < createArray.Length; i++)
    {
        createArray[i] = random.Next(-15, 16);
    }
    return createArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
        Console.WriteLine();
}

int FindSumUnevenNumerArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum; 
}

