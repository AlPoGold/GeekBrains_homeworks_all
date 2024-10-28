# Задача 10: На столе лежат n монеток. Некоторые из них лежат вверх
# решкой, а некоторые – гербом. Определите минимальное число
# монеток, которые нужно перевернуть, чтобы все монетки были
# повернуты вверх одной и той же стороной. Выведите минимальное
# количество монет, которые нужно перевернуть.
#
# import random as r
# total_coins=int(input())
#
# heads=0
# tails=0
# while total_coins>0:
#     coin = r.randint(0,1)
#     if coin==1:
#         print('Your coin is head')
#         heads+=1
#     else:
#         print('Your coin is tail')
#         tails+=1
#     total_coins-=1
# if tails > heads:
#     print(heads)
# else:
#     print(tails)



# Задача 12: Петя и Катя – брат и сестра. Петя – студент, а Катя –
# школьница. Петя помогает Кате по математике. Он задумывает два
# натуральных числа X и Y (X,Y≤1000), а Катя должна их отгадать. Для
# этого Петя делает две подсказки. Он называет сумму этих чисел S и их
# произведение P. Помогите Кате отгадать задуманные Петей числа.
# sum_xy = int(input())
# mult_xy = int(input())
# for x in range(1, 1001):
#     for y in range(1, 1001):
#         if x*y==mult_xy and x+y==sum_xy:
#             print(x, y)
#             break




# Задача 14: Требуется вывести все целые степени двойки (т.е. числа
# вида 2 k
# ), не превосходящие числа N


number = int(input('Please, enter your number: '))
pow_count = 1
while number > 2:
    print(2**pow_count)
    pow_count+=1
    number /=2



