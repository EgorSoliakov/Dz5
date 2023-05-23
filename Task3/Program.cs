// Задача 38: Задайте массив вещественных 
//чисел. Найдите разницу между максимальным 
//и минимальным элементов массива.
//[3 7 22 2 78] -> 76


double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
        Console.Write($" {res[i]} ");
    }
    return res;
}

double[] array = GetArray(5, 1, 20);



double MaxMin(double[] arr)
{
double min = arr[0];
double max = 0;
double Raz = 0;
for(int i = 0; i < arr.Length; i++)
{    
    
    if (arr[i]>max)
    {
        max = arr[i];
    }
    else if(arr[i]< min)
    {
        min = arr[i];
    }
     Raz = max - min;
}
return Raz;
}

Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {MaxMin(array)} ");
