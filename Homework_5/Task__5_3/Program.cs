// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int amoundNumber = Convert.ToInt32(Console.ReadLine());

double[] array = CreateArray(amoundNumber);
PrintArray(array);
PrintResult(GetDifference(FindMax(array), FindMin(array)));

double[] CreateArray(int amound)
{
    Random random = new Random();
    double[] createArray = new double[amound];
    for (int i = 0; i < createArray.Length; i++)
    {
        createArray[i] = Math.Round(random.NextDouble() * 100, 4);
    }
    return createArray;
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}


double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}


double GetDifference(double max, double min)
{
    double difference = max - min;
    return difference;
}

void PrintArray(double[] printArray)
{
    for (int i = 0; i < printArray.Length; i++)
    {
        Console.Write($"{printArray[i]} ");
    }
    Console.WriteLine();
}

void PrintResult(double result)
{
    Console.WriteLine($"Максимальный элемент: MAX = {FindMax(array)}");
    Console.WriteLine($"Минимальный элемент: MIN = {FindMin(array)}");
    Console.WriteLine($"Разница между максимальным и минимальным: {GetDifference(FindMax(array), FindMin(array))}");
}