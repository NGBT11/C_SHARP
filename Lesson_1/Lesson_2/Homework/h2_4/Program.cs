// See https://aka.ms/new-console-template for more information


        Console.WriteLine("Введите натуральное число:");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            string digitsString = "";

            while (n > 0)
            {
                int digit = n % 10;
                digitsString = digit + ", " + digitsString;
                n /= 10;
            }

            digitsString = digitsString.TrimEnd(',', ' ');
            Console.WriteLine("Цифры: " + digitsString);
        }
        else
        {
            Console.WriteLine("ВВЕДИТЕ НАТУРАЛЬНОЕ ЧИСЛО!!.");
        };
