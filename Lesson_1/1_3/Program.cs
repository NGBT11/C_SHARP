// See https://aka.ms/new-console-template for more information

//Напишите программу, которая принимает на вход трехзначное целое число
// и на выходе показывает сумму первой и последней цифры этого числа


Console.WriteLine("Введите трехзначное целое число:");
        int number = int.Parse(Console.ReadLine());

        if (number < 100 || number > 999)
        {
            Console.WriteLine("Введено некорректное число. Пожалуйста, введите трехзначное целое число.");
        }
        else
        {
            int firstDigit = number / 100; // Получаем первую цифру
            int lastDigit = number % 10; // Получаем последнюю цифру
            int sum = firstDigit + lastDigit; // Считаем сумму

            Console.WriteLine("Сумма первой и последней цифры: " + sum);
        }
    

