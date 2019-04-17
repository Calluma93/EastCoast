using Services.Models.Shared;
using System.Collections.Generic;

namespace Services.Models.PageContent
{
    public class PageModel
    {
        public PageModel(IEnumerable<ResponsiveImageModel> banners, string heading, MetaDataModel metaData)
        {
            Banners = banners;
            Heading = heading;
            MetaData = metaData;
        }

        public IEnumerable<ResponsiveImageModel> Banners { get; private set; }

        public string Heading { get; private set; }

        public MetaDataModel MetaData { get; private set; }
    }
}
