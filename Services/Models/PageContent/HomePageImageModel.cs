using Services.Models.Shared;

namespace Services.Models.PageContent
{
    public class HomePageImageModel : ImageModel
    {
        public HomePageImageModel(string title, string imageRelativeUrl, string linkUrl) : base(title, imageRelativeUrl)
        {
            LinkUrl = linkUrl;
        }

        public string LinkUrl { get; private set; }
    }
}
