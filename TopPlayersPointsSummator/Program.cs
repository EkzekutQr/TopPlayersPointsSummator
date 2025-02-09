// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

// Создаем массив из 20 элементов и заполняем его случайными числами от 0 до 99
int[] points = new int[20];
Random random = new Random();
for (int i = 0; i < points.Length; i++)
{
    points[i] = random.Next(0, 100); // Случайное число от 0 до 99
}

// Выводим массив в консоль
Console.WriteLine("Сгенерированный массив очков:");
Console.WriteLine(string.Join(", ", points));

// Сортируем массив по убыванию
var sortedPoints = points.OrderByDescending(p => p).ToArray();

// Суммируем очки трёх первых команд
int sumTopThree = sortedPoints[0] + sortedPoints[1] + sortedPoints[2];

// Выводим результат
Console.WriteLine("Очки трёх лучших команд:");
Console.WriteLine($"1-е место: {sortedPoints[0]}");
Console.WriteLine($"2-е место: {sortedPoints[1]}");
Console.WriteLine($"3-е место: {sortedPoints[2]}");
Console.WriteLine($"Сумма очков: {sumTopThree}");