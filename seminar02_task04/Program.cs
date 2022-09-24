// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели ->");
string strValue = Console.ReadLine() ?? "0";
int value = int.Parse(strValue);

if (value > 0 && value < 8)
{
    if (value == 6 | value == 7)
    {
        Console.Write($"{value} день недели - выходной");
    }
    else
    {
        Console.Write($"{value} день недели - будний день");
    }
}
else
{
    Console.Write($"Это не день недели");
}