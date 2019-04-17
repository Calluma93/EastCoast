using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eastcoast.Models.Shared
{
    public class ResponsiveImageViewModel : ImageViewModel
    {
        public ResponsiveImageViewModel(string title, string imageUrl, string mobileImageUrl)
            : base(title, imageUrl)
        {
            MobileImageUrl = mobileImageUrl;
        }

        public string MobileImageUrl { get; private set; }
    }
}