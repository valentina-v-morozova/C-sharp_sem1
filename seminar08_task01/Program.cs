// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
OrderArrayLines(numbers);
PrintOrderedArray(numbers);

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

void OrderArrayLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) //переход между строками
    {
        for (int j = 0; j < array.GetLength(1); j++) //перебираем значения в строке
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++) //работаем со строкой как с одномерным массивом
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

void PrintOrderedArray(int[,] array)
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