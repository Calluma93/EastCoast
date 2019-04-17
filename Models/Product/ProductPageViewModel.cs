using Eastcoast.Models.Shared;
using Eastcoast.Models.Shared.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eastcoast.Models.Product
{
    public class ProductPageViewModel : PageViewModel
    {
        public IEnumerable<ContentViewModel> Content { get; set; }

        public ColourOptionViewModel PrimaryColour { get; set; }

        public IEnumerable<ColourOptionViewModel> ColourOptions { get; set; }

        public SpecificationViewModel Specs { get; set; }
    }
}