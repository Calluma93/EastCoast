using Eastcoast.Models.Shared;
using System.Collections.Generic;

namespace Eastcoast.Models.Product
{
    public class ColourOptionViewModel
    {
        public ColourOptionViewModel(string colourName, ImageViewModel mainImage, IEnumerable<ImageViewModel> largeImages, IEnumerable<ImageViewModel> smallImages)
        {
            ColourName = colourName;
            MainImage = mainImage;
            LargeImages = largeImages;
            SmallImages = smallImages;
        }

        public string ColourName { get; set; }

        public ImageViewModel MainImage { get; set; }

        public IEnumerable<ImageViewModel> LargeImages { get; set; }

        public IEnumerable<ImageViewModel> SmallImages { get; set; }
    }
}