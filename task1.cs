using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть число від 0 до 9 для виведення відповідного стовпця таблиці множення:");
        int number = Convert.ToInt32(Console.ReadLine());

        PrintMultiplicationTable(number);

        Console.ReadKey();
    }

    static void PrintMultiplicationTable(int n)
    {
        if (n == 0)
        {
            Console.WriteLine("Таблиця множення:");

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write($"{i} * {j} = {i * j}\t");
                }
                Console.WriteLine();
            }
        }
        else if (n >= 1 && n <= 9)
        {
            Console.WriteLine($"Стовпець таблиці множення для числа {n}:");
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
            }
        }
        else
        {
            Console.WriteLine("Введено некоректне число. Будь ласка, введіть число від 0 до 9.");
        }
    }
}
