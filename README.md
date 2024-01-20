Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

[аттестация основной блок.drawio.pdf](https://github.com/war2510/certification_core_unit/files/13998351/drawio.pdf)

У нас есть список слов: яблоко, кот, собака, банан, небо, чашка.
Мы начинаем с подсчета слов, которые короче или равны трем буквам. Это наш первый проход по списку.
Затем мы создаем новый список, который будет содержать только короткие слова. Размер этого списка равен количеству коротких слов, которое мы подсчитали на первом шаге.
Наконец, мы делаем второй проход по исходному списку и добавляем короткие слова в новый список.
В итоге у нас есть два списка: исходный и новый, который содержит только короткие слова. Это и есть суть алгоритма, описанного в блок-схеме.



