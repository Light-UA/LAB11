using System;

class Program
{
    static void Main(string[] args)
    {
        CheckMultiples();
        Console.ReadKey();
    }

    static void CheckMultiples()
    {
        Console.WriteLine("Введіть перше ціле число:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть друге ціле число:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        if (number1 % number2 == 0)
        {
            Console.WriteLine($"{number1} є кратним {number2}");
        }
        else
        {
            Console.WriteLine($"{number1} не є кратним {number2}");
        }
    }
}
