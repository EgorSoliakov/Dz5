﻿// Задача 34: Задайте массив заполненный 
//случайными положительными трёхзначными 
//числами. Напишите программу, которая 
//покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] GetArray(int size)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
        Console.Write($" {res[i]} ");
    }
    return res;
}


