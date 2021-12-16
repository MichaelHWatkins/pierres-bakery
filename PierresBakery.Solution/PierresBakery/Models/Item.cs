using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread{
    public int BreadCount{get; set;}

    public Bread(int breadCount)
    {
      BreadCount = breadCount;
    }

    public static int CheckBreadPrice(Bread bread)
    {
      int price = 0;
      for(int i = 1; i <= bread.BreadCount; i++)
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
    public int PastryCount{get; set;}

    public Pastry(int pastryCount)
    {
      PastryCount = pastryCount;
    }
    public static int CheckPastryPrice(Pastry pastry)
    {
      int price = 0;
      for(int i = 1; i <= pastry.PastryCount; i++)
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