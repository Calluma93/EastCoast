using System.Collections.Generic;
using Services.Models.Shared;

namespace Services.Models.PageContent
{
    public class HomePageModel : PageModel
    {
        public HomePageModel(
            IEnumerable<ResponsiveImageModel> banners, string heading, MetaDataModel metaData, IEnumerable<HomePageImageModel> pageImages) 
                : base(banners, heading, metaData)
        {
            PageImages = pageImages;
        }

        public IEnumerable<HomePageImageModel> PageImages { get; private set; }
    }
}
