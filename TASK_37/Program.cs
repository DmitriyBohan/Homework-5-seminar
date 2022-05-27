/*
Задача 37: 
Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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

void PrintProductOfPairsOfElements(int[] array3)
{
    int[] result = new int[array3.Length / 2];
    for (int i = 0; i < array3.Length / 2; i++)
    {
        result[i] = array3[i] * array3[sizeArray - 1 - i];
        Console.Write(result[i] + " ");
    }
    if (sizeArray % 2 > 0)
    {
        Console.Write(array3[sizeArray / 2]);
    }
}




int[] array = new int[sizeArray];
int[] result = new int[sizeArray / 2 + 1];


FillArray(array);
PrintArray(array);
PrintProductOfPairsOfElements(array);


