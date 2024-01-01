// See https://aka.ms/new-console-template for more information





        Console.WriteLine("Введите координаты точки (X и Y):");
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine("Точка находится в первой координатной четверти");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Точка находится во второй координатной четверти");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Точка находится в третьей координатной четверти");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Точка находится в четвертой координатной четверти");
        }
        else
        {
            Console.WriteLine("Некорректные координаты точки. Пожалуйста, введите X ≠ 0 и Y ≠ 0.");
        }
