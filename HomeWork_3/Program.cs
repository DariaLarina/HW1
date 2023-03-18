// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// Console.Write("Введите пятизначное число: ");
// string number = Console.ReadLine()!;
// if (number.Length == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//     Console.WriteLine($"{number} -> паллиндром");
//     }
//     else {
//     Console.WriteLine($"{number} -> не паллиндром");
//      }
// }
// if (number.Length != 5) 
// {
//     Console.WriteLine($"{number} -> не пятизначное число");
// }

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// int[] coords1 = new int [3];
// int[] coords2 = new int [3];
// Console.Write("Введите число x1: ");
// coords1[0] = Convert.ToInt32(Console.ReadLine()!);
// Console.Write("Введите число y1: ");
// coords1[1] = Convert.ToInt32(Console.ReadLine()!);
// Console.Write("Введите число z1: ");
// coords1[2] = Convert.ToInt32(Console.ReadLine()!);
// Console.Write("Введите число x2: ");
// coords2[0] = Convert.ToInt32(Console.ReadLine()!);
// Console.Write("Введите число y2: ");
// coords2[1] = Convert.ToInt32(Console.ReadLine()!);
// Console.Write("Введите число z2: ");
// coords2[2] = Convert.ToInt32(Console.ReadLine()!);

// double d = Math.Pow((Math.Pow(coords2[0] - coords1[0], 2) + Math.Pow(coords2[1] - coords1[1], 2) + Math.Pow(coords2[2] - coords1[2], 2) *1.0), 0.5);

// Console.WriteLine("A[{0}]", string.Join(", ", coords1));
// Console.WriteLine("B[{0}]", string.Join(", ", coords2));
// Console.WriteLine("Расстояние между двумя точками - " + d);

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Console.Write("Введите число: ");
// int num= int.Parse(Console.ReadLine()!);
// int d = 3;
// for (int n = 1; n <= num; n++)
//    Console.WriteLine((long)Math.Pow(d, n));

// или

// Console.Write("Введите число: ");
// int num= int.Parse(Console.ReadLine()!);
// int n = 1;
// while (n <= num)
// {
//    int a3 = n*n*n;
// Console.WriteLine($"{a3}");
//     n++;
// }

