//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

const int MIN_ELEMENTS = 5;
const int MAX_ELEMENTS = 10;
const int MIN_SIZE = 3;
const int MAX_SIZE = 8;

int height = new Random().Next(MIN_SIZE, MAX_SIZE);
int length = new Random().Next(MIN_SIZE, MAX_SIZE);
int[,] numbers = new int[height, length];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
Console.WriteLine();
PrintAverage(numbers);

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

void PrintAverage(int[,] array)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            average = (average + numbers[i, j]);
        }
        average = average / height;
        Console.Write($"{average:f2}\t ");
    }
}