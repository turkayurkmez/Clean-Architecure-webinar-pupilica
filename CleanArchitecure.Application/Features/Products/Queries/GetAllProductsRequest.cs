using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecure.Application.Features.Products.Queries
{
    public record GetAllProductsRequest
    {

    }

    public record GetAllProductsResponse(IEnumerable<ProductForDisplay> Products);
  

    public record ProductForDisplay(int Id, string Name, string? Description, decimal? Price, string? ImageUrl, int? StockCount, DateTime? CreatedDate, DateTime? UpdatedDate);
   
}
