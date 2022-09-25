// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidateNumber(int inputNum) //Валидация данных
{
    if (inputNum > 0)
    {
        return true;
    }
    Console.WriteLine("ваше число меньше 1");
    return false;
}

void Cube(int number)
{
    int index = 1;
    while (index <= number)
    {
        Console.Write($"{index * index * index}, ");
        index++;
    }
}

int number = Prompt("Введите число > ");

if (ValidateNumber(number))
{
    Console.WriteLine();
    Console.Write($"{number} -> ");
    Cube(number);
}