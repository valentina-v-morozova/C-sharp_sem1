﻿// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


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

int[] GenerateArray(int length, int minRandom, int maxRandom)
{
    Random rnd = new Random();
    int[] answer = new int[length];
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(minRandom, maxRandom + 1);
    }
    return answer;
}

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
System.Console.Write(array[i]+ "\t");
}
System.Console.WriteLine();
}


int CountElements(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
if ((array[i] %2) == 0)
{
count ++;
}
}
return count;
}


const int MIN_ELEMENTS = 100;
const int MAX_ELEMENTS = 1000;
int length = Prompt("Введите длину массива > ");
int[] array = GenerateArray(length, MIN_ELEMENTS, MAX_ELEMENTS);
PrintArray(array);
System.Console.WriteLine($"Количество четных элементов {CountElements(array)}");