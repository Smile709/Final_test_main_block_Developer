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

string[] array1 = { "Hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

int CountRequiredElements(string[] arr, int max)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= max) count++;
    }
    return count;
}

string[] RequiredElementsArray(string[] arr, int max)
{
    int arrlength = CountRequiredElements(arr, max);
    string[] resultArray = new string[arrlength];
    int resultArrayIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= max)
        {
            resultArray[resultArrayIndex] = arr[i];
            resultArrayIndex++;
        }
    }
    return resultArray;
}

void PrintArray(string[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}

System.Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Red;
PrintArray(array1);
Console.ForegroundColor = ConsoleColor.White;
System.Console.Write("->");
Console.ForegroundColor = ConsoleColor.Green;
PrintArray(RequiredElementsArray(array1, max));

System.Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Red;
PrintArray(array2);
Console.ForegroundColor = ConsoleColor.White;
System.Console.Write("->");
Console.ForegroundColor = ConsoleColor.Green;
PrintArray(RequiredElementsArray(array2, max));

System.Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Red;
PrintArray(array3);
Console.ForegroundColor = ConsoleColor.White;
System.Console.Write("->");
Console.ForegroundColor = ConsoleColor.Green;
PrintArray(RequiredElementsArray(array3, max));
Console.ForegroundColor = ConsoleColor.White;
