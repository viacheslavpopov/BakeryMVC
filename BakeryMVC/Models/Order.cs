using System.Collections.Generic;
using System;

namespace BakeryMVC.Models
{
	public class Order
	{//the title --> Vendor X Order No., the description( the price, the date, )
  private static List<Order> _instances = new List<Order> {};
  public int Id { get; } // do not add set;
  public string Description { get; set; } //what order is for (event,etc) 
  // public int Price { get; set; } // total price // stretch individual line items for nested class orders & prices
  // public int Date { get; set; } // month, day, year
  // public string OrderType { get; set; } //wholesale or retail

  public Order(string description)
  {
    Description = description;
    _instances.Add(this);
    Id = 1; //_instances.Count;
  }

	}
}