// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int FindNumbers(int[,] array, int index1, int index2)
{
    int yourNumber = -1;
    if(index1 < 0 || index2 < 0)
    {
        Console.WriteLine("один из индексов меньше \"0\" ");
        return yourNumber;
    }
    if(index1 > array.GetLength(0) - 1 || index2 > array.GetLength(1) - 1)
    {
        Console.WriteLine($"число с индексами {index1}, {index2} нет в массиве");
        return yourNumber;
    }
    yourNumber = array[index1, index2];
    return yourNumber;
}



void PrintArray2D(int[,] array)    // метод печати двумергного  массива 
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

int[,] array = new int[2,2]{{1,2},{3,4}};
int result = FindNumbers(array, 1, 10);
PrintArray2D(array);
Console.WriteLine(result);
