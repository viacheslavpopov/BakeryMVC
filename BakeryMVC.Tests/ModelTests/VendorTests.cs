using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryMVC.Models;
using System.Collections.Generic;
using System;

namespace BakeryMVC.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test Vendor", "test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsVendorNameAndDescription_String()
    {
      string name = "Test Vendor";
      string description = "Test description";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.VendorName;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      string description = "Test description";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "Suzie's Cafe";
      string name02 = "PAM Gala";
      string description01 = "Recurring twice weekly bread loaf order";
      string description02 = "New Relic Gala event";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      List<Vendor> newVendor = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newVendor, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
    string name01 = "Suzie's Cafe";
    string name02 = "PAM Gala";
    string description01 = "Recurring twice weekly bread loaf order";
    string description02 = "New Relic Gala event";    
    Vendor newVendor1 = new Vendor(name01, description01);
    Vendor newVendor2 = new Vendor(name02, description02);
    Vendor result = Vendor.Find(2);
    Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendorOrderList()
    {
      string title = "Test Title";
      string description = "Test order.";
      int orderDate = 12/12/2020;
      int quantityBread = 1;
      int quantityPastry = 1;
      Order newOrder = new Order(title, orderDate, description, quantityBread, quantityPastry);
      List<Order> newList = new List<Order> { newOrder };
      string descriptionV = "Recurring twice weekly bread order";
      string name = "Suzie's Cafe";
      Vendor newVendor = new Vendor(name, descriptionV);
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}