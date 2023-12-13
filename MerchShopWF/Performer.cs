using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


namespace MerchShopWF;

public partial class Performer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Country { get; set; }

    public int? DebutYear { get; set; }

    public virtual ICollection<Album> Albums { get; set; } = new List<Album>();

    public Performer()
    {
    }

    public Performer (int Id, string? Name, string? Country, int? DebutYear)
    {
        this.Id = Id;
        this.Name = Name;
        this.Country = Country;
        this.DebutYear = DebutYear;
    }
}
