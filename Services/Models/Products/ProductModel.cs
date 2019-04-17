using Services.Models.Shared;
using System.Collections.Generic;

namespace Services.Models.Products
{
    public class ProductModel
    {
        public ProductModel(
            string name, string heading, string imageRelativeUrl, IEnumerable<ResponsiveImageModel> banners, IEnumerable<ContentModel> content, 
            SpecificationModel specs, ColourOptionModel primaryColour, IEnumerable<ColourOptionModel> colourOptions, MetaDataModel metaData)
        {
            Name = name;
            Heading = heading;
            ImageRelativeUrl = imageRelativeUrl;
            Banners = banners;
            Content = content;
            Specs = specs;
            PrimaryColour = primaryColour;
            ColourOptions = colourOptions;
            MetaData = metaData;
        }

        public string Name { get; private set; }

        public string Heading { get; private set; }

        public string ImageRelativeUrl { get; private set; }

        public IEnumerable<ResponsiveImageModel> Banners { get; private set; }

        public IEnumerable<ContentModel> Content { get; private set; }

        public SpecificationModel Specs { get; private set; }

        public ColourOptionModel PrimaryColour { get; private set; }

        public IEnumerable<ColourOptionModel> ColourOptions { get; private set; }

        public MetaDataModel MetaData { get; private set; }
    }
}
