// Задача: 
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ['1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.WriteLine("Заданный массив: ");
string[] firstArray = {"из", "под", "топота", "копыт", "пыль", "по", "полю", "летит"};

PrintArray(firstArray);

int count = 3; // количество допустимых элементов

string[] secondArray = new string[firstArray.Length];
for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i].Length <= count)
    {
        secondArray[i] = firstArray[i];
    }
}

Console.WriteLine();
Console.WriteLine("Показаны элементы имеющегося массива не более чем с тремя символами: ");
PrintArray(secondArray);

void PrintArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] != null)
        if (i == Array.Length - 1)
        {
            Console.WriteLine($"\"{Array[i]}\"");
        }
        else
        {
            Console.Write($"\"{Array[i]}\",");
        }
    }
}