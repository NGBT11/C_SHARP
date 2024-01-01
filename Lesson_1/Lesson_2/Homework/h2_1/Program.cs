// See https://aka.ms/new-console-template for more information


// Напишите программу, которая принимает
//на вход число и проверяет, кратно ли оно
//одновременно 7 и 23

Console.WriteLine("Введите число:");
        int number = int.Parse(Console.ReadLine());

        if (number % 7 == 0 && number % 23 == 0)
        {
            Console.WriteLine("кратно");
        }
        else
        {
            Console.WriteLine("не кратно");
        }
