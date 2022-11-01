using Task_2;

class Program
{
    static void Main()
    {
        Console.WriteLine("Initialize rate of converter currencies");
        Console.WriteLine();
        Console.Write("Enter USD rate: ");
        double usd = double.Parse(Console.ReadLine());
        Console.Write("Enter EUR rate: ");
        double eur = double.Parse(Console.ReadLine());
        Console.Write("Enter GBP rate: ");
        double gbp = double.Parse(Console.ReadLine());

        Converter converter = new(usd, eur, gbp);

        Console.WriteLine("Choose operarion: 1 - sell currency, 2 - sell uah");
        string operationChoice = Console.ReadLine();
        Console.Write("Enter amount of currency that you want to sell: ");
        double amountOfCurrency = double.Parse(Console.ReadLine());
        double result;
        string currency;

        if (operationChoice == "1")
        {
            Console.Write("Enter name of currency that you want to sell: ");
            currency = Console.ReadLine();

            switch (currency)
            {
                case "usd":
                    result = converter.CurrencyToUAH(amountOfCurrency, converter.usd);
                    Console.WriteLine($"Result of exchanging {amountOfCurrency} USD to UAH - {result}");
                    break;
                case "eur":
                    result = converter.CurrencyToUAH(amountOfCurrency, converter.eur);
                    Console.WriteLine($"Result of exchanging {amountOfCurrency} EUR to UAH - {result}");
                    break;
                case "gbp":
                    result = converter.CurrencyToUAH(amountOfCurrency, converter.gbp);
                    Console.WriteLine($"Result of exchanging {amountOfCurrency} GBP to UAH - {result}");
                    break;
                default:
                    break;
            }
               
        }
        else if (operationChoice == "2")
        {
            Console.Write("Enter name of currency that you want to buy: ");
            currency = Console.ReadLine();

            switch (currency)
            {
                case "usd":
                    result = converter.UAHToCurrency(amountOfCurrency, converter.usd);
                    Console.WriteLine($"Result of exchanging {amountOfCurrency} UAH to USD - {result}");
                    break;
                case "eur":
                    result = converter.UAHToCurrency(amountOfCurrency, converter.eur);
                    Console.WriteLine($"Result of exchanging {amountOfCurrency} UAH to EUR - {result}");
                    break;
                case "gbp":
                    result = converter.UAHToCurrency(amountOfCurrency, converter.gbp);
                    Console.WriteLine($"Result of exchanging {amountOfCurrency} UAH to GBP - {result}");
                    break;
                default:
                    break;
            }       
        }
        else
        {
            Console.WriteLine("You entered the wrong index of operation.Try again!");
            Console.WriteLine();
        }    
    }
}
