using Eastcoast.Helpers;
using Eastcoast.Models.Product;
using Services.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eastcoast.Helpers
{
    public class ColourOptionHelper
    {
        public static ColourOptionViewModel MapOptionToViewModel(ColourOptionModel option)
        {
            return new ColourOptionViewModel(
                option.ColourName, 
                ImageHelper.MapImageToViewModel(option.MainImage), 
                ImageHelper.MapImagesToViewModel(option.LargeImages), 
                ImageHelper.MapImagesToViewModel(option.SmallImages)
            );
        }

        public static IEnumerable<ColourOptionViewModel> MapOptionsToViewModel(IEnumerable<ColourOptionModel> option)
        {
            return option.Select(a => new ColourOptionViewModel(
                a.ColourName,
                ImageHelper.MapImageToViewModel(a.MainImage),
                ImageHelper.MapImagesToViewModel(a.LargeImages),
                ImageHelper.MapImagesToViewModel(a.SmallImages)
            ));
        }
    }
}