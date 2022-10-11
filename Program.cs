void Task54()
{
    // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

    Random random = new Random();
    int rows = random.Next(3, 5);
    int columns = random.Next(3, 5);
    int[,] numbers = new int[rows, columns];
    FillArreyInt(numbers, 0, 9);
    ShowArreyInt(numbers);
    Console.WriteLine("");

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int j2 = j + 1; j2 < columns; j2++)
            {
                if (numbers[i, j] < numbers[i, j2])
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
    // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

    Random random = new Random();
    int rows = random.Next(3, 5);
    int columns = random.Next(3, 5);
    int[,] numbers = new int[rows, columns];
    FillArreyInt(numbers, 0, 9);
    ShowArreyInt(numbers);
    Console.WriteLine("");


    int sumMin = 0;
    int indexRows = 0;
    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += numbers[i, j];
        }
        if (i == 0) sumMin = sum;
        if (sumMin > sum)
        {
            sumMin = sum;
            indexRows = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма в строке {indexRows + 1} равная {sumMin}");
}
void Task58()
{
    // Задача 58: Напишите программу, которая заполнит спирально массив 4 на 4. 

    Console.WriteLine("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] numbers = new int[rows, columns];
    int count = 1;
    int i = 0;
    int j = -1;
    string path = "right";
    while (count <= rows * columns)
    {
        switch (path)
        {
            case "right":
                if (j + 1 < columns && numbers[i, j + 1] == 0)
                {
                    j++;
                    numbers[i, j] = count;
                    count++;
                    ShowArreyInt(numbers);
                    Thread.Sleep(500);
                }
                else
                {
                    path = "down";
                }
                break;
            case "down":
                if (i + 1 < rows && numbers[i + 1, j] == 0)
                {
                    i++;
                    numbers[i, j] = count;
                    count++;
                    ShowArreyInt(numbers);
                    Thread.Sleep(500);
                }
                else
                {
                    path = "left";
                }
                break;
            case "left":
                if (j - 1 >= 0 && numbers[i, j - 1] == 0)
                {
                    j--;
                    numbers[i, j] = count;
                    count++;
                    ShowArreyInt(numbers);
                    Thread.Sleep(500);
                }
                else
                {
                    path = "top";
                }
                break;
            case "top":
                if (i - 1 >= 0 && numbers[i - 1, j] == 0)
                {
                    i--;
                    numbers[i, j] = count;
                    count++;
                    ShowArreyInt(numbers);
                    Thread.Sleep(500);
                }
                else
                {
                    path = "right";
                }
                break;
        }
    }
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
    Console.WriteLine();
    Console.WriteLine();
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