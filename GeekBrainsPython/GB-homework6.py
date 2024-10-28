# Задача 30:  Заполните массив элементами арифметической прогрессии.
# Её первый элемент, разность и количество элементов нужно ввести с клавиатуры.
# Формула для получения n-го члена прогрессии: an = a1 + (n-1) * d.
# Каждое число вводится с новой строки.
#
# def arifmetic_progression(first_element, diff, count):
#     arif_list = []
#     for i in range(count):
#         arif_list.append(first_element + diff*i)
#     return arif_list
#
# print(*arifmetic_progression(1, 20, 10))

# Задача 32: Определить индексы элементов массива (списка),
# значения которых принадлежат заданному диапазону (т.е. не меньше заданного минимума и не больше заданного максимума)
import random as r
min_value, max_value = [int(i) for i in input().split()]
arrange = [i for i in range(min_value, max_value+1)]
array = [r.randint(1, 10) for _ in range(20)]
print(*array)
index_list = []
for i, elem in enumerate(array):
    if elem in arrange:
        index_list.append(i)
print(*index_list)


