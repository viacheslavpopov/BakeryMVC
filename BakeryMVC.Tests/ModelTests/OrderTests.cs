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
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetId_OrderInstantiateWithAnIdAndGetterReturns_Int()
    {
      string description = "test order";
      Order newOrder = new Order(description);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      //Arrange
      string orderDescription = "Charity event.";
      Order newOrder = new Order(orderDescription);
      string result = newOrder.OrderDescription;
      Assert.AreEqual(orderDescription, result);
    }
    
    [TestMethod]
    public void SetOrderDescription_SetOrderDescription_String()
    {
      string orderDescription = "Charity event.";
      Order newOrder = new Order(orderDescription);
      string updatedOrderDescription = "Weekly restaurant shipment";
      newOrder.OrderDescription = updatedOrderDescription;
      string result = newOrder.OrderDescription;
      Assert.AreEqual(updatedOrderDescription, result);
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
      //Arrange
      string orderDescription01 = "Weekly restaurant shipment";
      string orderDescription02 = "Charity event";
      Order newOrder1 = new Order(orderDescription01);
      Order newOrder2 = new Order(orderDescription02);
      List<Order> newOrderList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();
      
      //Assert
      CollectionAssert.AreEqual(newOrderList, result);
    }
  }
}