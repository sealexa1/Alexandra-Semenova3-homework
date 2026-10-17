/*
Задание 2: средняя скорость и время
Формула: `v = s / t`
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        int distance = 1500;
        int time = 120;

        double speed = (double)distance / time;
        Console.WriteLine($"Средняя скорость: {speed} м/с");

        int newDistance = 2500;
        double timeForNewDistance = newDistance / speed;
        Console.WriteLine($"Время для 2500 метров: {timeForNewDistance} сек");
    }
}

