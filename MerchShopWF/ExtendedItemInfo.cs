using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchShopWF
{
    internal class ExtendedItemInfo
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int? Price { get; set; }

        public int? AlbumId { get; set; }

        public string AlbumName { get; set; }
    }
}
