/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными
числами. Напишите программу, которая покажет количество чётных чисел 
в массиве.
[345, 897, 568, 234] -> 2
*/

int[] getRandomArray(int Length, int min, int max)
{
    int[] array = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        array [i] = new Random ().Next (min, max  + 1);
    }
    return array;
}
int getEvenNumberArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
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
int[] newArray = getRandomArray(4, 100, 1000);
printArray(newArray);
Console.ResetColor();
int count = getEvenNumberArray(newArray);
Console.WriteLine($"Количество четных чисел в массиве = {count}. ");
Console.ResetColor();