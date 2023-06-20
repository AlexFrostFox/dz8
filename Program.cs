// Для проверки работы нужной программы нужно выделить код и нажать сочетание кнопок "Ctrl+/",
// далее ввести команду "dotnet run" в терминале

//=================================================================

// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

//Решение:

// using System;
// using System.Linq;

// namespace n
// {

//     internal class Program
//     {
//         private static void Main(string[] args)
//         {

//             var matrix = new int[9, 5];
//             var rnd = new Random();

//             for (int i = 0; i < matrix.GetLength(0); i++)
//             {
//                 for (int j = 0; j < matrix.GetLength(1); j++)
//                 {
//                     matrix[i, j] = rnd.Next(12, 45);
//                     Console.Write(matrix[i, j] + " ");
//                 }
//                 Console.WriteLine();
//             }
//             Console.WriteLine();

//             var arr = matrix.Cast<int>().OrderByDescending(a => a).ToArray();

//             int c = 0;
//             for (int j = 0; j < matrix.GetLength(0); j++)
//             {
//                 for (int k = 0; k < matrix.GetLength(1); k++)
//                 {
//                     matrix[j, k] = arr[c];
//                     Console.Write(matrix[j, k] + " ");
//                     c++;
//                 }
//                 Console.WriteLine();
//             }
//             Console.ReadKey();
//         }
//     }
// }

//=================================================================

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

//Решение:

// Console.WriteLine("Введите размер массива m x n и диапазон случайных значений:");
// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");
// int range = InputNumbers("Введите диапазон: от 1 до ");

// int[,] array = new int[m, n];
// CreateArray(array);
// WriteArray(array);

// int minSumLine = 0;
// int sumLine = SumLineElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//     int tempSumLine = SumLineElements(array, i);
//     if (sumLine > tempSumLine)
//     {
//         sumLine = tempSumLine;
//         minSumLine = i;
//     }
// }

// Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");


// int SumLineElements(int[,] array, int i)
// {
//     int sumLine = array[i, 0];
//     for (int j = 1; j < array.GetLength(1); j++)
//     {
//         sumLine += array[i, j];
//     }
//     return sumLine;
// }

// int InputNumbers(string input)
// {
//     Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
// }

// void CreateArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(range);
//         }
//     }
// }

// void WriteArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

//=================================================================