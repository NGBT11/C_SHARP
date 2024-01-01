// See https://aka.ms/new-console-template for more information


        Console.WriteLine("Введите целое число из отрезка [10, 99]:");
        int number = int.Parse(Console.ReadLine());

        if (number >= 10 && number <= 99)
        {
            int maxDigit = 0;
            int currentDigit;

            while (number > 0)
            {
                currentDigit = number % 10;
                if (currentDigit > maxDigit)
                {
                    maxDigit = currentDigit;
                }
                number /= 10;
            }

            Console.WriteLine("Наибольшая цифра числа: " + maxDigit);
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число из отрезка [10, 99].");
        }
