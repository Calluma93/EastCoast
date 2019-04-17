using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eastcoast.Models.Shared
{
    public class BannerViewModel
    {
        public BannerViewModel(ResponsiveImageViewModel bannerImages)
        {
            BannerImages = bannerImages;
        }

        public ResponsiveImageViewModel BannerImages { get; set; }
    }
}