/*
Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.WriteLine("Укажите сколько элементов вы хотите получить в вашем массиве: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Укажите максимально возможную цифру в вашем массиве : ");
int range = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(-range, range + 1);
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
            Console.Write(", ");
        }
    }
    Console.Write("] -> ");
}

int SumOddIndexNumbers(int[] array3)
{
    int result = 0;
    for (int i = 1; i < array3.Length; i = i + 2)
    {
        result = result + array3[i];
    }
    return result;
}

int[] array = new int[sizeArray];
FillArray(array);
int result = SumOddIndexNumbers(array);
PrintArray(array);
Console.Write(result);