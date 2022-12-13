Console.WriteLine("Введите количество строк в масcиве");
bool isParsedStringsNumber = int.TryParse(Console.ReadLine(), out int stringsNumber);
if (!isParsedStringsNumber)
{
    Console.WriteLine("Неверно введены данные!");
    return;
}
string[] stringArray = new string[stringsNumber];

FillStringArray(stringArray);
void FillStringArray(string[] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите символы строки {i+1}");
    array[i] = Console.ReadLine();
}
}
