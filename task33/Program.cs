// Задача 33: Задайте массив. Напишите программу, которая определяет,
//присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

var array = FillArray(15);
Print(array);
Console.WriteLine();
var usernNum = Convert.ToInt32(Console.ReadLine());

if(FindNum(array, usernNum))
{
    System.Console.WriteLine("Yes");
}
else
{
    System.Console.WriteLine("No");
}

bool FindNum(int[] arr, int num)
{
    foreach(var item in arr)
    {
        if(item == num)
        {
            return true;
        }
    }
    return false;
}


int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 7);
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
