/*
Задание 4: информация о 3D-модели
Переменные: имя (`string`), полигоны (`int`), длительность анимации (`float`), видимость (`bool`), угол поворота (`float`).
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        string name = "model";
        int polygons = 21;
        float duration = 2.5f;
        bool visible = true;
        float angle = 50f;

      Console.WriteLine($"Модель: {name}, полигоны: {polygons}, видимость: {visible}");
    }
}
