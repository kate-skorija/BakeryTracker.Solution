using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;
using System.Collections.Generic;
using System;


namespace BakeryTracker.Tests
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
      Order newOrder = new Order("Test Order", "Test Description", 50, "Test Date", "Test Frequency");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsOrderTitle_String()
    {
      string title = "Test Order";
      Order newOrder = new Order(title, "Test Description", 50, "Test Date", "Test Frequency");

      string result = newOrder.Title;

      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void GetDescription_ReturnsOrderDescription_String()
    {
      string title = "Test Order";
      string description = "Test Description";
      Order newOrder = new Order(title, description, 50, "Test Date", "Test Frequency");

      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetPrice_ReturnsOrderPrice_Int()
    {
      string title = "Test Order";
      string description = "Test Description";
      int price = 50;
      Order newOrder = new Order(title, description, price, "Test Date", "Test Frequency");

      int result = newOrder.Price;

      Assert.AreEqual(price, result);
    }
    [TestMethod]
    public void GetDate_ReturnsOrderDate_String()
    {
      string title = "Test Order";
      string description = "Test Description";
      int price = 50;
      string date = "July 15, 2020";
      Order newOrder = new Order(title, description, price, date, "Test Frequency");

      string result = newOrder.Date;

      Assert.AreEqual(date, result);
    }
    [TestMethod]
    public void GetFrequency_ReturnsOrderFrequency_String()
    {
      string title = "Test Order";
      string description = "Test Description";
      int price = 50;
      string date = "July 15, 2020";
      string frequency = "Once a week, on Tuesdays";
      Order newOrder = new Order(title, description, price, date, frequency);

      string result = newOrder.Frequency;

      Assert.AreEqual(frequency, result);
    }
    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      string title = "Test Order";
      string description = "Test Description";
      int price = 50;
      string date = "July 15, 2020";
      string frequency = "Once a week, on Tuesdays";
      Order newOrder = new Order(title, description, price, date, frequency);

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllOrderObjects_OrderList()
    {
      string name1 = "Test Order One";
      string name2 = "Test Order Two";
      Order newOrder1 = new Order(name1, "Test1 Description", 50, "Test1 Date", "Test1 Frequency" );
      Order newOrder2 = new Order(name2, "Test2 Description", 100, "Test2 Date", "Test2 Frequency");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}