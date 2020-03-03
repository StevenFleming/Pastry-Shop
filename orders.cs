using System;
using System.Collections.Generic;
using Pastries;
using System.Threading;



namespace Orders
{
    public class CustomerOrder
    {
        public static void AskOrder()
        {
            Bread breadOrder = new Bread();
            Pastry pastryOrder = new Pastry();
            int seconds = 1000;
            Console.WriteLine("Welcome to Pierre's Pastry Shop");
            Thread.Sleep(seconds);
            Console.WriteLine("Here we serve pastries and bread, let me take your order?");
            Thread.Sleep(seconds);
            Console.WriteLine("Were having a sale, 1 for 2$ or 3 for 5$");
            Thread.Sleep(seconds);
            Console.WriteLine("Please input how many pastries you would like, if you dont want any pastries please input 0");
            pastryOrder.Quantity = int.Parse(Console.ReadLine());
            pastryOrder.PastriesCost();
            pastryOrder.PrintPastries();
            Console.WriteLine("You should know today were having a sale, buy two get one free");
            Thread.Sleep(seconds);
            Console.WriteLine("Please input how many Loafs of Bread you would like");
            breadOrder.OrderedQuantity = int.Parse(Console.ReadLine());
            breadOrder.BreadCosts();
            breadOrder.BreadQuantity();
            breadOrder.PrintBread();
            Thread.Sleep(seconds);
            Console.WriteLine($"Your total will be {breadOrder.TotalCost + pastryOrder.TotalCost}$s ");
            Console.WriteLine("If you are done with your order type exit if you would change your order");
            string quitprogram = Console.ReadLine().ToLower();
            if (quitprogram == "exit")
            {
                System.Environment.Exit(0);
            }
            else
            {
                AskOrder();
            }
        }
    }
}