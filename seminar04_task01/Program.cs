// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int firstNumber = Prompt("Введите число 1 > ");
int secondNumber = Prompt("Введите число 2 > ");


int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Degree(int n)
{
    int degree = firstNumber;
    for (int i = 1; i <= secondNumber; i = i - 1)
    {
        degree = firstNumber * degree;
    }
    return degree;
}


int result = Degree(firstNumber);
Console.WriteLine($"{firstNumber}, {secondNumber} -> {result}");