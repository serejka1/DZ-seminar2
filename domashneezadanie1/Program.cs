﻿﻿using System;

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
string numberS = Math.Abs(number).ToString();
Console.WriteLine(numberS.Length == 3 ? $"{number} -> {numberS[1]}" : "Вы ввели не трехзначное число");

/* if(numberS.Length != 3) {
    Console.WriteLine("Вы ввели не трехзначное число");
} else {
    Console.WriteLine($"{number} -> {numberS[1]}");
}
*/
