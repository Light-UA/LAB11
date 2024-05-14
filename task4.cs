using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть назву пори року українською мовою:");
        string seasonUA = Console.ReadLine();

        string seasonEN = TranslateSeason(seasonUA);
        if (seasonEN != null)
        {
            Console.WriteLine($"Пора року українською: {seasonUA}");
            Console.WriteLine($"Пора року англійською: {seasonEN}");
        }
        else
        {
            Console.WriteLine("Вказана пора року не знайдена в словнику.");
        }

        Console.ReadKey();
    }

    static string TranslateSeason(string seasonUA)
    {
        switch (seasonUA.ToLower())
        {
            case "весна":
                return "spring";
            case "літо":
                return "summer";
            case "осінь":
                return "autumn";
            case "зима":
                return "winter";
            default:
                return null;
        }
    }
}
