// Задача 38: Задайте массив вещественных 
//чисел. Найдите разницу между максимальным 
//и минимальным элементов массива.
//[3 7 22 2 78] -> 76


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
        Console.Write($" {res[i]} ");
    }
    return res;
}