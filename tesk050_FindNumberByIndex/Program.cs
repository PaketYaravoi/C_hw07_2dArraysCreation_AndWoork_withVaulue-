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
        //Console.WriteLine("один из индексов меньше \"0\" ");
        return yourNumber;
    }
    if(index1 > array.GetLength(0) - 1 || index2 > array.GetLength(1) - 1)
    {
      //Console.WriteLine($"число с индексами {index1}, {index2} нет в массиве");
        return yourNumber;
    }
    yourNumber = array[index1, index2];
    return yourNumber;
}

int[,] GetArray2D(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j =0; j < array.GetLength(1); j++)
            {   
                array[i,j] = rnd.Next(1501);
            }
        }
        return array;
    }
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

int Prompt(string massage)
{
    Console.WriteLine(massage);
    string stringInput = Console.ReadLine()!;
    int result = Int32.Parse(stringInput);
    return result;
}


int rows = Prompt("Введите количество строк в массиве: ");
int columns = Prompt("Введите количество столбцов в массиве: ");
int index1 = Prompt("Введите индекс строки: ");
int index2 = Prompt("Введите индекс столбца: ");
int[,] array = GetArray2D(rows, columns);

int result = FindNumbers(array, index1, index2);
PrintArray2D(array);
Console.WriteLine(result);
