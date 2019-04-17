using Services.Models.WhereToBuy;
using System.Collections.Generic;

namespace Services.Abstract
{
    public interface IRetailerService
    {
        IList<RetailerModel> GetRetailers();
    }
}