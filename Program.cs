using System;
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

        int[,] matrix1 = new int[n, n];
        var random1 = new Random();
        int i;

        for (i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix1[i, j] = random1.Next(min, max);
            }
        }

        Console.WriteLine("Матрица А:");
        for (i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix1[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        int[,] matrix2 = new int[n, n];
        var random2 = new Random();

        for (i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix2[i, j] = random2.Next(min, max);
            }
        }

        Console.WriteLine("Матрица Б:");
        for (i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix2[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //Сложение матриц

        int[,] matrix3 = new int[n, n];
        for (i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        Console.WriteLine("Сложение матриц А и Б"); for (i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix3[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //Вычитание матриц

        int[,] matrix4 = new int[n, n];
        for (i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix4[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }

        Console.WriteLine("Вычитание матрицы Б из матрицы А"); for (i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix4[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.ReadKey();
    }
}