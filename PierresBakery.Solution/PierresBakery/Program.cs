using System;
using System.Collections.Generic;
using PierresBakery.Models;
public class Program
{
  public static void Main()
  {
    Console.WriteLine("Welcome to Pierres Bakery! Please enter how much bread you would like in number of loaves!");
    int breadInput = int.Parse(Console.ReadLine());
    Console.WriteLine("And how many pastries would you like?");
    int pastryInput = int.Parse(Console.ReadLine());
    Console.WriteLine("Your total is: $" + (Bread.CheckBreadPrice(breadInput) + Pastry.CheckPastryPrice(pastryInput)));
  }
}