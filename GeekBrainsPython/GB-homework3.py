# Задача 16: Требуется вычислить, сколько раз встречается некоторое число X в массиве A[1..N].
# Пользователь в первой строке вводит натуральное число N – количество элементов в массиве.
# В последующих  строках записаны N целых чисел Ai. Последняя строка содержит число X
#
# *Пример:*
#
# 5
#     1 2 3 4 5
#     3
#     -> 1


import random as r


n = int(input("Please, enter element's quantity in the array: "))
nums = [r.randint(1,10) for _ in range(n)]
print(*nums)
number = int(input("Please, enter the number: "))

print(f'Array consists our number {number} ---> {nums.count(number)} times')
#
# Задача 18: Требуется найти в массиве A[1..N] самый близкий по величине элемент к заданному числу X.
# Пользователь в первой строке вводит натуральное число N – количество элементов в массиве.
# В последующих  строках записаны N целых чисел Ai. Последняя строка содержит число X
#
# *Пример:*
#
# 5
#     1 2 3 4 5
#     6
#     -> 5
# import random as r
#
#
# n = int(input("Please, enter element's quantity in the array: "))
# nums = [r.randint(1, 100) for _ in range(n)]
# print(*nums)
# number = int(input("Please, enter your number: "))
# need_num = 0
# min_diff=sum(nums)
#
# for elem in nums:
#     diff = abs(elem-number)
#     if diff<min_diff:
#         min_diff=diff
#         need_num=elem
#
#
# print(f'The closest number from array is {need_num}')




#
# *Задача 20: * В настольной игре Скрабл (Scrabble) каждая буква имеет определенную ценность.
# В случае с английским алфавитом очки распределяются так:A, E, I, O, U, L, N, S, T, R – 1 очко; D, G – 2 очка;
# B, C, M, P – 3 очка; F, H, V, W, Y – 4 очка; K – 5 очков; J, X – 8 очков; Q, Z – 10 очков.
# А русские буквы оцениваются так: А, В, Е, И, Н, О, Р, С, Т – 1 очко; Д, К, Л, М, П, У – 2 очка;
# Б, Г, Ё, Ь, Я – 3 очка; Й, Ы – 4 очка; Ж, З, Х, Ц, Ч – 5 очков; Ш, Э, Ю – 8 очков; Ф, Щ, Ъ – 10 очков.
# Напишите программу, которая вычисляет стоимость введенного пользователем слова.
# Будем считать, что на вход подается только одно слово, которое содержит либо только английские, либо только русские буквы.

# dict_score = {
#     ('A', 'E', 'I', 'O', 'U', 'L', 'N', 'S', 'T', 'R') : 1,
#     ('D', 'G') : 2,
#     ('B', 'C', 'M', 'P') : 3,
#     ('F', 'H', 'V', 'W', 'Y') : 4,
#     ('K',) : 5,
#     ('J', 'X') : 8,
#     ('Q', 'Z') : 10,
#     ('А', 'В', 'Е', 'И', 'Н', 'О', 'Р', 'С', 'Т'):1,
#     ('Д', 'К', 'Л', 'М', 'П', 'У') : 2,
#     ('Б', 'Г', 'Ё', 'Ь', 'Я') : 3,
#     ('Й', 'Ы') : 4,
#     ('Ж', 'З', 'Х', 'Ц', 'Ч') : 5,
#     ('Ш', 'Э', 'Ю') : 8,
#     ('Ф', 'Щ', 'Ъ') : 10
#
# }
# word = input('Please, enter your word: ')
# total_score = 0
# for key, value in dict_score.items():
#     for char in word.upper():
#         if char in key:
#             total_score+=dict_score[key]
#
# print(f'Total score of your word is {total_score}')

