# Задача 26:  Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B
# с помощью рекурсии.
#
# *Пример:*
#
# A = 3; B = 5 -> 243 (3⁵)
#     A = 2; B = 3 -> 8
#
# a, b = [int(i) for i in input("Please, enter 2 numbers with space between: ").split()]
# def number_in_pow(num1, num2):
#     if num2==0:
#         return 1
#     return num1*number_in_pow(num1, num2-1)
#
# print(number_in_pow(a,b))


# Задача 28: Напишите рекурсивную функцию sum(a, b), возвращающую сумму двух целых неотрицательных чисел.
# Из всех арифметических операций допускаются только +1 и -1. Также нельзя использовать циклы.
#
# *Пример:*
#
# 2 2
#     4
#
a, b = [int(i) for i in input("Please, enter 2 numbers with space between: ").split()]
def recursive_sum(num1, num2):
    if num1==0:
        return num2
    else:
        return recursive_sum(num1-1, num2+1)


print(recursive_sum(a, b))