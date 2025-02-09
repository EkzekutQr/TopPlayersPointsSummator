// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

// Массив очков команд (пример данных)
int[] points = { 45, 67, 34, 56, 78, 89, 23, 54, 76, 65, 43, 32, 21, 12, 34, 56, 78, 90, 87, 65 };

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