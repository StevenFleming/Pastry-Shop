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
            Bread firstBread = new Bread();
            Pastry firstPastries = new Pastry();
            int seconds = 2000;
            Console.WriteLine("Welcome to Pierre's Pastry Shop");
            Thread.Sleep(seconds);
            Console.WriteLine("Here we serve pastries and bread, let me take your order?");
            Thread.Sleep(seconds);
            Console.WriteLine("Were having a sale, 1 for 2$ or 3 for 5$");
            Thread.Sleep(seconds);
            Console.WriteLine("Wonderful, how many pastries are you looking to order");
            firstPastries.Quantity = int.Parse(Console.ReadLine());
            firstPastries.PastriesCost();
            firstPastries.PrintPastries();
            Console.WriteLine("You should know today were having a sale, buy two get one free");
            Thread.Sleep(seconds);
            Console.WriteLine("Wonderful, how many loafs of bread do you want to order?");
            firstBread.OrderedQuantity= int.Parse(Console.ReadLine());
            firstBread.BreadCosts();
            firstBread.BreadQuantity();
            firstBread.PrintBread();
            Thread.Sleep(seconds);
            Console.WriteLine($"Your total will be {firstBread.TotalCost + firstPastries.TotalCost}$s ");
            Console.WriteLine("If you are done with your order type exit if you would like to edit your cart enter anything else");
            string quitprogram = Console.ReadLine().ToLower();
            if (quitprogram== "exit")
            {
            System.Environment.Exit(0);
            }
        }
    }
}