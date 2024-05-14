using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть перше число:");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть друге число:");
        double number2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Значення першого числа перед обміном: {number1}");
        Console.WriteLine($"Значення другого числа перед обміном: {number2}");

        SwapValues(ref number1, ref number2);

        Console.WriteLine($"Значення першого числа після обміном: {number1}");
        Console.WriteLine($"Значення другого числа після обміном: {number2}");

        Console.ReadKey();
    }

    static void SwapValues(ref double a, ref double b)
    {
        double temp = a;
        a = b;
        b = temp;
    }
}
