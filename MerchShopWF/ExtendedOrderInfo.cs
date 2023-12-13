using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchShopWF
{
    internal class ExtendedOrderInfo
    {
        public int Id { get; set; }

        public DateOnly? Date { get; set; }

        public int? TotalPrice { get; set; }

        public string? DeliveryAddress { get; set; }

        public string? Status { get; set; }

        public int? CustomerId { get; set; }
        public string CustomerName { get; set; }

    }
}
