/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double [] GetRandomArray (int length, int min, int max)
{
    double [] array = new double [length];
    for (int i = 0; i < length; i++)
        {
            array [i] = new Random().Next(min, max + 1);
        }
    return array;
}

void PrintArray(double [] array)
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

double MinElementOfArray (double [] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
        {
            if(array[i] < min)
                {
                    min = array[i];
                }
        }
        return min;
}

double MaxElementOfArray (double [] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
        {
            if(array[i] > max)
                {
                    max = array[i];
                }
        }
        return max;
}

double DifferenceElements (double max, double min)
{
    double diff = max - min;
    return diff;
}

double [] newArray = GetRandomArray (10, -10, 60);
Console.ForegroundColor = ConsoleColor.Magenta;
PrintArray(newArray);
Console.ResetColor();
double maxElement = MaxElementOfArray(newArray);
double minElement = MinElementOfArray(newArray);
double result = DifferenceElements (maxElement, minElement);
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"Максимальный элемент массива = {maxElement}, минимальный  = {minElement}"); 
Console.WriteLine($"Разница между максимальным и минимальным элементами = {result}");
Console.ResetColor();