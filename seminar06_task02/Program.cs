// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double bFirst = Prompt("Введите значение b1 > ");
double kFirst = Prompt("Введите значение k1 > ");
double bSecond = Prompt("Введите значение b2 > ");
double kSecond = Prompt("Введите значение k2 > ");
double xCoord = (-bSecond + bFirst)/(-kFirst + kSecond);
double yCoord = kSecond * xCoord + bSecond;

double Prompt(string message)
{
    Console.Write(message);
    bool isDigit = double.TryParse(Console.ReadLine(), out double number);
    if (isDigit)
    {
        return number;
    }
    throw new Exception("Вы ввели не число");
}

Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {xCoord}, Y: {yCoord}");