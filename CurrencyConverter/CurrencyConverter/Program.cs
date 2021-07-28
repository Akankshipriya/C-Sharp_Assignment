using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {

            foreignCurrency();
            Console.ReadLine();
        }
        static void foreignCurrency()
        {
            y: Console.WriteLine("Enter the number of foreign currencies (minimum 5) you want to start with");
            int noOfCurrency = Convert.ToInt32(Console.ReadLine());
            if(noOfCurrency<5)
            {
                Console.WriteLine("Please enter the number of foreign currencies 5 or more.");
                goto y;
            }
            Dictionary<string, int> currency = new Dictionary<string, int>();
            for(int i=0;i<noOfCurrency;i++)
            {
                Console.WriteLine("Enter your " + i + " Currency and its rate");
                string currencyName = Console.ReadLine();
                int currencyrate =Convert.ToInt32(Console.ReadLine());
                currency.Add(currencyName, currencyrate);
            }
            Console.WriteLine("Enter the symbol and amount");
            string symbol = Console.ReadLine();
            int amount = Convert.ToInt32(Console.ReadLine());
            x:if (currency.ContainsKey(symbol))
            {
                Console.WriteLine(symbol+" "+ amount * currency[symbol]);
            }
            else
            {
                Console.WriteLine("The currency is not available. Do you want to add new(Y/N)");
                string reply = Console.ReadLine();
                if(reply.Equals("Y"))
                {
                    Console.WriteLine("Enter your Currency and its rate");
                    string currencyName = Console.ReadLine();
                    int currencyrate = Convert.ToInt32(Console.ReadLine());
                    currency.Add(currencyName, currencyrate);
                    goto x;
                }
                else
                {
                    System.Environment.Exit(0);
                }
            }
        }
    }
}
