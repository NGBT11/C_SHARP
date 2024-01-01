// See https://aka.ms/new-console-template for more information



 Console.WriteLine("Введите число");
 long num = Convert.ToInt32(Console.ReadLine());

 if (num < 100)
 {
 Console.WriteLine("третьей цыфры нет");
 }

 if (num >= 1000)
 {
 long num1 = (num / 100) % 10;
 Console.WriteLine(num1);
 }

 else if (num >= 100 && num < 1000)
 {
 long num2 = num % 10;
 Console.WriteLine(num2);
  }
