// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

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
int thirdValue = Prompt("Введите третье число > ");
int maxValue = firstValue;


if (secondValue > firstValue)
{
    maxValue = secondValue;
}
    if (thirdValue > maxValue)
    {
        maxValue = thirdValue;
    }
System.Console.WriteLine($"{firstValue} {secondValue} {thirdValue} -> {maxValue}");