using Eastcoast.Models.Shared;
using System.Collections.Generic;

namespace Eastcoast.Models.Shared
{
    public class PageViewModel : LayoutViewModel
    {
        public IEnumerable<ResponsiveImageViewModel> Banners { get; set; }

        public string Heading { get; set; }

        public string MetaTitle { get; set; }

        public string MetaDescription { get; set; }
    }
}