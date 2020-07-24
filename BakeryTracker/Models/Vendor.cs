using System.Collections.Generic;
using System;

namespace BakeryTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public Vendor(string vendorName)
    {
      Name = vendorName;
    }
  }
}