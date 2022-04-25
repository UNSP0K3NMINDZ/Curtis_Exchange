
namespace Curtis_Exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            double userCurrency;
            double userCurrencyExchange = 0;
            string yesNo = null;
            int counter = 0;
            ExchangeMonitor transactionCount = new ExchangeMonitor();
            ExchangeMonitor transactionTotalExchange = new ExchangeMonitor();
            do
            {
                
                Console.Clear();
                Console.WriteLine("What currency do you want to exchange?");
                Console.WriteLine("Press A for USD");
                Console.WriteLine("Press B twice for GBP");
                Console.WriteLine("Press C three times for CAN");
                Console.WriteLine("Press D four times for EUR");
                if (Console.ReadKey().Key == ConsoleKey.A)
                {
                    Console.Clear();
                    Console.WriteLine("Input USD amount");
                    userCurrency = double.Parse(Console.ReadLine());
                    Console.WriteLine("What are you exchanging " + userCurrency + " to?");
                    Console.WriteLine("Press A once for GBP");
                    Console.WriteLine("Press B twice for CAN");
                    Console.WriteLine("Press C thrice for EUR");
                    if (Console.ReadKey().Key == ConsoleKey.A)
                    {
                        userCurrencyExchange = Exchanger.UsdtoGbp(userCurrency);
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.B)
                    {
                        userCurrencyExchange = Exchanger.UsdtoCan(userCurrency);
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.C)
                    {
                        userCurrencyExchange = Exchanger.UsdtoEur(userCurrency);
                    }
                }
                else if (Console.ReadKey().Key == ConsoleKey.B)
                {
                    Console.Clear();
                    Console.WriteLine("Input GBP amount");
                    userCurrency = double.Parse(Console.ReadLine());
                    Console.WriteLine("What are you exchanging " + userCurrency + " to?");
                    Console.WriteLine("Press A once for USD");
                    Console.WriteLine("Press B twice for CAN");
                    Console.WriteLine("Press C thrice for EUR");
                    if (Console.ReadKey().Key == ConsoleKey.A)
                    {
                        userCurrencyExchange = Exchanger.GbptoUsd(userCurrency);
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.B)
                    {
                        userCurrencyExchange = Exchanger.GbptoCan(userCurrency);
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.C)
                    {
                        userCurrencyExchange = Exchanger.GbptoEur(userCurrency);
                    }
                }
                else if (Console.ReadKey().Key == ConsoleKey.C)
                {
                    Console.Clear();
                    Console.WriteLine("Input CAN amount");
                    userCurrency = double.Parse(Console.ReadLine());
                    Console.WriteLine("What are you exchanging " + userCurrency + " to?");
                    Console.WriteLine("Press A once for USD");
                    Console.WriteLine("Press B twice for GBP");
                    Console.WriteLine("Press C thrice for EUR");
                    if (Console.ReadKey().Key == ConsoleKey.A)
                    {
                        userCurrencyExchange = Exchanger.CantoUsd(userCurrency);
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.B)
                    {
                        userCurrencyExchange = Exchanger.CantoGbp(userCurrency);
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.C)
                    {
                        userCurrencyExchange = Exchanger.CantoEur(userCurrency);
                    }
                }
                else if (Console.ReadKey().Key == ConsoleKey.D)
                {
                    Console.Clear();
                    Console.WriteLine("Input EUR amount");
                    userCurrency = double.Parse(Console.ReadLine());
                    Console.WriteLine("What are you exchanging " + userCurrency + " to?");
                    Console.WriteLine("Press A once for USD");
                    Console.WriteLine("Press B twice for GBP");
                    Console.WriteLine("Press C thrice for CAN");
                    if (Console.ReadKey().Key == ConsoleKey.A)
                    {

                        userCurrencyExchange = Exchanger.EurtoUsd(userCurrency);
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.B)
                    {
                        userCurrencyExchange = Exchanger.EurtoGbp(userCurrency);
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.C)
                    {
                        userCurrencyExchange = Exchanger.EurtoCan(userCurrency);
                    }

                }
                Console.Clear();
                Console.WriteLine(userCurrencyExchange);
                Console.WriteLine("Make another exchange? (Y/N)");
                yesNo = Console.ReadLine();
                counter++;
            }while (yesNo.ToUpper() == "Y");
            Console.WriteLine(transactionCount.TransactionCount(counter));
            
        }
    }
}
