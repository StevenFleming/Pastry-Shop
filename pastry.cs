using System;
using System.Collections.Generic;

namespace Pastries
{
    public class Bread
    {
        public string Name {get;set;}
        public int Cost {get;set;}
        public int Quantity {get;set;}

        public int TotalCost {get;set;}

        public Bread ()
        {
            Name = "Pierre's Bread";
            Quantity = 1;
            Cost = 3;
            TotalCost = (Quantity * Cost);

        }
        public void PrintBread()
        {
            Console.WriteLine($" You ordered {Quantity} of {Name}. That will be {TotalCost}$s, Thank you.");
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
            TotalCost = (Quantity * Cost);
        }

        public void PrintPastries ()
        {
            Console.WriteLine($" You ordered {Quantity} of {Name}. That will be {TotalCost}$s, Thank you ");
        }
    }
}