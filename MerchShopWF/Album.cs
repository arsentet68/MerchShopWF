using System;
using System.Collections.Generic;

namespace MerchShopWF;

public partial class Album
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Year { get; set; }

    public int PerformerId { get; set; }

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual Performer? Performer { get; set; }

    public Album()
    {

    }

    public Album(int Id, string? Name, int? Year, int PerformerId)
    {
        this.Id = Id;
        this.Name = Name;
        this.Year = Year;
        this.PerformerId = PerformerId;
    }
}
