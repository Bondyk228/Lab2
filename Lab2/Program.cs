using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        double y;

        if (x < 0)
        {
            if (a == 1)
            {
                Console.WriteLine("деление на ноль (a - 1 = 0).");
                return;
            }
            y = Math.Log(Math.Abs(x)) * a / (a - 1);
        }
        else if (x > 0)
        {
            y = 1 / (x + Math.Pow(1, -x)); 
        }
        else
        {
            Console.WriteLine("x = 0");
            return;
        }

        Console.WriteLine($"Значение функции y: {y}");
    }
}
