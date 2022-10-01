// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int number = Prompt("Введите число > ");

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SummNumber(int n)
{
    int sum = 0;
    int num = number;
    for (int i = 0; num > 0; i++)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

int result = SummNumber(number);
Console.WriteLine($"{number} -> {result}");