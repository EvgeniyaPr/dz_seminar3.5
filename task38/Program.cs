//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GenerateArray(int size)
{
    double[] array = new double[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.NextDouble() * 100, 2);
    }
    return array;
}

double difference(double[] array)
{
    double max = array[0];
    double min = array[0];
    double result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
        result = Math.Round(max - min, 2);
    }
    return result;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double[] array = GenerateArray(5);
PrintArray(array);
double diff = difference(array);
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {difference(array)}");

