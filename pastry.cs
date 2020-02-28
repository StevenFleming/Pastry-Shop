using System;
using System.Collections.Generic;

namespace Pastries
{
    public class Bread
    {
        public string Name {get;set;}
        public int Cost {get;set;}
        public int Quantity {get;set;}

        public Bread (string name)
        {
            Name = name;
            Cost = 3;
            Quantity = 1;

        }

    }

    public class Pastries
    {
        public string Name {get;set;}
        public int Cost {get;set;}
        public int Quantity {get;set;}

        public Pastries (string name)
        {
            Name = name;
            Cost = 5;
            Quantity = 1;
            

        }
    }
}