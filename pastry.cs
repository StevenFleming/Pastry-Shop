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
            Cost = 3(Quantity);
            Quantity = 1;

        }
        public void PrintBread()
        {
            Console.WriteLine($" You ordered {Quantity} of {Name}. That will be {Cost} ");
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
            Cost = 5(Quantity);
            Quantity = 1;
        }

        public void PrintPastries ()
        {
            Console.WriteLine($" You ordered {Quantity} of {Name}. That will be {Cost} ");
        }
    }
}