﻿// See https://aka.ms/new-console-template for more information


// 1. Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого числа.

int a = int.Parse(Console.ReadLine()!);
Console.WriteLine(a / 100 * 10 + a % 10);

// 123 % 10 -> 3
// 123 % 100 -> 23
// 123 % 1000 -> 123

// 123 / 10 -> 12
// 123 / 100 -> 1
// 123 / 1000 -> 0