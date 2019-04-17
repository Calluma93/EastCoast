using Services.Models.Shared;

namespace Services.Models.WhereToBuy
{
    public class RetailerModel
    {
        public RetailerModel(string websiteUrl, string title, ImageModel image)
        {
            WebsiteUrl = websiteUrl;
            Title = title;
            Image = image;
        }

        public string WebsiteUrl { get; private set; }

        public string Title { get; private set; }

        public ImageModel Image { get; private set; }
    }
}
