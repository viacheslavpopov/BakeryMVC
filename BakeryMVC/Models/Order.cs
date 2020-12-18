using System.Collections.Generic;
using System;

namespace BakeryMVC.Models
{
	public class Order
	{
	//the title, the description, the price, the date, and any other properties you would like to include
  public string Description { get; set; }
  public int Price { get; set; }
  public int Date { get; set; } 
  public int Id { get; }

  private static List<Order> _instances = new List<Order> {};

  public Order(string description)
  {

  }

	}
}