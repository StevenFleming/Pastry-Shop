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
            int seconds = 2000;
            Bread firstBread = new Bread();
            Pastry firstPastries = new Pastry();
            Console.WriteLine("Here we serve pastries and let me take your order?");
            Thread.Sleep(seconds);
            PastriesOrder();
            BreadsOrder();
            Console.WriteLine($" You total cost will be {firstPastries.TotalCost + firstBread.TotalCost}");
            

        }

        public static void PastriesOrder()
        {
            Bread firstBread = new Bread();
            Pastry firstPastries = new Pastry();
            int seconds = 2000;
            Console.WriteLine("Were having a sale, 1 for 2$ or 3 for 5$");
            Thread.Sleep(seconds);
            Console.WriteLine("Wonderful, how many pastries are you looking to order");
            firstPastries.Quantity = int.Parse(Console.ReadLine());
            firstPastries.PastriesCost();
            firstPastries.PrintPastries();
        }

        public static void BreadsOrder()
        {
            Bread firstBread = new Bread();
            Pastry firstPastries = new Pastry();
            int seconds = 2000;
            Console.WriteLine("You should know today were having a sale, buy two get one free");
            Thread.Sleep(seconds);
            Console.WriteLine("Wonderful, how many loafs of bread do you want to order?");
            firstBread.OrderedQuantity= int.Parse(Console.ReadLine());
            firstBread.BreadCosts();
            firstBread.BreadQuantity();
            firstBread.PrintBread();
        }

        // public static string TotalCost(Bread firstBread, Pastry firstPastries)
        // {
        //     Console.WriteLine($" Your total is {firstBread.TotalCosts + firstPastries.TotalCost}");
        // }
    }
}