using System;
using System.Collections.Generic;
using System.Threading;

namespace Pastries
{
    public class Bread
    {
        public string Name {get;set;}
        public int Cost {get;set;}
        public int FinalQuantity {get;set;}

        public int TotalCost {get;set;}

        public int FreeBread {get;set;}

        public int OrderedQuantity {get;set;}

        public Bread()
        {
            Name = "Pierre's Bread";
            OrderedQuantity = 0;
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
            Console.WriteLine($"You ordered {OrderedQuantity} of {Name}.Your SubTotal will be {TotalCost}");
            Console.WriteLine($"Because of our special you got {FinalQuantity} of {Name}. Thats {FreeBread} extra loafs of Bread!");
        }
    }

    public class Pastry
    {
        public string Name {get;set;}
        public int Cost {get;set;}
        public int Quantity {get;set;}
        public int TotalCost {get;set;}

        public Pastry()
        {
            Name = "Pierre's Pastries";
            Quantity = 0;
            Cost = 2;
            TotalCost = 0;
        }

        public void PastriesCost()
        {
            if (Quantity == 1)
            {
                 TotalCost = 2;
            }
            if (Quantity == 3)
            {
                TotalCost = 5;
            }
            else
            {
                TotalCost = Quantity * Cost;
            }
        }

        public void PrintPastries()
        {
            Console.WriteLine($"You ordered {Quantity} of {Name}. That will be {TotalCost}$s, Thank you ");
            Console.WriteLine($"Your Total will be {TotalCost}$, Because of our special you got {Quantity} {Name}sdot");
        }
    }
}