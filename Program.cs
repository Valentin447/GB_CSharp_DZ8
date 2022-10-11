﻿void Task54()
{
    // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] numbers = new int[rows,columns];
    FillArreyInt(numbers, 0, 99);
    ShowArreyInt(numbers);
    Console.WriteLine("");

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int j2 = j + 1; j2 < columns; j2++)
            {
                if (numbers[i, j] < numbers[i,j2])
                {
                    int temp = numbers[i, j];
                    numbers[i, j] = numbers[i, j2];
                    numbers[i, j2] = temp;
                }
            }
        }
    }
    ShowArreyInt(numbers);
}
void Task56()
{

}
void Task58()
{

}
void ShowArreyInt(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void FillArreyInt(int[,] arr, int min = 0, int max = 0)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(min, max + 1);
        }
    }
}



Task54();
//Task56();
//Task58();