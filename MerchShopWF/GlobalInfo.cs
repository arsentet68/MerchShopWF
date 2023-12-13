using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchShopWF
{
    internal class GlobalInfo
    {
        public int OrderID { get; set; }
        public DateOnly? Date { get; set; }
        public int? TotalPrice { get; set; }
        public string? Status { get; set; }
        public string Customer { get; set; }
        public string Performer { get; set; }
        public string Album { get; set; }
        public string Item { get; set; }
        public int? Price { get; set; }
        public int? Units { get; set; }


    }
}
