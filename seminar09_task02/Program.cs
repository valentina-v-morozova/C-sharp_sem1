// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int numberM = Prompt("Введите число M > ");
int numberN = Prompt("Введите число N > ");
int numberPositivM = 0; // "костыль" для отрицательного М


SumNatural(numberM, numberN);

int Prompt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit)
    {
        return number;
    }
    throw new Exception("Вы ввели неверное значение");
}

void SumNatural(int numberM, int numberN)
{
    Console.Write(SumMN(numberM - 1, numberN));
}

int SumMN(int numberM, int numberN)
{
    if (numberM == numberN || numberM > numberN)
        return 0;
    else
    {
        if (numberM >= 1)
        {
            int res = numberM;
            numberM++;
            res = numberM + SumMN(numberM, numberN);
            return res;
        }
        else
        {
            int res = numberPositivM;
            numberPositivM++;
            res = numberPositivM + SumMN(numberPositivM, numberN);
            return res;
        }
    }
}