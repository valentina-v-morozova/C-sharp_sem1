// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числa


int randValue = new Random().Next(10, 1000); // выводим случайное значение
int newValue = 0;

newValue = (randValue / 100) * 10 + (randValue % 10);

Console.WriteLine($"{randValue} -> {newValue}");