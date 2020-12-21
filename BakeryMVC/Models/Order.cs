using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace BakeryMVC.Models
{
	public class Order
	{//the title --> Vendor X Order No., the description( the price, the date, )
  private static List<Order> _instances = new List<Order> {};

  public Order(string orderTitle, string orderDescription, int quantityBread, int quantityPastry)
  {
    OrderTitle = orderTitle;
    OrderDescription = orderDescription;
    _instances.Add(this);
    Id = _instances.Count;
    // Date = Day + Month + ", " + Year;
  }

  // public DateTime(int year, int month, int day, int hour, int minute)
  // {
  //   // year => 2020;
  //   // month => 1 && <= 12;
  //   // day =>1 && <= 36;
  //   // DateTime new date = DateTime.Add
  // }

    public int TotBreadLoavesCost(int numOfLoaves)
    {
      if (numOfLoaves != 1 && numOfLoaves != 2 && numOfLoaves != 3 && numOfLoaves % 3 == 0)
      {
        return 10 * (numOfLoaves / 3);
      }
      else if (numOfLoaves % 3 != 0 && numOfLoaves != 1 && numOfLoaves != 2)
      {
        return (5 * numOfLoaves) - (5 * (numOfLoaves % 3));
      }
      else if (numOfLoaves == 1 || numOfLoaves == 2)
      {
        return numOfLoaves * 5;
      }
      else if (numOfLoaves == 3)
      {
        return 10;
      }
      else
      {
        return 0; 
      }
    }



    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static Order Find(int orderId)
    {
      return _instances[orderId-1];
    } 

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public int Id { get; } // do not add set;
    public string OrderTitle { get; set; } 
    public string OrderDescription { get; set; } //what order is for (event,etc) 
    public int Price { get; set; } // total price

    // public int Day { get; set; }
    // public int Month { get; set; }
    // public int Year { get; set; }
    // public string OrderType { get; set; } //wholesale or retail

	}
}