//Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц. 

Console.WriteLine("Введите количество строк первой матрицы");
int m1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов первой матрицы");
int n1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество строк второй матрицы");
int m2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов второй матрицы");
int n2 = int.Parse(Console.ReadLine()!);

if (n1 != m2)
{
    Console.WriteLine("Данные матрицы не могут быть перемножены");
}
else
{
    int[,] matrix1 = Create2DArray(m1, n1, -10, 10);
    Print2DArray(matrix1);

    Console.WriteLine();

    int[,] matrix2 = Create2DArray(m2, n2, -10, 10);
    Print2DArray(matrix2);

    Console.WriteLine();

    int[,] matrixMult = CreateMult2DArray(matrix1, matrix2);

    Print2DArray(matrixMult);
}


int[,] Create2DArray(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] CreateMult2DArray(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i,j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}
