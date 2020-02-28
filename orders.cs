using System;
using System.Collections.Generic;
using Pastries;
    
    
    
namespace Orders
{
    public class CustomerOrder
    {
        public static void AskOrder ()
        {
            Bread firstBread = new Bread();
            Pastry firstPastries = new Pastry();
            Console.WriteLine("Welcome to Pierre's Pastry Shop");
            Console.WriteLine("Would you Like to Order Either a Pastry or a Bread");
            Console.WriteLine("Press P for Pastry or B for Bread");
            string answer = Console.ReadLine().ToLower();
            if (answer == "p")
            {
                Console.WriteLine("Wonderful, how many pastries are you looking to order");
                Console.WriteLine("You should know today were having a sale, 1 for 1$ or three for 5$");
                firstPastries.Quantity = int.Parse(Console.ReadLine());
            }
            if (answer == "b");
            {
                Console.WriteLine("Wonderful, how many loafs of bread are you trying to order?");
                Console.WriteLine("You should know today were having a sale, buy two get one free");
                firstBread.OrderedQuantity= int.Parse(Console.ReadLine());
                firstBread.BreadQuantity();
                firstBread.BreadCosts();
                firstBread.PrintBread();
            }
            Console.WriteLine("Would you like to buy anything else?");
        }
    }
}