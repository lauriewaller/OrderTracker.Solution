using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
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
      Order newOrder = new Order("title", "description", 2, "date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      string orderTitle1 = "tacos";
      string orderDescription1 = "all the tacos";
      int orderPrice1 = 2;
      string orderDate1 = "7.25.22";
      string orderTitle2 = "ice cream";
      string orderDescription2 = "rocky road";
      int orderPrice2 = 4;
      string orderDate2 = "7.25.22";
      Order newOrder1 = new Order(orderTitle1, orderDescription1, orderPrice1, orderDate1);
      Order newOrder2 = new Order(orderTitle2, orderDescription2, orderPrice2, orderDate2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

        [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string orderTitle1 = "tacos";
      string orderDescription1 = "all the tacos";
      int orderPrice1 = 2;
      string orderDate1 = "7.25.22";
      Order newOrder = new Order(orderTitle1, orderDescription1, orderPrice1, orderDate1);

      //Act
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }
    
  }
}