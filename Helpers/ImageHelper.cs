using Services.Models.Shared;
using Eastcoast.Models.Shared;
using Eastcoast.Models.Home;
using Services.Models.PageContent;
using System.Collections.Generic;
using System.Linq;

namespace Eastcoast.Helpers
{
    public static class ImageHelper
    {
        public static ImageViewModel MapImageToViewModel(ImageModel image)
        {
            return new ImageViewModel(image.Title, EastcoastUrlHelper.GetImageUrl(image.ImageRelativeUrl));
        }

        public static IEnumerable<ImageViewModel> MapImagesToViewModel(IEnumerable<ImageModel> images)
        {
            return images.Select(a => MapImageToViewModel(a));
        }

        public static HomePageImageViewModel MapLinkImageToViewModel(HomePageImageModel image)
        {
            return new HomePageImageViewModel(image.Title, EastcoastUrlHelper.GetImageUrl(image.ImageRelativeUrl), EastcoastUrlHelper.GetLinkImageUrl(image.LinkUrl));
        }

        public static ResponsiveImageViewModel MapResponsiveImageToViewModel(ResponsiveImageModel image)
        {
            return new ResponsiveImageViewModel(image.Title, EastcoastUrlHelper.GetImageUrl(image.ImageRelativeUrl), EastcoastUrlHelper.GetImageUrl(image.MobileImageRelativeUrl));
        }

        public static IEnumerable<ResponsiveImageViewModel> MapResponsiveImagesToViewModel(IEnumerable<ResponsiveImageModel> images)
        {
            return images.Select(a => MapResponsiveImageToViewModel(a));
        }
    }
}