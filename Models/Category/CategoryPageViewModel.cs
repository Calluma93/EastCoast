using Eastcoast.Models.Shared;
using Eastcoast.Models.Shared.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eastcoast.Models.Category
{
    public class CategoryPageViewModel : PageViewModel
    {
        public IEnumerable<ProductOverviewViewModel> Products { get; set; }
    }
}