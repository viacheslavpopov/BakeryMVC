using System.Collections.Generic;
using System;

namespace BakeryMVC.Models
{
	public class Vendor
	{
	//vendor's name, a description of the vendor, a List of Orders belonging to the vendor, and any other properties you would like to include.
  private static List<Vendor> _instances = new List<Vendor> {};

  public Vendor(string vendorName, string vendorType, string vendorOrders)
  {
    // VendorName = vendorName;
    // VendorType = vendorType;
    // VenderOrders = vendorOrders;
    _instances.Add(this);
    // Id = _instances.Count;
    // vendorOrders = new List<Order>{};
    //, int vendorInvoice
  }
	}
}