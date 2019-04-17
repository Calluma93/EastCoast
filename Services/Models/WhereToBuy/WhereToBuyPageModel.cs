using Services.Models.PageContent;
using Services.Models.Shared;
using System.Collections.Generic;

namespace Services.Models.WhereToBuy
{
    public class WhereToBuyPageModel : PageModel
    {
        public WhereToBuyPageModel(IEnumerable<ResponsiveImageModel> banners, string heading, string subHeading, MetaDataModel metaData) 
            : base(banners, heading, metaData)
        {
            SubHeading = subHeading;
        }

        public string SubHeading { get; private set; }
    }
}
