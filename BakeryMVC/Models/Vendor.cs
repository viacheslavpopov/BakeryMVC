using System.Collections.Generic;

namespace BakeryMVC.Models
{
	public class Vendor
	{//vendor's name, a description of the vendor, a List of Orders belonging to the vendor, and any other properties you would like to include.
    private static List<Vendor> _vendorInstances = new List<Vendor> {};

    public Vendor(string vendorName, string vendorDescription)
    {
      VendorName = vendorName;
      VendorDescription = vendorDescription;
      _vendorInstances.Add(this);
      Id = _vendorInstances.Count;
      Vendors = new List<Vendor>{};
      Orders = new List<Order>{};
    }

    public static List<Vendor> GetAll()
    {
      return _vendorInstances;
    }

    public static void ClearAll()
    {
      _vendorInstances.Clear();
    }

    public void Add(Order order)
    {
      Orders.Add(order);
    }

    public static Vendor Find(int vendorId)
    {
      return _vendorInstances[vendorId - 1];
    }

    public string VendorName { get; set; }
    public string VendorDescription { get; set; }
    public int Id {get; }
    public List<Vendor> Vendors { get; set; 
    }
    public List<Order> Orders {get; set; }
	
  }
}