using System.Collections.Generic;
using System;

namespace BakeryMVC.Models
{
	public class Vendor
	{//vendor's name, a description of the vendor, a List of Orders belonging to the vendor, and any other properties you would like to include.
    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string vendorName)
    {
      VendorName = vendorName;
      // VendorType = vendorType;
      _instances.Add(this);
      // Id = _instances.Count;
      Orders = new List<Order>{};
      //, int vendorInvoice
    }

    public string VendorName { get; set; }
    public int Id {get; }
    // public List<Vendor> Vendors { get; set; }
    public List<Order> Orders { get; set; }
	}
}