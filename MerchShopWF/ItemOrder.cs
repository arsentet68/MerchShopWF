using System;
using System.Collections.Generic;

namespace MerchShopWF;

public partial class ItemOrder
{
    public int ItemId { get; set; }

    public int OrderId { get; set; }

    public int? Units { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
