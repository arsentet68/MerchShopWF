using System;
using System.Collections.Generic;

namespace MerchShopWF;

public partial class Order
{
    public int Id { get; set; }

    public DateOnly Date { get; set; }

    public int? TotalPrice { get; set; }

    public string? DeliveryAddress { get; set; }

    public string? Status { get; set; }

    public int CustomerId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<ItemOrder> ItemOrders { get; set; } = new List<ItemOrder>();

    public Order()
    {

    }

    public Order(int Id, DateOnly Date, int? TotalPrice, string? DeliveryAddress, string? Status, int CustomerId)
    {
        this.Id = Id;
        this.Date = Date;
        this.TotalPrice = TotalPrice;
        this.DeliveryAddress = DeliveryAddress;
        this.Status = Status;
        this.CustomerId = CustomerId;
    }
}
