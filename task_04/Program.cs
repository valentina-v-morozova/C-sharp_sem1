// Задача 4: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Ввод числа из консоли по приглашению
int Prompt(string message)
{
    System.Console.Write(message);        //Вывод приглашения
    string strValue;                      //Объявляем переменной для ввода строки
    strValue = Console.ReadLine() ?? "0"; //Вводим строку с консоли (можно ввести только строку)
    int value = int.Parse(strValue);      //Преобразование строки в целое число
    return value;
}

int Value = Prompt("Введите число > ");
if (Value <2)
{
System.Console.Write($"{Value} -> нет значений");    
}
else
{
int Value1 = Value % 2;
int count = 2;
System.Console.Write($"{Value} -> ");

while(count < Value)
{
        Console.Write($"{count},");
        count = count + 2;
    }

if(Value1 == 0)
{
System.Console.WriteLine(Value);
}
else
{
System.Console.WriteLine("");
}
}