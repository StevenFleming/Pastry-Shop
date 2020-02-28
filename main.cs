using System;
using System.Collections.Generic;
using Pastries;

public class Program
{
    public static void Main ()
    {
        Bread firstbread = new Bread();
        Console.WriteLine("Welcome to Pierre's Pastry Shop");
        firstbread.PrintBread();
        Console.WriteLine(firstbread.BreadCost());
    }
}