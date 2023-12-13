using System;
using System.Collections.Generic;

namespace MerchShopWF;

public partial class Item
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int Price { get; set; }

    public int AlbumId { get; set; }

    public virtual Album? Album { get; set; }

    public virtual ICollection<ItemOrder> ItemOrders { get; set; } = new List<ItemOrder>();

    public Item()
    {

    }

    public Item(int Id, string? Name, int Price, int AlbumId)
    {
        this.Id = Id;
        this.Name = Name;
        this.Price = Price;
        this.AlbumId = AlbumId;
    }
}
