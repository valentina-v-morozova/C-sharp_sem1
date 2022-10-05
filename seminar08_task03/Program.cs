//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

const int MIN_ELEMENTS = 5;
const int MAX_ELEMENTS = 10;
const int MIN_SIZE = 3;
const int MAX_SIZE = 8;

int firstSize = new Random().Next(MIN_SIZE, MAX_SIZE);
int secondSize = new Random().Next(MIN_SIZE, MAX_SIZE);
int thirdSize = new Random().Next(MIN_SIZE, MAX_SIZE);

int[,] firstMatrix = new int[firstSize, secondSize];
int[,] secondMatrix = new int[secondSize, thirdSize];
int[,] resultMatrix = new int[firstSize, thirdSize];

Console.WriteLine($"\nПервая матрица:");
FillArrayRandomNumbers(firstMatrix);
FillArrayRandomNumbers(secondMatrix);
PrintArray(firstMatrix);
Console.WriteLine($"\nВторая матрица:");
PrintArray(secondMatrix);
MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintArray(resultMatrix);


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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}