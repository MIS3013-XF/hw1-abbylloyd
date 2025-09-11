// HW1a Sales Total

// Your Name: Abby Lloyd
// Did you seek help ? If yes, specify the helper or web link here: No

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double subtotal;
            double tax;
            double total;

            string productname;
            string ticket;
            string price;

            Console.WriteLine("What is the product name of the item you are purchasing?");
            productname = Console.ReadLine();
            Console.WriteLine("How many football tickets do you want to buy?");
            ticket = Console.ReadLine();
            Console.WriteLine("What is the price for each football ticket?");
            price = Console.ReadLine();

            num1 = Convert.ToDouble(ticket);
            num2 = Convert.ToDouble(price);

            subtotal = num1 * num2;

            Console.WriteLine("The subtotal for your bill is " + subtotal.ToString("N2"));

            tax = 0.085 * subtotal;

            Console.WriteLine("The sales tax for your bill is " + tax.ToString("N2"));

            total = subtotal + tax;

            Console.WriteLine("The total for your bill is " + total.ToString("N2"));

            Console.ReadKey();


        }
    }
}
