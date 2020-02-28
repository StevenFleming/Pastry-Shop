using System;
using System.Collections.Generic;

namespace Pastries
{
    public class Bread
    {
        public string Name {get;set;}
        public int Cost {get;set;}
        public int Quantity {get;set;}

        public Bread ()
        {
            Name = "Pierre's Bread";
            Quantity = 1;
            Cost = 3;

        }
        public void PrintBread()
        {
            Console.WriteLine($" You ordered {Quantity} of {Name}. That will be {Cost}$s, Thank you.");
        }

        public int BreadCost()
        {
            return Cost * Quantity; 
        }

    }

    public class Pastries
    {
        public string Name {get;set;}
        public int Cost {get;set;}
        public int Quantity {get;set;}

        public Pastries ()
        {
            Name = "Pierre's Pastries";
            Quantity = 1;
            Cost = 5;
        }

        public void PrintPastries ()
        {
            Console.WriteLine($" You ordered {Quantity} of {Name}. That will be {Cost}$s, Thank you ");
        }

        public int PastriesCost()
        {
            return Cost * Quantity; 
        }
    }
}