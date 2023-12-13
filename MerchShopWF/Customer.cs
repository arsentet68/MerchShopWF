using System;
using System.Collections.Generic;

namespace MerchShopWF;

public partial class Customer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public Customer()
    {

    }

    public Customer(int Id, string? Name, string Email)
    {
        this.Id = Id;
        this.Name = Name;
        this.Email = Email;
    }
}
