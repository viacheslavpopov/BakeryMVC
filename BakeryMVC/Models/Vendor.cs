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
      // VendorType = vendorType;
      _vendorInstances.Add(this);
      // _instances.Add(this); //for orders ...
      // Id = _instances.Count;
      Vendors = new List<Vendor>{};
      //, int vendorInvoice
    }

    public static List<Vendor> GetAll()
    {
      return _vendorInstances;
    }

    public static void ClearAll()
    {
      _vendorInstances.Clear();
    }

    public string VendorName { get; set; }
    public int Id {get; }
    // public List<Vendor> Vendors { get; set; }
    public List<Vendor> Vendors { get; set; }
	}
}