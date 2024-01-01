// See https://aka.ms/new-console-template for more information


// 2. Напишите программу, которая на вход принимает одно число
// (N), а на выходе показывает все целые числа в промежутке от -N до N.


Console.Write("Enter A Number");
int a = int.Parse(Console.ReadLine()!);

int count = a * 2 + 1;
int i = 1;
a = a * -1;
Console.Write(a);
Console.Write(' ');

while (i < count)
{
a = a + 1;
Console.Write(a);
Console.Write(' ');
i = i + 1;
}