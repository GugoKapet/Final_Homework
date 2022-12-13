Console.WriteLine("Введите количество строк в масcиве");
bool isParsedStringsNumber = int.TryParse(Console.ReadLine(), out int stringsNumber);
if (!isParsedStringsNumber)
{
    Console.WriteLine("Неверно введены данные!");
    return;
}
string[] stringArray = new string[stringsNumber];
FillStringArray(stringArray);
string[] shortenedArray = CreateArrayWithMaximumThreeSymbols(stringArray);
Console.WriteLine("Элементы массива строк, отвечающие требованиям:");
PrintShortenedArray(shortenedArray);

void FillStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите символы строки {i + 1}");
        array[i] = Console.ReadLine();
    }
}

string[] CreateArrayWithMaximumThreeSymbols(string[] arrayy)
{
    string[] shortenedArray = new string[arrayy.Length];
    for (int i = 0; i < arrayy.Length; i++)
    {
        if (arrayy[i].Length <= 3)
        {
            shortenedArray[i] = arrayy[i];
        }
    }
    return shortenedArray;
}

void PrintShortenedArray(string[] arrayyy)
{
    for (int i = 0; i < arrayyy.Length; i++)
    {
        Console.WriteLine($"{arrayyy[i]} ");
    }
}
