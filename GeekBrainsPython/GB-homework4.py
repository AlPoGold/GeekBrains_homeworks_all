# Задача 22: Даны два неупорядоченных набора целых чисел (может быть, с повторениями).
# Выдать без повторений в порядке возрастания все те числа, которые встречаются в обоих наборах.
# Пользователь вводит 2 числа. n — кол-во элементов первого множества. m — кол-во элементов второго множества.
# Затем пользователь вводит сами элементы множеств.

# import random as r
#
# numbers1 = [r.randint(1,10) for _ in range(int(input()))]
# print(numbers1)
#
# numbers2 = [r.randint(1,10) for _ in range(int(input()))]
# print(numbers2)
#
# new_set = set(numbers1).intersection(set(numbers2))
# print(sorted(list(new_set)))
#
# Задача 24: В фермерском хозяйстве в Карелии выращивают чернику.
# Она растёт на круглой грядке, причём кусты высажены только по окружности.
# Таким образом, у каждого куста есть ровно два соседних. Всего на грядке растёт N кустов.
# Эти кусты обладают разной урожайностью, поэтому ко времени сбора на них выросло
# различное число ягод — на i-ом кусте выросло ai ягод.
# В этом фермерском хозяйстве внедрена система автоматического сбора черники.
# Эта система состоит из управляющего модуля и нескольких собирающих модулей.
# Собирающий модуль за один заход, находясь непосредственно перед некоторым кустом,
# собирает ягоды с этого куста и с двух соседних с ним.
# Напишите программу для нахождения максимального числа ягод, которое может собрать за один
# заход собирающий модуль, находясь перед некоторым кустом заданной во входном файле грядки.

import random as r
count_bush = int(input())
berries = [r.randint(1,10) for _ in range(count_bush)]
print(berries)
dict_berries = {}


for i in range(count_bush):
    total_berries = 0
    if i==0:
        total_berries=berries[i]+berries[i+1]
        dict_berries[i+1] = dict_berries.setdefault(i + 1, total_berries)
    elif i==count_bush-1:
        total_berries=berries[count_bush-1]+berries[count_bush-2]
        dict_berries[i+1] = dict_berries.setdefault(i + 1, total_berries)
    else:
        total_berries+=berries[i]+berries[i+1]+berries[i-1]
        dict_berries[i+1] = dict_berries.setdefault(i+1, total_berries)


print(dict_berries)

print(max(dict_berries.items(), key=lambda x:x[1]))
