using PackerTracker.Models;
using System.Collections.Generic;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PackerTracker.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Item.ClearAll();
    }

    [TestMethod]
    public void Item_InstanceOfItemIsCreated_Item()
    {
      string test = "hi";
      Item newItem = new Item(test);
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }
    [TestMethod]
    public void Item_InstanceOfItemIsCreatedWithName_String()
    {
      string test = "hi";
      Item newItem = new Item(test);
      Assert.AreEqual(test, newItem.Name);
    }

    [TestMethod]
    public void GetTotalCost_ReturnsCostOfUnpurchased_Decimal()
    {
      Item itemOne = new Item("Tent", "29.99", false);
      Item itemTwo = new Item("Sleeping Bag", "19.99", false);
      Item itemThree = new Item("Marshmallowws", "9.99", false);
      Item itemFour = new Item("Chocolate", "9.99", true);
      decimal totalCost = 59.97m;

      decimal result = Item.GetTotalCost();

      Assert.AreEqual(totalCost, result);
    }


    [TestMethod]
    public void GetListForPurchase_ReturnsListOfUnpurchasedItems_List()
    {
      Item itemOne = new Item("Tent", "29.99", false);
      Item itemTwo = new Item("Sleeping Bag", "19.99", false);
      Item itemThree = new Item("Marshmallowws", "9.99", false);
      Item itemFour = new Item("Chocolate", "9.99", true);

      List<Item> testList = new List<Item> { itemOne, itemTwo, itemThree };

      CollectionAssert.AreEqual(testList, Item.GetListForPurchase());

    }


  }
}