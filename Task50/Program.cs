/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.*/
Console.WriteLine("Введите количество строк (m):");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (n):");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

FillArr(matrix);
PrintArr(matrix);

Console.WriteLine("Укажите строку искомого элемента (i):");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите столбец искомого элемента (j):");
int j = Convert.ToInt32(Console.ReadLine());
if (i > m || j > n)
{
    Console.WriteLine("Такого элемента массива не существует");
}
else
{
    Console.WriteLine($"Ваше значение: {matrix[i, j]}");
}


void PrintArr(int[,] matrix)
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