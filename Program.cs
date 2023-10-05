/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

Console.Clear();

System.Console.WriteLine("Введи желаемую Максимальную длинну элемента в символах: ");
int max = Convert.ToInt32(Console.ReadLine());

string[] array {"Hello","2","world",":-)"};

void CountRequiredElements(string[] arr, int max)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= max) count++;
    }
    return count;
}

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}

int[] CopyArray(int[] array)
{
    int[] arrayCopy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayCopy[i] = array[i];
    }
    return arrayCopy;
}

int[] array = GetRandomArray(arrayL, min, max);
int[] userArray = CopyArray(array);
Console.ForegroundColor = ConsoleColor.Red;
PrintArray(array);
Console.ForegroundColor = ConsoleColor.Green;
PrintArray(userArray);
Console.ForegroundColor = ConsoleColor.White;
