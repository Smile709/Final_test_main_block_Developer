# Задание
1) Создать репозиторий на GitHub
2) Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3) Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4) Написать программу, решающую поставленную задачу
5) Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)
## Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Примеры: 
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”] [“1234”, “1567”, “-2”, “computer science”] → [“-2”] [“Russia”, “Denmark”, “Kazan”] → []

# Решение:

1) Создаем массив строк со значениями из примера.
2) Создаем метод, принимающий массив строк и желаемое количество символов в искомых элементах, возвращающий количество подходящих элементов.
3) В методе производим подсчет строк подходящего размера
4) Создаём метод принимающий исходный массив и количество строк подходящего размера, возвращающий результирующий массив заполненый подходящими строками.
5) В методе пробегаем по исходному массиву и присваеваем значение подходящих строк каждому следующему элементу результирующего массива.
6) Печатаем в консоль элементы результирующего массива, разделяя их запятой с пробелом.