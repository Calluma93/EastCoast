using Services.Models.Shared;
using Services.Abstract;
using Services.Models.WhereToBuy;
using System.Collections.Generic;

namespace Services.Concrete
{
    public class RetailerService : IRetailerService
    {
        private static readonly RetailerModel[] retailers =
            new RetailerModel[]
            {
                new RetailerModel("https://www.andertons.co.uk/eastcoast/", "www.andertons.co.uk", new ImageModel("Andertons", "Retailers/where-to-buy-andertons.jpg")),
                new RetailerModel("https://www.guitarguitar.co.uk/eastcoast/", "www.guitarguitar.co.uk", new ImageModel("guitarguitar", "Retailers/where-to-buy-guitar.jpg")),
                new RetailerModel("https://www.pmtonline.co.uk/brands/eastcoast/", "www.pmtonline.co.uk", new ImageModel("PMT", "Retailers/where-to-buy-pmt.jpg"))
            }
        ;

        public IList<RetailerModel> GetRetailers()
        {
            return retailers;
        }
    }
}