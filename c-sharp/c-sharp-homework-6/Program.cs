// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Console.Write("Please, enter the quantity numbers in your massive: ");
// int size = int.Parse(Console.ReadLine()!);
// int[] myArray = new int[size];
// int count = 0;
// for(int i = 0; i<size; i++)
// {
//     Console.Write("Enter the number: ");
//     myArray[i] = int.Parse(Console.ReadLine()!);
//     if(myArray[i]>0) count++;
// }
// Console.WriteLine($"In your massive there are {count} numbers larger than 0");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

string CrossCoordinates(double b1, double b2, double k1, double k2)
{
    double x;
    double y;
    double diffB = b2 - b1;
    double diffK = k1 - k2;
    x = diffB / diffK;
    y = (k1 * x + b1);
    return $"({x}; {y})";
}
Console.Write("Please, enter the coeffients[b1, b2, k1, k2] with spaces between: ");
string[] line = Console.ReadLine().Split(" ");
double b1 = double.Parse(line[0]);
double b2 = double.Parse(line[1]);
double k1 = double.Parse(line[2]);
double k2 = double.Parse(line[3]);

Console.WriteLine(CrossCoordinates(b1, b2, k1, k2));