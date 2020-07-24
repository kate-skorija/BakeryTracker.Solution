using System.Collections.Generic;

namespace BakeryTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public string Frequency { get; set; }
    public Order(string title, string description, int price, string date, string frequency)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      Frequency = frequency;
    }
  }
}