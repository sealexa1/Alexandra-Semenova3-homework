/*
Задание 3: перевод температуры
Формула: `°F = °C × 9/5 + 32`
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        double celsius = 25.0;

        double fahrenheit = celsius * 9 / 5 + 32;

        Console.WriteLine($"Температура по Фаренгейту: {fahrenheit}");
    }
}
