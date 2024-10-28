// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Please, enter three-digit number: ");
// string numString = Console.ReadLine();
// int number = int.Parse(numString);
// if(number > 99 && number < 1000)
// {

//     int needNum = (number%100)/10;
//     Console.WriteLine($"The second digit from your number is {needNum}");
// }
// else
// {
//     Console.WriteLine("Please, reenter the number. Your number is wrong!");
// }
// Задача 13: Напишите программу, которая выводит третью цифру ПЯТИЗНАЧНОГО числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
// Console.Write("Please, enter the number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num<100)
// {
//     Console.WriteLine($"In your number {num} there isn't third digit!");
// }
// else{
//     Console.WriteLine((num%1000)/100);
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Please, enter day's number: ");
int day = int.Parse(Console.ReadLine());
if (day <= 7 && day > 0)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}
else
{
    Console.WriteLine("Please, reenter the number. Your number doesnt belong to week's days!");
}