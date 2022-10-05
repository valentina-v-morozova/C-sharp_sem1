//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

const int MIN_ELEMENTS = -10;
const int MAX_ELEMENTS = 10;
const int MIN_SIZE = 3;
const int MAX_SIZE = 10;

int height = new Random().Next(MIN_SIZE, MAX_SIZE);
int length = new Random().Next(MIN_SIZE, MAX_SIZE);
int line = Prompt("Введите номер строки > ");
int coll = Prompt("Введите номер столбца > ");
int[,] numbers = new int[height, length];

FillArrayRandomNumbers(numbers);


if (line > numbers.GetLength(0) || coll > numbers.GetLength(1))
{
    Console.WriteLine();
    Console.WriteLine("такого элемента нет");
    Console.WriteLine();
}
else
{
    Console.WriteLine();
    Console.WriteLine($"{coll} элемент {line} строки -> {numbers[line - 1, coll - 1]}");
    Console.WriteLine();
}

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

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(MIN_ELEMENTS, MAX_ELEMENTS);
        }
    }
}

void PrintArray(int[,] array)
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