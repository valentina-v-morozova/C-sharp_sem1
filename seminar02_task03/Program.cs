// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int userNumber = Prompt("Введите число > ");

if (userNumber < 100)
{
    Console.WriteLine($"{userNumber} -> в этом числе нет 3 цифры");
}
else
{
    int newNumber = userNumber;
    while (newNumber > 1000)
    {
        newNumber = newNumber / 10;
    }
    int thirdNumber = newNumber % 10;
    Console.WriteLine($"{userNumber} -> {thirdNumber}");
}
