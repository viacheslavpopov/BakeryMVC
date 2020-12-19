using System.Collections.Generic;
using System;

namespace BakeryMVC.Models
{
	public class Vendor
	{//vendor's name, a description of the vendor, a List of Orders belonging to the vendor, and any other properties you would like to include.
    private static List<Vendor> _vendorInstances = new List<Vendor> {};

    public Vendor(string vendorName)
    {
      VendorName = vendorName;
      _vendorInstances.Add(this);
      Id = _vendorInstances.Count;
      Vendors = new List<Vendor>{};
      //Orders = newList<Order>{};
      //_instances.Add(this); //for orders ...
    }

    public static List<Vendor> GetAll()
    {
      return _vendorInstances;
    }

    public static void ClearAll()
    {
      _vendorInstances.Clear();
    }

  public static Vendor Find(int vendorId)
  {
    return _vendorInstances[vendorId - 1];
  }
    public string VendorName { get; set; }
    public int Id {get; }
    // public List<Vendor> Vendors { get; set; }
    public List<Vendor> Vendors { get; set; 
    }
	
  }
}