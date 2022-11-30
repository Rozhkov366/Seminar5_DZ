/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] getRandomArray(int Length, int min, int max)
{
    int[] array = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int getSumOfOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int[] newArray = getRandomArray(4, -100, 100);
printArray(newArray);
Console.ResetColor();
int Summa = getSumOfOddIndex(newArray);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {Summa}. ");
Console.ResetColor();