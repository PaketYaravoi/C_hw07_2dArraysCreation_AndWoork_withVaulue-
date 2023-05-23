// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[] FindAvarage(int[,] array)
{
    double[] mass = new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];             
        }
        double result = (double) sum / array.GetLength(1); // (double - строгая конвертация , все что после скобок приводится к типу данных указанных в них)
        mass[j] = result;
    }
    return mass;
}

int[,] FillArray2D(int[,] array, int minValue, int maxValue)
{
    Random randomDigit = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomDigit.Next(minValue, maxValue +1);
        }
    }
    return array;
}

void PrintArray2D(int[,] array)    
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



int[,] mass = new int[3,4];
FillArray2D(mass, 1, 9);
Console.WriteLine("");

PrintArray2D(mass);
 double[] newAvarageMass= FindAvarage(mass);
 for(int i = 0; i < newAvarageMass.GetLength(0); i++)
 {
    Console.Write($"{newAvarageMass[i]}, ");
 }
Console.WriteLine(""); Console.WriteLine("");

 