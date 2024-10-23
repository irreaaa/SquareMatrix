using System;
using System.Numerics;
class Program
{
    static void Main()
    {

        Console.WriteLine("Задайте значение размерности квадратной матрицы: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите минимальное значение случайных чисел: ");
        int min = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите максимальное значение случайных чисел: ");
        int max = Convert.ToInt32(Console.ReadLine());

        if (min > max)
        {
            Console.WriteLine("Максимальное значение должно быть больше минимального");
            return;
        }

        int[,] matrix1 = CreateMatrix(n, min, max);
        Console.WriteLine("Матрица А:");
        ConsoleMatrix(matrix1, n);

        int[,] matrix2 = CreateMatrix(n, min, max);
        Console.WriteLine("Матрица Б:");
        ConsoleMatrix(matrix2, n);

        int[,] matrixSum = SummaMatrix(matrix1, matrix2, n);
        Console.WriteLine("Сложение матриц А и Б:");
        ConsoleMatrix(matrixSum, n);

        int[,] matrixDifference = MinusMatrix(matrix1, matrix2, n);
        Console.WriteLine("Вычитание матрицы Б из матрицы А:");
        ConsoleMatrix(matrixDifference, n);

        Console.ReadKey();
    }

    static int[,] CreateMatrix(int size, int min, int max)
        {
            int[,] matrix = new int[size, size];
            var random = new Random();

            for(int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = random.Next(min, max);
                }
            }
            return matrix;
        }

        static void ConsoleMatrix(int[,] matrix, int size)
        {
            for(int i = 0;i < size; i++)
            {
                for( int j = 0; j < size; j++)
                {
                    Console.WriteLine(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static int[,] SummaMatrix(int[,] matrix1, int[,] matrix2, int size)
        {
            int[,] matrix3 = new int[size, size];
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return matrix3;
        }

        static int[,] MinusMatrix(int[,] matrix1, int[,] matrix2, int size)
        {
            int[,] matrix4 = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0;j < size; j++)
                {
                    matrix4[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return matrix4;  
        }
    }
}

