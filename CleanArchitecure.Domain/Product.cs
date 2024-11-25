using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecure.Domain
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string? Description { get; set; }
        public decimal? Price { get; set; }

        public string? ImageUrl { get; set; }
        public int? StockCount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }
}
