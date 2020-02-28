using System;
using System.Collections.Generic;
using Pastries;
using System.Threading;
    
    
    
namespace Orders
{
    public class CustomerOrder
    {
        public static void AskOrder ()
        {
            int seconds = 2000;
            Console.WriteLine("Welcome to Pierre's Pastry Shop");
            Thread.Sleep(seconds);
            Console.WriteLine("Here We serve Pastries and Bread which would you like to order");
            Thread.Sleep(seconds);
            Console.WriteLine("Press P for Pastry or B for Bread");
            Thread.Sleep(seconds);
            WhichOrder();
            Console.WriteLine("Would you like to buy anything else? If you are done with your order type exit");
            string quitprogram = Console.ReadLine().ToLower();
            if (quitprogram== "exit")
            {
            System.Environment.Exit(0);
            }
            else{
            WhichOrder();
            }


        }

        public static void WhichOrder()
        {
            string answer = Console.ReadLine().ToLower();
            if (answer == "p")
            {
                PastriesOrder();
            }
            if (answer == "b");
            {
                BreadsOrder();
            }
        }

        public static void PastriesOrder()
        {
            int seconds = 2000;
            Pastry firstPastries = new Pastry();
            Console.WriteLine("Wonderful, how many pastries are you looking to order");
            Thread.Sleep(seconds);
            Console.WriteLine("You should know today were having a sale, 1 for 2$ or 3 for 5$");
            firstPastries.Quantity = int.Parse(Console.ReadLine());
            firstPastries.PastriesCost();
            firstPastries.PrintPastries();
        }

        public static void BreadsOrder()
        {
            int seconds = 2000;
            Bread firstBread = new Bread();
            Console.WriteLine("Wonderful, how many loafs of bread are you trying to order?");
            Thread.Sleep(seconds);
            Console.WriteLine("You should know today were having a sale, buy two get one free");
            firstBread.OrderedQuantity= int.Parse(Console.ReadLine());
            firstBread.BreadCosts();
            firstBread.BreadQuantity();
            firstBread.PrintBread();
        }
    }
}