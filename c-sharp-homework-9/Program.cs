// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// Console.Write("Please, enter your number: ");
// int number = int.Parse(Console.ReadLine()!);
// string NumRec(int num)
// {
//     string result = String.Empty;
 
//     if (num == 1) return result+Convert.ToString(1);
//     else return result = Convert.ToString(num) + ", " + NumRec(num - 1);

// }
// Console.WriteLine(NumRec(number));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Please, enter your numbers with space between: ");
// int[] numbers = Numbers(Console.ReadLine()!);
// int num1 = numbers[0];
// int num2 = numbers[1];
// int[] Numbers(string userInput)
// {
//     string[] line = userInput.Split(" ");
//     int[] nums = new int[line.Length];
//     for (int i = 0; i < nums.Length; i++) nums[i] = int.Parse(line[i]);
//     return nums;
// }


// int SumRec(int n, int m)
// {
    
//     if (n > m) return 0;
//     else return m +  SumRec(n, m - 1);

// }
// Console.WriteLine($"Summary of natural numbers {num1} and {num2} equals {SumRec(num1, num2)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("Please, enter your numbers with space between: ");
// int[] numbers = Numbers(Console.ReadLine()!);
// int m = numbers[0];
// int n = numbers[1];
// int[] Numbers(string userInput)
// {
//     string[] line = userInput.Split(" ");
//     int[] nums = new int[line.Length];
//     for (int i = 0; i < nums.Length; i++) nums[i] = int.Parse(line[i]);
//     return nums;
// }


// int AkkermanMethod(int m, int n)
// {

//     if (m == 0)
//         return n + 1;
//     else if (m > 0 && n == 0)
//         return AkkermanMethod(m - 1, 1);
//     else if (m > 0 && n > 0)
//         return AkkermanMethod(m - 1, AkkermanMethod(m, n - 1));
//     return AkkermanMethod(m, n);

// }
// Console.WriteLine($"{AkkermanMethod(m,n)}");