//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("Введите количество строк (m):");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (n):");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillArr(matrix);
PrintArr(matrix);
SumArr(matrix);

void SumArr(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double result = 0;
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum = matrix[j, i] + sum;

        }
        result = sum / matrix.GetLength(0);
        Console.WriteLine($"Среднее арифметическое по столбцу №{i + 1} = {Math.Round(result,1)}");
    }
}

void PrintArr(int[,] matrix)
{
    Console.WriteLine("Ваш массив:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArr(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}