using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryMVC.Models;
using System.Collections.Generic;
using System;

namespace BakeryMVC.Tests
{
  [TestClass]
  public class VendorTest //: IDisposable
  {
    // public void Dispose()
    // {
    //   Vendor.ClearAll();
    // }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test Vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsVenderName_String()
    {
      //Arrange
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name);

      //Act
      string result = newVendor.VendorName;

      //Assert
      Assert.AreEqual(name, result);
    }

//     [TestMethod]
//     public void GetId_ReturnsCategoryId_Int()
//     {
//       //Arrange
//       string name = "Test Category";
//       Category newCategory = new Category(name);

//       //Act
//       int result = newCategory.Id;

//       //Assert
//       Assert.AreEqual(1, result);
//     }

//     [TestMethod]
//     public void GetAll_ReturnsAllCategoryObjects_CategoryList()
//     {
//       //Arrange
//       string name01 = "Work";
//       string name02 = "School";
//       Category newCategory1 = new Category(name01);
//       Category newCategory2 = new Category(name02);
//       List<Category> newList = new List<Category> { newCategory1, newCategory2 };

//       //Act
//       List<Category> result = Category.GetAll();

//       //Assert
//       CollectionAssert.AreEqual(newList, result);
//     }

//     [TestMethod]
//     public void Find_ReturnsCorrectCategory_Category()
//     {
//     //Arrange
//     string name01 = "Work";
//     string name02 = "School";
//     Category newCategory1 = new Category(name01);
//     Category newCategory2 = new Category(name02);

//     //Act
//     Category result = Category.Find(2);

//     //Assert
//     Assert.AreEqual(newCategory2, result);
//     }

//     [TestMethod]
//     public void AddItem_AssociatesItemWithCategoryItemList()
//     {
//       //Arrange
//       string description = "Walk the dog.";
//       Item newItem = new Item(description);
//       List<Item> newList = new List<Item> { newItem };

//       string name = "Work";
//       Category newCategory = new Category(name);
//       newCategory.AddItem(newItem);

//       //Act
//       List<Item> result = newCategory.Items;

//       //Assert
//       CollectionAssert.AreEqual(newList, result);
//     }
  }
}