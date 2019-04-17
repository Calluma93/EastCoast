using Eastcoast.Models.Category;
using Eastcoast.Models.Shared;
using System.Collections.Generic;

namespace Eastcoast.Models.Products
{
    public class ProductsPageViewModel : PageViewModel
    {
        public IEnumerable<CategoryViewModel> Categories { get; set; }
    }
}