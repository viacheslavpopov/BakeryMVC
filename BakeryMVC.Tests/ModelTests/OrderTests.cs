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
      Order newOrder = new Order("test", "test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetId_OrderInstantiateWithAnIdAndGetterReturns_Int()
    {
      string title = "test title";
      string description = "test order";
      Order newOrder = new Order(title, description);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetOrderArguments_ReturnsOrderDescriptionAndTitle_String()
    {
      string orderTitle = "Test Title";
      string orderDescription = "Charity event.";
      Order newOrder = new Order(orderTitle, orderDescription);
      string result = newOrder.OrderDescription;
      Assert.AreEqual(orderDescription, result);
    }
    
    [TestMethod]
    public void SetOrderArguments_SetOrderDescriptionAndTitle_String()
    {
      string orderTitle = "Test Org Holiday Fundraiser";
      string orderDescription = "Charity event.";
      Order newOrder = new Order(orderTitle, orderDescription);
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
      Order newOrder1 = new Order(orderTitle01, orderDescription01);
      Order newOrder2 = new Order(orderTitle02, orderDescription02);
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
      Order newOrder1 = new Order(orderTitle01, orderDescription01);
      Order newOrder2 = new Order(orderTitle02, orderDescription02);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}