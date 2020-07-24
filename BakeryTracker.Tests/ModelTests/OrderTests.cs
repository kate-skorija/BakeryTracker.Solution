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
      Order newOrder = new Order("Test Order", "Test Description");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsOrderTitle_String()
    {
      string title = "Test Order";
      Order newOrder = new Order(title);

      string result = newOrder.Title;

      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void GetDescription_ReturnsOrderDescription_String()
    {
      string title = "Test Order";
      string description = "Test Description";
      Order newOrder = new Order(title, description);

      string result = newOrder.Description;

      Assert.AreEqual(description, result);

    }
  }
}