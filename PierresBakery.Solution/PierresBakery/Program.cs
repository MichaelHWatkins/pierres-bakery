using System;
using System.Collections.Generic;
using PierresBakery.Models;
public class Program
{
  public static void Main()
  {
    Console.WriteLine("Welcome to Pierres Bakery!");
    int totalSum = 0;
    while(true){
      Console.WriteLine("Please enter how much bread you would like in number of loaves!");
      int breadInput = int.Parse(Console.ReadLine());
      Console.WriteLine("And how many pastries would you like?");
      int pastryInput = int.Parse(Console.ReadLine());
      totalSum += Bread.CheckBreadPrice(breadInput) + Pastry.CheckPastryPrice(pastryInput);
      Console.WriteLine("Your total is: $" + totalSum);
      Console.WriteLine("Would you like to add to your order? y/n");
      string ans = Console.ReadLine();
      if(ans == "n"){
        Console.WriteLine("Thank you for your purchase!");
        break;
      }
      else{
        Console.WriteLine("Excellent!");
      }
    }
    
  }
}