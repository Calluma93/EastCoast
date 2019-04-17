using Eastcoast.Models.Shared;
using Services.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eastcoast.Helpers
{
    public class ProductHelper
    {
        public static IEnumerable<ProductOverviewViewModel> MapProductsToViewModel(IEnumerable<ProductModel> products)
        {
            return products.Select(a => new ProductOverviewViewModel()
            {
                Title = a.Name,
                Url = EastcoastUrlHelper.GetProductUrl(a.Name),
                ImageUrl = EastcoastUrlHelper.GetImageUrl(a.ImageRelativeUrl)
            });
        }
    }
}