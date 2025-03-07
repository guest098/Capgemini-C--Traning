using System;
using System.Collections.Generic;

namespace WebApplication3.Models;

public partial class Product
{
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public string ProductDescription { get; set; } = null!;

    public decimal Price { get; set; }

    public int Stock { get; set; }
}
