using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuplesexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();

            transactions.Add(("baseball", 3.95, 10));
            transactions.Add(("football", 14.99, 8));
            transactions.Add(("frisbee", 9.99, 15));
            transactions.Add(("basketball", 17.99, 5));
            transactions.Add(("tennis ball", 1.15, 30));

            double quantity = 0;
            double price = 0;

            foreach ((string product, double price, int quantity) toys in transactions)
            {
                Console.WriteLine($"Toys: {toys.product} {toys.price} {toys.quantity}");
                quantity += toys.quantity;
                price += toys.price;

            }
            Console.WriteLine($"Toys sold today: { quantity}");
            Console.WriteLine($"Total Revenue: ${price}");
            Console.WriteLine("Press any key to continue");
            Console.Read();
        }
    }
}
