using System.Collections.Generic;

namespace BakeryMVC.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendorInstances = new List<Vendor> { };
    public string VendorName { get; set; }
    public string VendorDescription { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string vendorName, string vendorDescription)
    {
      VendorName = vendorName;
      VendorDescription = vendorDescription;
      _vendorInstances.Add(this);
      Id = _vendorInstances.Count;
      Orders = new List<Order> { };
    }

    public static void ClearAll()
    {
      _vendorInstances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _vendorInstances;
    }

    public static Vendor Find(int searchId)
    {
      return _vendorInstances[searchId - 1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}