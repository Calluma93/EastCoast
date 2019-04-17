using System.Collections.Generic;
using Services.Models.Shared;
using Services.Models.Products;

namespace Services.Models.PageContent
{
    public class AboutPageModel : PageModel
    {
        public AboutPageModel(IEnumerable<ResponsiveImageModel> banners, string heading, MetaDataModel metaData, IEnumerable<HomePageImageModel> pageImages, IEnumerable<ContentModel> content, ImageModel eastCoastLogo) 
            : base(banners, heading, metaData)
        {
            PageImages = pageImages;
            Content = content;
            EastCoastLogo = eastCoastLogo;
        }

        public IEnumerable<HomePageImageModel> PageImages { get; private set; }

        public IEnumerable<ContentModel> Content { get; private set; }

        public ImageModel EastCoastLogo { get; private set; }
    }
}
