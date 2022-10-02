// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7.4, 22.3, 2, 78] -> 76

const int MIN_ELEMENTS = -10;
const int MAX_ELEMENTS = 10;
int length = Prompt("Введите длину массива > ");

int Prompt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit)
    {
        return number;
    }
    throw new Exception("Вы ввели не число");
}

double[] GenerateArray(int length)
{
    double[] numbers = new double[length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(MIN_ELEMENTS, MAX_ELEMENTS) + new Random().NextDouble(); //
    }
    return numbers;
}

void PrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write($"{numbers[i]:f2} \t");
    }
    System.Console.WriteLine();
}

double MinElement(double[] number)
{
    double minElement = number[0];
    for (int i = 1; i < number.Length; i++)
    {
        if (minElement > number[i])
        {
            minElement = number[i];
        }
    }
    return minElement;
}

double MaxElement(double[] number)
{
    double maxElement = number[0];
    for (int i = 1; i < number.Length; i++)
    {
        if (maxElement < number[i])
        {
            maxElement = number[i];
        }
    }
    return maxElement;
}

double[] array = GenerateArray(length);
PrintArray(array);
System.Console.WriteLine($"Минимальный элемент {MinElement(array):f2}");
System.Console.WriteLine($"Максимальный элемент {MaxElement(array):f2}");
System.Console.WriteLine($"Разница между элементами {(MaxElement(array) - MinElement(array)):f2}");