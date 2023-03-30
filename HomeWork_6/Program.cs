// // //Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // Console.WriteLine("Введите количество элементов массива: ");
// // int M = int.Parse(Console.ReadLine()!);
// // int[] Array = new int[M];
// // int count = 0;
// // for (int i = 0; i < M; i++)
// // {
// //     Console.WriteLine("Введите {0}-й элемент", i + 1);
// //     Array[i] = int.Parse(Console.ReadLine()!);
// //     if (Array[i] > 0)
// //     {
// //         count++;
// //     }
// // }
// // Console.WriteLine("\nМассив: {0}", String.Join(" ", Array));
// // Console.Write($"Количество положительных чисел {count}");

// //Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// //y = k1 * x + b1, y = k2 * x + b2
// Console.WriteLine("Введите k1: ");
// double k1 = double.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите b1: ");
// double b1 = double.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите k2: ");
// double k2 = double.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите b2: ");
// double b2 = double.Parse(Console.ReadLine()!);
// double y;
// double x;
// y = k1 * (b2 - b1) / (k1 - k2) + b1;
// x = (b2 - b1) / (k1 - k2);
// if (k1 == k2 && b1 == b2)
// { Console.Write($"прямые совпадают"); }
// else if (k1 * b2 - b1 * k2 == 0)
// { Console.Write($"прямые параллельны"); }
// else
// { Console.Write($"Точка пересечения M({x};{y})"); }

