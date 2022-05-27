/*
Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.WriteLine("Укажите сколько элементов вы хотите получить в вашем массиве: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());


void FillArray(double[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().NextDouble()*100;
    }
}

void PrintArray(double[] array2)
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

double FindMaxNumber(double[] array3, double Max)
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

double FindMinNumber(double[] array3, double Min)
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

double[] array = new double[sizeArray];



FillArray(array);
PrintArray(array);
double MaxNumber = FindMaxNumber(array, -100);
double MinNumber = FindMinNumber(array, 100);
double result = MaxNumber - MinNumber;
Console.Write(result);
Console.Write(" ,");
Console.Write(MaxNumber);
Console.Write(" ,              ");
Console.Write(10.234567/0.01);

