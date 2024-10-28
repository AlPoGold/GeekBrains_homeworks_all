// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Write("Enter first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//     Console.WriteLine("The biggest number: " + num1);
// }
// else
// {
//     Console.WriteLine("The biggest number: " + num2);
// }

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


// int max = 0;
// Console.Write("Enter first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if(num1>max)
// {
//     max = num1;
// }

// Console.Write("Enter second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if(num2>max)
// {
//     max = num2;
// }

// Console.Write("Enter third number: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// if(num3>max)
// {
//     max = num3;
// }
// Console.WriteLine("The biggest number: " + max);


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.Write("Enter the number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num%2==0){
//     Console.WriteLine(num + " - even number");
// }
// else
// {
//     Console.WriteLine(num + " - odd number");
// }


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());
int start_num = 1;
while (start_num <= num)
{
    if(start_num%2==0)
    {
        Console.WriteLine(start_num);
        
    }
    start_num++;
} 