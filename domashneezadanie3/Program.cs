﻿using System;

Console.WriteLine("Введите цифру, обозначающую день недели:");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());
string isWeekend = (dayOfWeek > 0 && dayOfWeek < 8) 
    ? (dayOfWeek == 6 || dayOfWeek == 7) ? "да" : "нет"
    : "не день недели";

Console.WriteLine($"{dayOfWeek} -> {isWeekend}");


/*
if(dayOfWeek > 0 && dayOfWeek < 8) {
    if(dayOfWeek == 6 || dayOfWeek == 7) {
        Console.WriteLine($"{dayOfWeek} -> да");
    } else {
        Console.WriteLine($"{dayOfWeek} -> нет");
    }
} else {
    Console.WriteLine($"{dayOfWeek} -> не день недели");
}
*/