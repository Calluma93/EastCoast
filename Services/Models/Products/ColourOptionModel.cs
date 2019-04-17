using Services.Models.Shared;
using System.Collections.Generic;

namespace Services.Models.Products
{
    public class ColourOptionModel
    {
        public ColourOptionModel(string colourName, ImageModel mainImage, IEnumerable<ImageModel> largeImages, IEnumerable<ImageModel> smallImages)
        {
            ColourName = colourName;
            MainImage = mainImage;
            LargeImages = largeImages;
            SmallImages = smallImages;
        }

        public string ColourName { get; private set; }

        public ImageModel MainImage { get; private set; }

        public IEnumerable<ImageModel> LargeImages { get; private set; }

        public IEnumerable<ImageModel> SmallImages { get; private set; }
    }
}
