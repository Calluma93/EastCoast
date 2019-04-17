using Eastcoast.Models.Shared;
using Eastcoast.Models.Shared.Content;
using System.Collections.Generic;
using Eastcoast.Models.Home;

namespace Eastcoast.Models.About
{
    public class AboutPageViewModel : PageViewModel
    {
        public IEnumerable<ContentViewModel> Content { get; set; }

        public IEnumerable<HomePageImageViewModel> PageImages { get; set; }

        public ImageViewModel EastCoastLogo { get; set; }
    }
}