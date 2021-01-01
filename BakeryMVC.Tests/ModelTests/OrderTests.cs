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
      DateTime orderDate = new DateTime(2020,12,25);
      orderDate.ToString();
      Order newOrder = new Order("test", orderDate, "test", 1, 1);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetId_OrderInstantiateWithAnIdAndGetterReturns_Int()
    {
      string title = "test title";
      string description = "test order";
      DateTime orderDate = new DateTime(2020,12,25);
      orderDate.ToString();
      int breadQuantity = 2;
      int pastryQuantity = 4;
      Order newOrder = new Order(title, orderDate, description, breadQuantity, pastryQuantity);
      int result = newOrder.OrderId;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetOrderArguments_ReturnsOrderDescriptionAndTitle_String()
    {
      string orderTitle = "Test Title";
      string orderDescription = "Charity event.";
      DateTime orderDate = new DateTime(2020,12,25);
      orderDate.ToString();
      int breadQuantity = 20;
      int pastryQuantity = 40;
      Order newOrder = new Order(orderTitle, orderDate, orderDescription, breadQuantity, pastryQuantity);
      string result = newOrder.OrderDescription;
      Assert.AreEqual(orderDescription, result);
    }
    
    [TestMethod]
    public void SetOrderArguments_SetOrderDescriptionAndTitle_String()
    {
      string orderTitle = "Test Org Holiday Fundraiser";
      string orderDescription = "Charity event.";
      DateTime orderDate = new DateTime(2020,12,25);
      orderDate.ToString();
      int breadQuantity = 20;
      int pastryQuantity = 40;
      Order newOrder = new Order(orderTitle, orderDate, orderDescription, breadQuantity, pastryQuantity);
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
      DateTime orderDate01 = new DateTime(2020,12,25);
      orderDate01.ToString();
      DateTime orderDate02 = new DateTime(2020,12,25);
      orderDate02.ToString();
      string orderDescription01 = "Weekly restaurant shipment";
      string orderDescription02 = "Charity event";
      int breadQuantity01 = 20;
      int pastryQuantity01 = 40;
      int breadQuantity02 = 100;
      int pastryQuantity02 = 100;
      Order newOrder1 = new Order(orderTitle01, orderDate01, orderDescription01, breadQuantity01, pastryQuantity01);
      Order newOrder2 = new Order(orderTitle02, orderDate02, orderDescription02, breadQuantity02, pastryQuantity02);
      List<Order> newOrderList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newOrderList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string orderTitle01 = "Suzie's Cafe";
      string orderTitle02 = "PAM Gala";
      DateTime orderDate01 = new DateTime(2020,12,25);
      orderDate01.ToString();
      DateTime orderDate02 = new DateTime(2020,12,25);
      orderDate02.ToString();
      string orderDescription01 = "Weekly restaurant shipment";
      string orderDescription02 = "Charity event";
      int breadQuantity01 = 20;
      int pastryQuantity01 = 40;
      int breadQuantity02 = 100;
      int pastryQuantity02 = 100;
      Order newOrder1 = new Order(orderTitle01, orderDate01, orderDescription01, breadQuantity01, pastryQuantity01);
      Order newOrder2 = new Order(orderTitle02, orderDate02, orderDescription02, breadQuantity02, pastryQuantity02);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}