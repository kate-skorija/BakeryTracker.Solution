using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;

namespace BakeryTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Test Order", "Test Description", 50, "Test Date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsOrderTitle_String()
    {
      string title = "Test Order";
      Order newOrder = new Order(title, "Test Description", 50, "Test Date");

      string result = newOrder.Title;

      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void GetDescription_ReturnsOrderDescription_String()
    {
      string title = "Test Order";
      string description = "Test Description";
      Order newOrder = new Order(title, description, 50, "Test Date");

      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetPrice_ReturnsOrderPrice_Int()
    {
      string title = "Test Order";
      string description = "Test Description";
      int price = 50;
      Order newOrder = new Order(title, description, price, "Test Date");

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
      Order newOrder = new Order(title, description, price, date);

      int result = newOrder.Date;

      Assert.AreEqual(date, result);
    }
  }
}