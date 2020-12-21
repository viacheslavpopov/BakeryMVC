using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryMVC.Models; 
using System;

namespace BakeryMVC.Test
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test", 1, 1);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetId_OrderInstantiateWithAnIdAndGetterReturns_Int()
    {
      string title = "test title";
      string description = "test order";
      int breadQuantity = 2;
      int pastryQuantity = 4;
      Order newOrder = new Order(title, description, breadQuantity, pastryQuantity);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetOrderArguments_ReturnsOrderDescriptionAndTitle_String()
    {
      string orderTitle = "Test Title";
      string orderDescription = "Charity event.";
      int breadQuantity = 20;
      int pastryQuantity = 40;
      Order newOrder = new Order(orderTitle, orderDescription, breadQuantity, pastryQuantity);
      string result = newOrder.OrderDescription;
      Assert.AreEqual(orderDescription, result);
    }
    
    [TestMethod]
    public void SetOrderArguments_SetOrderDescriptionAndTitle_String()
    {
      string orderTitle = "Test Org Holiday Fundraiser";
      string orderDescription = "Charity event.";
      int breadQuantity = 20;
      int pastryQuantity = 40;
      Order newOrder = new Order(orderTitle, orderDescription, breadQuantity, pastryQuantity);
      string updatedOrderTitle = "Test Org Recurring";
      string updatedOrderDescription = "Weekly restaurant shipment";
      newOrder.OrderTitle = updatedOrderTitle;
      newOrder.OrderDescription = updatedOrderDescription;
      string descriptionResult = newOrder.OrderDescription;
      string titleResult = newOrder.OrderTitle;
      Assert.AreEqual(updatedOrderTitle, titleResult);
      Assert.AreEqual(updatedOrderDescription, descriptionResult);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newOrder = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newOrder, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrdersList()
    {
      string orderTitle01 = "Suzie's Cafe";
      string orderTitle02 = "PAM Gala";
      string orderDescription01 = "Weekly restaurant shipment";
      string orderDescription02 = "Charity event";
      int breadQuantity01 = 20;
      int pastryQuantity01 = 40;
      int breadQuantity02 = 100;
      int pastryQuantity02 = 100;
      Order newOrder1 = new Order(orderTitle01, orderDescription01, breadQuantity01, pastryQuantity01);
      Order newOrder2 = new Order(orderTitle02, orderDescription02, breadQuantity02, pastryQuantity02);
      List<Order> newOrderList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newOrderList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string orderTitle01 = "Suzie's Cafe";
      string orderTitle02 = "PAM Gala";
      string orderDescription01 = "Weekly restaurant shipment";
      string orderDescription02 = "Charity event";
      int breadQuantity01 = 20;
      int pastryQuantity01 = 40;
      int breadQuantity02 = 100;
      int pastryQuantity02 = 100;
      Order newOrder1 = new Order(orderTitle01, orderDescription01, breadQuantity01, pastryQuantity01);
      Order newOrder2 = new Order(orderTitle02, orderDescription02, breadQuantity02, pastryQuantity02);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }

    //BreadCost tests
    // [TestMethod]
    // public void TotBreadLoavesCost_NumGreaterThanThreeNotDivisibleByThreeCost_30()
    // {
    //   int numOfLoaves = 8;
    //   Bread testBread = new Bread(numOfLoaves);
    //   Assert.AreEqual(30, testBread.TotBreadLoavesCost(8));
    // }

    // [TestMethod]
    // public void TotBreadLoavesCost_NumGreaterThanThreeDivisibleByThreeCost_20()
    // {
    //   int numOfLoaves = 6;
    //   Bread testBread = new Bread(numOfLoaves);
    //   Assert.AreEqual(20, testBread.TotBreadLoavesCost(6));
    // }

    // [TestMethod]
    // public void TotBreadLoavesCost_ThreeLoavesCost_10()
    // {
    //   int numOfLoaves = 3;
    //   Bread testBread = new Bread(numOfLoaves);
    //   Assert.AreEqual(10, testBread.TotBreadLoavesCost(3));
    // }

    // [TestMethod]
    // public void TotBreadLoavesCost_TwoLoavesCost_10()
    // {
    //   int numOfLoaves = 2;
    //   Bread testBread = new Bread(numOfLoaves);
    //   Assert.AreEqual(10, testBread.TotBreadLoavesCost(2));
    // }

    // [TestMethod]
    // public void TotBreadLoavesCost_OneLoafCost_Five()
    // {
    //   int numOfLoaves = 1;
    //   Bread testBread = new Bread(numOfLoaves);
    //   Assert.AreEqual(5, testBread.TotBreadLoavesCost(1));
    // }

    // [TestMethod]
    // public void TotBreadLoavesCost_ZeroLoavesCost_Zero()
    // {
    //   int numOfLoaves = 0;
    //   Bread testBread = new Bread(numOfLoaves);
    //   Assert.AreEqual(0, testBread.TotBreadLoavesCost(0));
    // }
  }
}