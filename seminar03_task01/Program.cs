// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки!
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number = Prompt("Введите число > ");

int firstNumber = number / 10000;
int secondNumber = (number / 1000) % 10;
int thirdNumber = (number / 100) % 10;
int forthNumber = (number / 10) % 10;
int fifthNumber = number % 10;

int Prompt(string message) //запросить число
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidateNumber(int inputNum) //проверить, что пятизначное
{
    if (inputNum > 9999 && inputNum < 100000)
    {
        return true;
    }
    Console.WriteLine($"В числе {number} не 5 знаков");
    return false;
}

if (ValidateNumber(number))

{
    if (firstNumber == fifthNumber && secondNumber == forthNumber)// Палиндром
    {
        Console.Write($"{number} -> да");
    }
    else
    {
        Console.Write($"{number} -> нет");
    }
}