using Eastcoast.Models.Shared;
using System.Collections.Generic;

namespace Eastcoast.Models.Home
{
    public class HomePageViewModel : PageViewModel
    {
        public IEnumerable<HomePageImageViewModel> PageImages { get; set; }
    }
}