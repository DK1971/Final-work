## Задача:

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### Описание алгоритма решения:

1) Сначала объявляется два массива: **Array1** - заполненный значениями из строк и **Array2** - такой же длины, но без заполнения массива элементами;

2) Выводим массив **Array1** в консоли при помощи метода **PrintArray**;

3) Далее при помощи метода **SecondArray** путём сортировки массива **Array1** и выполнения условия выборки строк, длина которых **<=3**, перебираются все элементы массива;

4) Если в массиве **Array1** цикл определяет элемент, соответствующий условиям выборки, тогда значение этого элемента записывается в ячейку второго массива **Array2**;

5) Выводим элементы отобранные и сохранённые в массив **Array2** в консоли при помощи метода **PrintArray**.
