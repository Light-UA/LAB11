using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть перше ціле число:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть друге ціле число:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        bool isMultiple = IsMultiple(number1, number2);

        if (isMultiple)
        {
            Console.WriteLine($"{number1} є кратним {number2}");
        }
        else
        {
            Console.WriteLine($"{number1} не є кратним {number2}");
        }

        Console.ReadKey();
    }

    static bool IsMultiple(int num1, int num2)
    {
        return num1 % num2 == 0;
    }
}
