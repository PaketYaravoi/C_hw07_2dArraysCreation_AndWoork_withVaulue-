// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


//Random rnd = new Random()    rnd берем больше  в 10 раз , бля заполнения массива числами  в промежутке от 0 до 100 - пишем 1001 от 0 до 1000 - пишем 10 000 и тд..(?)

double[,] GetArray2D(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    Random rnd = new Random();
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = rnd.Next(10000) / (double)10; // строгая типизация привести 10 к вещественному чилсу (?)
            }
        }
        return array;
    }
}

void PrintArray2D(double[,] array)    // метод печати двумергного  массива 
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


//array[i,j] = new Random().Next(1001) / (double)10;

int rows = 5; int columns = 3;
double[,] array = GetArray2D(rows, columns);

PrintArray2D(array);