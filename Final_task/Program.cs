Console.WriteLine("Введите количество строк в масcиве");
bool isParsedStringsNumber = int.TryParse(Console.ReadLine(), out int stringsNumber);
if (!isParsedStringsNumber)
{
    Console.WriteLine("Неверно введены данные!");
    return;
}
string[] stringArray = new string[stringsNumber];
