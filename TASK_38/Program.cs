/*
Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.WriteLine("Укажите сколько элементов вы хотите получить в вашем массиве: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Укажите максимально возможную цифру в вашем массиве : ");
int range = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(0, range + 1);
    }
}

void PrintArray(int[] array2)
{
    Console.Write("[");
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write(array2[i]);
        if (i != array2.Length - 1)
        {
            Console.Write(" ");
        }
    }
    Console.Write("] -> ");
}

int FindMaxNumber(int[] array3, int Max)
{
    for (int i = 0; i < array3.Length; i++)
    {
        if (array3[i] > Max)
        {
            Max = array3[i];
        }
    }
    return Max;
}

int FindMinNumber(int[] array3, int Min)
{
    for (int i = 0; i < array3.Length; i++)
    {
        if (array3[i] < Min)
        {
            Min = array3[i];
        }
    }
    return Min;
}

int[] array = new int[sizeArray];



FillArray(array);
PrintArray(array);
int MaxNumber = FindMaxNumber(array, 0);
int MinNumber = FindMinNumber(array, range);
int result = MaxNumber - MinNumber;
Console.Write(result);
Console.Write(" ,");
Console.Write(MaxNumber);
Console.Write(" ,");
Console.Write(MinNumber);

