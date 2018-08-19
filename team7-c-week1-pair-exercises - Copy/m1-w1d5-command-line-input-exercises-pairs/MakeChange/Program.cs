using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeChange
{
    class Program
    {
        /*
        Write a command line program which prompts the user for the total bill, and the amount tendered. 
        It should then display the change required.
 
        C:\Users> MakeChange
         
        Please enter the amount of the bill: 23.65
        Please enter the amount tendered: 100.00
        The change required is 76.35
        */
        static void Main(string[] args)
        {

            Console.Write("Please enter the amount of the bill: $");
            string billAmount = Console.ReadLine();
            double bill = double.Parse(billAmount);

            Console.Write("Please enter the amount tendered: $");
            string amountTendered =Console.ReadLine();
            double payment = double.Parse(amountTendered);

            double difference = (payment - bill);
            if (difference<0)
            Console.WriteLine("Please enter a valid amount. ");
            else
            Console.WriteLine("The change required : $" + difference);

            

        }
    }
}
