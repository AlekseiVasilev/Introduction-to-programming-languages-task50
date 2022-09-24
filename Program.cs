// Задача 50.
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1, 7] -> такого числа в массиве нет


// булевым есть или нет, а потом для вывода

Console.Clear();
Console.WriteLine("\n Задача 50");
Console.Write("Введите количество строк массива: ");
int rows = Math.Abs(int.Parse(Console.ReadLine() ?? string.Empty));
Console.Write("Введите количество столбцов массива: ");
int columns = Math.Abs(int.Parse(Console.ReadLine() ?? string.Empty));
Console.Write("Введите искомую строку: ");
int rowsSearch = Math.Abs(int.Parse(Console.ReadLine() ?? string.Empty));
Console.Write("Введите искомый столбец: ");
int columnsSearch = Math.Abs(int.Parse(Console.ReadLine() ?? string.Empty));


double[,] array = GetArray(rows, columns, -9, 9);
Console.WriteLine("");
PrintArray(array);
Console.WriteLine("");
ElementSearch(array, rowsSearch, columnsSearch);

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    Random rng = new Random();
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(minValue + (maxValue - minValue) * rng.NextDouble(), 2);
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    Console.WriteLine("");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:F2}\t");// - \t табуляция, помогает выровнять F1 - округление
        }
        Console.Write("\b\b]\n");// - \b \n - для удаления лишний запятой
    }
    Console.WriteLine("");
}

void ElementSearch(double[,] array, int inRows, int inColumns)
{
    if (inRows <= array.GetLength(0) && inColumns <= array.GetLength(0))
    {
        Console.Write($"{array[inRows-1, inColumns-1]} ");
    }

    else
    {
        Console.WriteLine($"Элемент не обнаружен");
    }
}
