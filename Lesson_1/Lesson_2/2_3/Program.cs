// See https://aka.ms/new-console-template for more information


// 3. Напишите программу, которая будет принимать на вход два
// числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит
// остаток от деления.

 Console.WriteLine("Введите первое число");
 int num1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите второе число");
 int num2 = Convert.ToInt32(Console.ReadLine());

 if (num1 % num2 == 0)
 {
 Console.WriteLine("да");
 }
 else
 {
 Console.WriteLine($"нет, остаток {num1 %num2}");
 }
