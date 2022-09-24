// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

int Prompt(string message)
{
    Console.WriteLine(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int userNumber = Prompt("Введите трехзначное число > ");
if (userNumber < 1000 && userNumber > 99)
{
    int result = (userNumber / 10) % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}