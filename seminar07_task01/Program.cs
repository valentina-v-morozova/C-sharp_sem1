//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

const int MIN_ELEMENTS = -100;
const int MAX_ELEMENTS = 100;

int length = Prompt("Введите количество столбцов > ");
int height = Prompt("Введите количество строк > ");
double[,] numbers = new double[height, length];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

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

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(MIN_ELEMENTS, MAX_ELEMENTS));
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine("");
    }
}