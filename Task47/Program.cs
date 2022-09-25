//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double [,] matrix = new double[3,4];
FillArr(matrix);
PrintArr(matrix);


void PrintArr(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArr(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * 20 - 10, 1);
        }
    }
}
