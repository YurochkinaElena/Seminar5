// Задача 31. Задайте массив из 12 элементов, заполненный случайными числами
// Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6]
//сумма положительных числел равна 29, сумма отрицательных равна -20.


var array = FillArray(12);
Print(array);
Console.WriteLine();
Console.Write($"Sum more zero: {SumMoreZero(array)} Sum less zero {SumLessZero(array)}");

int SumMoreZero(int[] array)
{
    int sum = 0;
    foreach(int item in array)
    {
        if(item >= 0)
        {
            sum += item;
        }
    }
    return sum;
}

int SumLessZero(int[] array)
{
    int sum = 0;
    foreach(int item in array)
    {
        if(item < 0)
        {
            sum += item;
        }
    }
    return sum;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    return array;
}

void Print(int[] array)
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}

