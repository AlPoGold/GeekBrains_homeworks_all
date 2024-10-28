# Задача 2: Найдите сумму цифр трехзначного числа.
#
# *Пример:*
#
# 123 -> 6 (1 + 2 + 3)
# 100 -> 1 (1 + 0 + 0) |

# number = int(input('Please, enter your number: '))
# total=0
# while number!=0:
#     total+=number%10
#     number//=10
# print(f'The sum of digits equals {total}')
#
# Задача 4: Петя, Катя и Сережа делают из бумаги журавликов.
# Вместе они сделали S журавликов. Сколько журавликов сделал каждый ребенок, если известно,
# что Петя и Сережа сделали одинаковое количество журавликов, а Катя сделала в два раза больше журавликов,
# чем Петя и Сережа вместе?
#
# *Пример:*
#
# 6 -> 1  4  1
# 24 -> 4  16  4
#     60 -> 10  40  10
#
# total_cranes = int(input("Please, enter total number of childrens' cranes: "))
# petya = 0
# sergey = 0
# katya = 0
# residue='s'
# for i in range(1, total_cranes+1):
#     petya=sergey=i
#     katya=(i+i)*2
#     if petya+sergey+katya==total_cranes:
#         print(f'Katya has made {katya} cranes', f'Sergey has made {sergey} cranes', f'Petya has made {petya} cranes', sep='\n')
#         break
#
# Задача 6: Вы пользуетесь общественным транспортом? Вероятно, вы расплачивались за проезд и получали билет с номером.
# Счастливым билетом называют такой билет с шестизначным номером, где сумма первых трех цифр равна сумме последних трех.
# Т.е. билет с номером 385916 – счастливый, т.к. 3+8+5=9+1+6.
# Вам требуется написать программу, которая проверяет счастливость билета.
#
# *Пример:*
#
# 385916 -> yes
# 123456 -> no
# ticket = input('Please, enter number of your ticket in format XXXXXX\nand i will tell you is it lucky or not: ')
# while (len(ticket)!=6 or not ticket.isdigit()):
#     print('Wrong format. Reenter!')
#     ticket = input('Please, enter number of your ticket in format XXXXXX: ')
# part1 = sum([int(i) for i in ticket[:3]])
# part2 = sum([int(i) for i in ticket[3:]])
# if part1==part2:
#     print('YES, you are lucky=)')
# else:
#     print('NO, sorry')
#
# Задача 8: Требуется определить, можно ли от шоколадки размером n × m долек отломить k долек,
# если разрешается сделать один разлом по прямой между дольками (то есть разломить шоколадку на два прямоугольника).
#
# *Пример:*
#
# 3 2 4 -> yes
# 3 2 1 -> no
#
n, m, k = [int(i) for i in input('Please, enter size of chocolate"s tablet(n x m) and quanity of pieces (k)\n in format n m k: ').split()]
if n*m > k:
    print('YES' if k%n==0 or k%m==0 else 'NO') # смотрим делится ли количество долек на  какую-нибудь сторону нацело, чтобы можно было бы сделать ТОЛЬКО один разлом
else:
    print('NO')
