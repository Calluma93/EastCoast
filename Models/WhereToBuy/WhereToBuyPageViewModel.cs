using Eastcoast.Models.Shared;
using System.Collections.Generic;

namespace Eastcoast.Models.WhereToBuy
{
    public class WhereToBuyPageViewModel : PageViewModel
    {
        public string SubHeading { get; set; }

        public IList<RetailerViewModel> Retailers { get; set; }
    }
}