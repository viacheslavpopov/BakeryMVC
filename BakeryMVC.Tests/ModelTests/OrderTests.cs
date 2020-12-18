using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryMVC.Models; 
using System;

namespace BakeryMVC.Test
{
  [TestClass]
  public class OrderTests //: IDisposable
  {

    // public void Dispose()
    // {
    //   Order.ClearAll();
    // }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetId_OrderInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string description = "test order";
      Order newOrder = new Order(description);

      //Act
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    // [TestMethod]
    // public void Find_ReturnsCorrectItem_Item()
    // {
    //   //Arrange
    //   string description01 = "Walk the dog";
    //   string description02 = "Wash the dishes";
    //   Item newItem1 = new Item(description01);
    //   Item newItem2 = new Item(description02);

    //   //Act
    //   Item result = Item.Find(2);

    //   //Assert
    //   Assert.AreEqual(newItem2, result);
    // }

    // [TestMethod]
    // public void GetDescription_ReturnsDescription_String()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";//creates instance
    //   Item newItem = new Item(description); // pass new instance through Item to add to list
    //   //Act
    //   string result = newItem.Description; //calls on new item added to list
    //   //Assert
    //   Assert.AreEqual(description, result); //tests that expected result matches description of new item
    // }
    
    // [TestMethod]
    // public void SetDescription_SetDescription_String()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";
    //   Item newItem = new Item(description);

    //   //Act
    //   string updatedDescription = "Do the dishes";
    //   newItem.Description = updatedDescription;
    //   string result = newItem.Description;

    //   //Assert
    //   Assert.AreEqual(updatedDescription, result);
    // }

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