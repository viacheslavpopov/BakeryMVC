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
      Vendor newVendor = new Vendor("test Vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsVendorName_String()
    {
      //Arrange
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name);

      //Act
      string result = newVendor.VendorName;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "Suzie's Cafe";
      string name02 = "PAM Gala";
      Vendor newVendor1 = new Vendor(name01);
      Vendor newVendor2 = new Vendor(name02);
      List<Vendor> newVendor = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newVendor, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
    string name01 = "Suzie's Cafe";
    string name02 = "PAM Gala";
    Vendor newVendor1 = new Vendor(name01);
    Vendor newVendor2 = new Vendor(name02);
    Vendor result = Vendor.Find(2);
    Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendorOrderList()
    {
      //Arrange
      string description = "Test order.";
      Order newOrder = new Order(description);
      List<Order> newList = new List<Order> { newOrder };

      string name = "Suzie's Cafe";
      Vendor newVendor = new Vendor(name);
      newVendor.Add(newOrder);

      //Act
      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}