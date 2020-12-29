using System.Collections.Generic;

namespace BakeryMVC.Models
{
	public class Order
	{
  private static List<Order> _instances = new List<Order> {};

  public Order(string orderTitle, int orderDate, string orderDescription, int quantityBread, int quantityPastry)
  {
    OrderTitle = orderTitle;
    DateTime = orderDate;
    OrderDescription = orderDescription;
    QuantityBread = quantityBread;
    QuantityPastry = quantityPastry;
    _instances.Add(this);
    Id = _instances.Count;
    InvoiceTotal = TotalBreadCost + TotalPastryCost;
  }

  public static List<Order> GetAll()
  {
    return _instances;
  }

  public static Order Find(int orderId)
  {
    return _instances[orderId - 1];
  }

  public static void ClearAll()
  {
    _instances.Clear();
  }
  
  public int Id { get; }
  public string OrderTitle { get; set; }
  public string OrderDescription { get; set; }
  public int DateTime { get; set; }
  public int QuantityBread { get; set; } //UI
  public int QuantityPastry { get; set; } //UI
  public int PricePerBreadUnit { get; set; } //algebra
  public int PricePerPastryUnit { get; set; } // algebra
  public int TotalBreadCost { get; set; } //UI
  public int TotalPastryCost { get; set; } //UI
  public int InvoiceTotal { get; set; }
	}
}