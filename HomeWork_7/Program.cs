// адайте двумерный массив размером m×n, заполненный случайными вещественными числами

// Console.Write("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] Array = new double[m, n];
// Random random = new Random();
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         Array[i, j] = Math.Round(random.Next(-100, 101) * 0.1, 10);
//         Console.Write("{0,8:F1}", Array[i, j]);
//     }

//     Console.WriteLine();
// }


// Напишите программу, которая на вход принимает два числа(строка, столбец), проверяя есть ли такая позиция в двумерном массиве и возвращает сообщение о том, что оно найдено, а также какое число стоит на этом месте или же указание, что такого элемента нет.
// Console.Write("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] Array = new double[m, n];
// Random random = new Random();
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         Array[i, j] = random.Next(0, 10);
//         Console.Write("{0,4:F0}", Array[i, j]);
//     }

//     Console.WriteLine();
// }
// Console.Write("Введите номер строки: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер столбца: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a <= m && b <= n)
//     Console.Write($"Такой элемент есть -> {Array[a, b]}");
// else
//     Console.Write("Такого элемента нет в массиве");

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Console.Write("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] Array = new int[m, n];
// Random random = new Random();
// int i;
// int j;
// for (i = 0; i < m; i++)
// {
//     for (j = 0; j < n; j++)
//     {
//         Array[i, j] = random.Next(0, 10);
//         Console.Write("{0,4:F0}", Array[i, j]);
//     }

//     Console.WriteLine();
// }

// Console.Write("Среднее арифметическое элементов в каждом столбце: ");

// for (j = 0; j < n; j++)
// {
//     double S = 0;
//     for (i = 0; i < m; i++)
//     {
//         S = S + Array[i, j];
//     }
//     Console.Write($"{S / m:F1};");
// }
     