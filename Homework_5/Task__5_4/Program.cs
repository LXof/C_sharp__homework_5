//Задайте одномерный массив, заполненный случайными числами. 
//Из входного массива сформируйте массив с чётными и массив с нечётными значениями элементов входного массива. 
//Найдите ср. арифметическое из полученных значений элементов массивов и выведите результат сравнения средних арифметических.

//[1,2,3,4] -> средн. арифм. значений элементов массива с чётными числами > средн. арифм. значений элементов с нечётными числами
//[2,3,5,7] -> средн. арифм. массива значений элементов с нечётными числами > средн. арифм. значений элементов с чётными числами
//[1,2,5,4] -> средн. арифм. значений элементов массива с нечётными числами = средн. арифм. значений элементов с чётными числами

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int amoundNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Массив случайных чисел:");
int[] array = CreateArray(amoundNumber);
PrintArray(array);

(int[], int[]) evenOrUnevenNumberArray = GetEvenOrUnevenNumberArray(array, amoundNumber);

Console.WriteLine("ЧЕТНЫЕ чисела в массиве:");
PrintArray(evenOrUnevenNumberArray.Item1);

Console.WriteLine("НЕ четные чисела в массиве:");
PrintArray(evenOrUnevenNumberArray.Item2);

double averageEvenNumArray = GetAverageEvenNum(evenOrUnevenNumberArray.Item1);
Console.Write($"Среднее арифметическое ЧЕТНЫХ чисел: {averageEvenNumArray}");
Console.WriteLine();

double averageUnevenNumArray = GetAverageEvenNum(evenOrUnevenNumberArray.Item2);
Console.Write($"Среднее арифметическое НЕ четных чисел: {averageUnevenNumArray}");
Console.WriteLine();

Console.Write($"Среднее арифметическое ЧЕТНЫХ чисел {ComparisonArraies(averageEvenNumArray, averageUnevenNumArray)} Среднее арифметическое НЕ четных чисел");




int[] CreateArray(int amound)
{
    Random rand = new Random();
    int[] createArray = new int[amound];
    for (int i = 0; i < createArray.Length; i++)
    {
        createArray[i] = rand.Next(-20, 20);
    }
    return createArray;
}

void PrintArray(int[] outputArray)
{   
    for (int i = 0; i < outputArray.Length; i++)
    {
        Console.Write($"{outputArray[i]} ");
    }
    Console.WriteLine();
}


(int[], int[]) GetEvenOrUnevenNumberArray(int[] array, int amound)
{
    int[] even = new int[amound];
    int[] uneven = new int[amound];
    int countEven = 0;
    int countUneven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) 
        {
            even[countEven] = array[i]; 
            countEven++;
        }
        else {
            uneven[countUneven] = array[i];
            countUneven++;
        }
    }

    int[] evenNumArray = new int[countEven];
    int[] unevenNumArray = new int[countUneven];
    for (int i = 0; i < evenNumArray.Length; i++)
    {
        evenNumArray[i] = even[i];
    }

    for (int i = 0; i < unevenNumArray.Length; i++)
    {
        unevenNumArray[i] = uneven[i];
    }

    return (evenNumArray, unevenNumArray);
}

double GetAverageEvenNum(int[] evenOrUneven)
{
    int sum = 0;
    int count = 0;
    double AVG = 1.0;
    for (int i = 0; i < evenOrUneven.Length; i++)
    {
        sum += evenOrUneven[i];
        count++;
    }
    AVG = sum / count;
    return AVG;
}

string ComparisonArraies(double evenAvg, double unevenAvg)
{
    string result = "";
    if (evenAvg > unevenAvg)    
        result = ">";
    else 
    if (evenAvg < unevenAvg)   
        result = "<";
    else
        result = "=";
    
    
    return result;
}