// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int numberM = Prompt("Введите неотрицательное число M > ");
int numberN = Prompt("Введите неотрицательное число N > ");

AkkermanFunction(numberM, numberN);

int Prompt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit)
    {
        return number;
    }
    else
    {
        throw new Exception("Вы ввели неверное значение");
    }
}

void AkkermanFunction(int numberM, int numberN)
{
    if (numberM < 0)
    {
        Console.Write($"\nКак минимум, одно  из чисел меньше нуля. Введенные данные не соответствуют условиям задачи");
    }
    else
    {
        Console.Write(Akkerman(numberM, numberN));
    }
}

int Akkerman(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    else if (numberN == 0 && numberM > 0)
    {
        return Akkerman(numberM - 1, 1);
    }
    else
    {
        return (Akkerman(numberM - 1, Akkerman(numberM, numberN - 1)));
    }
}