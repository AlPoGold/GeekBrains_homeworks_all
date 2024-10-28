// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.Write("Please, enter 2 numbers with space between: number and power: ");
// string[] array = Console.ReadLine()!.Split();
// int number = int.Parse(array[0]);
// int power = int.Parse(array[1]);

// Console.WriteLine($"{number} in {power} power equal {Math.Pow(number, power)}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.Write("Please, enter the number: ");
// int number = int.Parse(Console.ReadLine()!);
// int sum = 0;
// for(int i = number; i>0; i/=10)
// {
//     int digit = i%10;
//     sum+=digit;
    
// }
// Console.WriteLine($"Summary of digits in {number} equals {sum}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

void printArray(int[] array)
{
    foreach(int elem in array) Console.Write(elem + " ");
}

int[] myArray = new int[8];
for(int i=0;i< myArray.Length; i++) myArray[i] = new Random().Next(0, 100);
printArray(myArray);