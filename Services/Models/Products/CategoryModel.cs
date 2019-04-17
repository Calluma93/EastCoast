using Services.Models.Shared;
using System.Collections.Generic;

namespace Services.Models.Products
{
    public class CategoryModel
    {
        public CategoryModel(string name, string title, string heading, IEnumerable<ResponsiveImageModel> banners, ImageModel categoryImage, IEnumerable<ProductModel> products, MetaDataModel metaData)
        {
            Name = name;
            Title = title;
            Heading = heading;
            Banners = banners;
            CategoryImage = categoryImage;
            Products = products;
            MetaData = metaData;
        }

        public string Name { get; private set; }

        public string Title { get; private set; }

        public string Heading { get; private set; }

        public IEnumerable<ResponsiveImageModel> Banners { get; private set; }

        public ImageModel CategoryImage { get; private set; }

        public IEnumerable<ProductModel> Products { get; private set; }

        public MetaDataModel MetaData { get; private set; }
    }
}
