using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchShopWF
{
    internal class ExtendedAlbumInfo
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int? Year { get; set; }

        public int PerformerId { get; set; }

        public string PerformerName { get; set; }
    }
}
