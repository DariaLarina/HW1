//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// Console.Write("Введите количество элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] Array = new int[n];
// int count = 0;
// Random rnd = new Random(); 
// for (int i = 0; i < n; i++)
// {
// Array[i] = rnd.Next(100,999);
// if (Array[i]%2 == 0)
// count++;
// }
// Console.WriteLine("\nМассив: {0}",String.Join(" ",Array));
// Console.Write($"Количество четных чисел {count}");

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
// Console.Write("Введите количество элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] Array = new int[n];
// int Sum = 0;
// Random rnd = new Random(); 
// for (int i = 0; i < n; i++)
// {
// Array[i] = rnd.Next(-100,100);
// if (i%2 != 0)
// Sum = Sum + Array[i];
// }
// Console.WriteLine("\nМассив: {0}",String.Join(" ",Array));
// Console.Write($" Сумма чисел на нечетных индексах: {Sum}");

//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Console.Write("Введите количество элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[] Array = new double[n];
// {
// Random rnd = new Random();
// for (int i = 0; i < n; i++)
// {
// Array[i] = rnd.NextDouble();
// Console.Write($"\n {Array[i]}");
// }
// }
// {
//     int i = 0;
// double max = Array[i];
// double min = Array[i];
// while (i < Array.Length)
// {
// if (max<Array[i])
// max = Array[i];
// if (min>Array[i])
// min = Array[i];
// i++; 
// }
// Console.Write($"\nРазница между максимальным и минимальным элементов массива: {max-min}");
// }