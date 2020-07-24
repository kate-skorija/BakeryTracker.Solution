using System.Collections.Generic;

namespace BakeryTracker.Models
{
  public class Order
  {
    public static List<Order> _instances = new List<Order> { };
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public string Frequency { get; set; }
    public int Id { get; set; }
    public Order(string title, string description, int price, string date, string frequency)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      Frequency = frequency;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static Order Find(int id)
    {
      return _instances[id -1];
    }
  }
}