using Microsoft.VisualStudio.TestTools.UnitTesting;
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

    // [TestMethod]
    // public void GetAll_ReturnsEmptyList_ItemList()
    // {
    //   // Arrange
    //   List<Item> newList = new List<Item> { };

    //   //Act
    //   List<Item> result = Item.GetAll();

    //   //Asset
    //   CollectionAssert.AreEqual(newList, result);
    // }

    // [TestMethod]
    // public void GetAll_ReturnsItems_ItemList()
    // {
    //   //Arrange
    //   string description01 = "Walk the dog";
    //   string description02 = "Wash the dishes";
    //   Item newItem1 = new Item(description01);
    //   Item newItem2 = new Item(description02);
    //   List<Item> newList = new List<Item> { newItem1, newItem2 };

    //   //Act
    //   List<Item> result = Item.GetAll();
      
    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }
  }
}