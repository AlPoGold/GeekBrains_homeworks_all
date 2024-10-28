// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
// Console.Write("Please, enter size of your array: ");
// int size = int.Parse(Console.ReadLine());
// int[] myArray = new int[size];
// int count = 0;
// for(int i = 0; i < size; i++)
// {
//     myArray[i] = new Random().Next(100, 1000);
//     if (myArray[i]%2 ==0) count++;

    
// }
// for(int i = 0; i < size;i++) Console.Write($"{myArray[i]} ");
// Console.WriteLine();
// Console.WriteLine($"The quantity of even numbers in your array {count}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Console.Write("Please, enter size of your array: ");
// int size = int.Parse(Console.ReadLine()!);
// int[] myArray = new int[size];
// int sum = 0;
// var rand = new Random();
// for(int i = 0; i < size; i++)
// {
//     myArray[i] = rand.Next(-100, 101);
//     if (i%2 == 1) sum += myArray[i];

    
// }
// Console.Write($"Your array is {String.Join(", ", myArray)} ");
// Console.WriteLine();
// Console.WriteLine($"The summary of numbers on odd position in your array {sum}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// double[] ReturnFloatArray(int size)
// {
//     var rand = new Random();
//     double[] myArray = new double[size];
//     for (int i = 0; i < size; i++) myArray[i] = Math.Round((rand.NextDouble() * rand.Next(1, 1000)), 2);
//     return myArray;
// }


// Console.Write("Please, enter size of your array: ");
// int size = int.Parse(Console.ReadLine()!);
// double[] randomArray = ReturnFloatArray(size);
// Console.WriteLine($"{String.Join("  ", randomArray)}");

// double max = randomArray[0];
// double min = randomArray[0];

// foreach (double x in randomArray)
// {
//     if (x > max) max = x;
//     if (x < min) min = x;
// }
// Console.WriteLine($"Difference between maximum {max} and minumum {min} equals {max - min}");