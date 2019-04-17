using Eastcoast.Models.Shared;

namespace Eastcoast.Models.Home
{
    public class HomePageImageViewModel : ImageViewModel
    {
        public HomePageImageViewModel(string title, string imageUrl, string linkUrl) : base(title, imageUrl)
        {
            LinkUrl = linkUrl;
        }

        public string LinkUrl { get; set; }
    }
}