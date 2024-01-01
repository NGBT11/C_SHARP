// See https://aka.ms/new-console-template for more information


// 1. Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.

string a1 =  Console.ReadLine()!;
string a2 =  Console.ReadLine()!;
int b1 =   Convert.ToInt32(a1);
int b2 =   Convert.ToInt32(a2);
if (b1 * b1 == b2)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");