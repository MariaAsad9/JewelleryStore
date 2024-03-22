using System;
using System.Collections.Generic;

namespace JewelleryStore.Models;

public partial class Item
{
    public int Id { get; set; }

    public string? ItemName { get; set; }

    public string? Color { get; set; }

    public string? GemstoneType { get; set; }

    public int? Quantity { get; set; }

    public decimal? Price { get; set; }
}
