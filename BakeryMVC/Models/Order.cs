using System.Collections.Generic;
using System;

namespace BakeryMVC.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> { };
    public int OrderId { get; }
    public string OrderTitle { get; set; }
    public string OrderDescription { get; set; }
    public DateTime Date { get; set; }
    public int QuantityBread { get; set; } //UI
    public int QuantityPastry { get; set; } //UI
    public int PricePerBreadUnit { get; set; } // stretch algebra
    public int PricePerPastryUnit { get; set; } // stretch algebra
    public int TotalBreadCost { get; set; } //UI
    public int TotalPastryCost { get; set; } //UI
    public int InvoiceTotal { get; set; }

    public Order(string orderTitle, DateTime orderDate, string orderDescription, int quantityBread, int quantityPastry, int invoiceTotal)
    {
      OrderTitle = orderTitle;
      Date = orderDate;
      OrderDescription = orderDescription;
      QuantityBread = quantityBread;
      QuantityPastry = quantityPastry;
      InvoiceTotal = invoiceTotal;
      _instances.Add(this);
      OrderId = _instances.Count;
      InvoiceTotal = TotalBreadCost + TotalPastryCost;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static Order Find(int orderId)
    {
      return _instances[orderId - 1];
    }
  }
}