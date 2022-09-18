// Задача 1: Напишите программу, которая на вход
// принимает два числа и выдаёт,какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7, min = 5
// a = -9 b = -3 -> max = -3, min = -9

// Ввод числа из консоли по приглашению
int Prompt(string message)
{
    System.Console.Write(message);        //Вывод приглашения
    string strValue;                      //Объявляем переменной для ввода строки
    strValue = Console.ReadLine() ?? "0"; //Вводим строку с консоли (можно ввести только строку)
    int value = int.Parse(strValue);      //Преобразование строки в целое число
    return value;
}

int firstValue = Prompt("Введите первое число > ");
int secondValue = Prompt("Введите второе число > ");

if(secondValue > firstValue)
{
System.Console.WriteLine($"max = {secondValue}, min = {firstValue}");
}
else
{
System.Console.WriteLine($"max = {firstValue}, min = {secondValue}");
}