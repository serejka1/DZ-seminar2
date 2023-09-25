﻿using System;

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
string numberS = Math.Abs(number).ToString();

Console.WriteLine(numberS.Length > 2 ? $"{number} -> {numberS[2]}" : $"{numberS} -> третьей цифры нет");

/*
if(numberS.Length > 2) {
    Console.WriteLine($"{number} -> {numberS[2]}");
} else {
    Console.WriteLine($"{number} -> третьей цифры нет");
}
*/
