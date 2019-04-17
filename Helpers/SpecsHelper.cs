using Eastcoast.Models.Product;
using Services.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eastcoast.Helpers
{
    public class SpecsHelper
    {
        public static SpecificationViewModel MapSpecsToViewModel(SpecificationModel specs)
        {
            return new SpecificationViewModel(specs.Body, specs.Neck, specs.Fingerboard, specs.Contruction, specs.Pickups, specs.ScaleLength, specs.IsAmp);
        }
    }
}