﻿// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine()!);
int n3 = n % 10;
int n2 = n / 10 % 10;
Console.WriteLine(Math.Pow(n2, n3));