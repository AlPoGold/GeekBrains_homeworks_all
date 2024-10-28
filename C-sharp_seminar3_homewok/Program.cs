/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

// Console.Write("Please, enter your 5-digit number:");
// int num = int.Parse(Console.ReadLine());
// int firstNum = num/10000;
// int secondNum = (num%10000)/1000;
// int thirdNum = (num%10000)%1000/100;
// int forthNum = num%10000%1000%100/10;
// int fifthNum = num%10;

// Console.WriteLine($"{firstNum}, {secondNum}, {thirdNum}, {forthNum}, {fifthNum}");
// string result = (firstNum==fifthNum && secondNum==forthNum)?("YES. Its palindrome"):("NO. It isnt palindrome!");
// Console.WriteLine(result);


//Second version with massives:
// Console.Write("Please, enter your 5-digit number:");
// int num = int.Parse(Console.ReadLine());
// int[] array = new int[5];
// int j = 10000;
// for (int i = 0; i < 5; i++)
// {
//     array[i] = num / j;
//     num = num%j;
//     j /= 10;
// }
// Console.WriteLine( $"{array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}");

// if (array[0] == array[4] && array[1] == array[3])
// {
//     Console.WriteLine("YES, its palindrome!");
// }
// else
// {
//     Console.WriteLine("NO, it isnt palindrome");
// }

/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/
// Console.Write("Please, enter first triplet numbers with space between:");
// string[] splitString1 = Console.ReadLine().Split(' ');
// int x1 = int.Parse(splitString1[0]);
// int y1 = int.Parse(splitString1[1]);
// int z1 = int.Parse(splitString1[2]);

// Console.Write("Please, enter second triplet numbers with space between:");
// string[] splitString2 = Console.ReadLine().Split(' ');
// int x2 = int.Parse(splitString2[0]);
// int y2 = int.Parse(splitString2[1]);
// int z2 = int.Parse(splitString2[2]);

// double result = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)), 2);
// Console.WriteLine($"The distance is {result}");

// Second version:

// double[] parseCoordinates(string stringAnswer)
// {
//     double[] coordinates = new double[3]; 
//     string[] splitString = stringAnswer.Split(' ');
//     for(int i = 0; i < splitString.Length; i++)
//     {
//         coordinates[i] = double.Parse(splitString[i]);  
//     }

//     return coordinates;

// }


// Console.Write("Please, enter first triplet numbers with space between:");
// string answerUser1 = Console.ReadLine();

// Console.Write("Please, enter second triplet numbers with space between:");
// string answerUser2 = Console.ReadLine();


// double result = 0;

// for (int i = 0; i < 3; i++)
// {
//     double part = Math.Pow(parseCoordinates(answerUser1)[i] - parseCoordinates(answerUser2)[i], 2);
//     result += part;
// }
// Console.WriteLine($"The distance is {Math.Round(Math.Sqrt(result), 2)}");

/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

*/
// Console.Write("Please, enter your number:");
// double num = double.Parse(Console.ReadLine());
// for ( double i = 1; i <= num; i++)
// {
//     double result = Math.Pow(i, 3);
//     Console.WriteLine($"Raising {i} to the third power is {result}");
// }