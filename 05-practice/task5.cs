/*
Задание 5: преобразование типов
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        double value = 7.85;

        int intValue = (int)value;

        double doubleValueBack = intValue;
      
        Console.WriteLine($"исходное значение double: {value}");
        Console.WriteLine($"значение int: {intValue}");
        Console.WriteLine($"значение double: {doubleValueBack}");
    }
}
