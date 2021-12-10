using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread{
    public static int CheckBreadPrice(int input)
    {
      int price = 0;
      for(int i = 1; i <= input; i++)
      {
        if(i % 3 == 0)
        {
          price += 0;
        }
        else
        {
          price += 5;
        }
      }
      return price;
    }
  }

  public class Pastry{
    public static int CheckPastryPrice(int input)
    {
      int price = 0;
      for(int i = 1; i <= input; i++)
      {
        if(i % 3 == 0)
        {
          price += 1;
        }
        else
        {
          price += 2;
        }
      }
      return price;
    }
  }
}