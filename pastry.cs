using System;
using System.Collections.Generic;

namespace Pastries
{
    public class Bread
    {
        public string Name {get;set;}
        public int Cost {get;set;}
        public int Quantity {get;set;}
        public int FinalQuantity {get;set;}

        public int TotalCost {get;set;}

        public int FreeBread {get;set;}

        public int OrderedQuantity {get;set;}

        public Bread()
        {
            Name = "Pierre's Bread";
            OrderedQuantity = 1;
            Cost = 5;
            FinalQuantity = 0;
            TotalCost = 0;
            FreeBread = 0;
        }

        public void BreadQuantity()
        {
            FreeBread = (OrderedQuantity/2);
            FinalQuantity = FreeBread +OrderedQuantity;
        }

        public void BreadCosts()
        {
            TotalCost = OrderedQuantity *Cost;
        }
        public void PrintBread()
        {
            Console.WriteLine($"You ordered {Quantity} of {Name}. Thank you.");
            Console.WriteLine($"sYour Total will be {TotalCost}, Because of our special you got {FinalQuantity} of {Name}");
        }
    }

    public class Pastry
    {
        public string Name {get;set;}
        public int Cost {get;set;}
        public int Quantity {get;set;}

        public Pastry()
        {
            Name = "Pierre's Pastries";
            Quantity = 1;
            Cost = 2;
        }

        public void PrintPastries ()
        {
            Console.WriteLine($" You ordered {Quantity} of {Name}. That will be {Cost}$s, Thank you ");
        }
    }
}