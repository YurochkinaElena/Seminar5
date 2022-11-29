// Домашняя работа. Задача 38. Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным числами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


Console.WriteLine("Введите количество элементов массива:\t");
int number = Convert.ToInt32(Console.ReadLine());

double[] array = new double[number];

FillArray(array);
PrintArray(array);
//FindDifMaxMin(array);
Console.WriteLine();
double different = FindMinMax(array);
Console.Write($"\tРазница = {different}");

void FillArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble() * 100;
    }
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
        {
            Console.WriteLine($"{arr[i]}");
        }
        else
        {
            Console.Write($"{arr[i]}, ");
        }
    }
}

double FindMinMax(double[] arr) 
{
    int indexNumberMax = 0;
    int indexNumberMin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[indexNumberMax])
        {
            indexNumberMax = i;
        }
        else if (array[i] < array[indexNumberMin])
        {
            indexNumberMin = i;
        }
    }
    if (array.Length <= 1) return 0;
    double result = array[indexNumberMax] - array[indexNumberMin];
    return result;
}