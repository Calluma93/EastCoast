using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services.Abstract;
using Eastcoast.Models.WhereToBuy;
using Services.Models.PageContent;
using Eastcoast.Helpers;
using Services.Models.WhereToBuy;

namespace Eastcoast.Controllers
{
    public class WhereToBuyController : BaseController
    {
        private readonly IRetailerService retailerService;

        public WhereToBuyController(IPageContentService pageContentService, IProductsService productsService, IRetailerService retailerService)
            : base(pageContentService, productsService)
        {
            this.retailerService = retailerService;
        }
        
        public ActionResult Index()
        {
            IList<RetailerViewModel> retailers =
                retailerService.GetRetailers().Select(
                    a => new RetailerViewModel()
                    {
                       Image = ImageHelper.MapImageToViewModel(a.Image),
                       Title = a.Title,
                       WebsiteUrl = a.WebsiteUrl
                    }
                ).ToList();

            WhereToBuyPageModel whereToBuyPage = pageContentService.WhereToBuyPage;

            WhereToBuyPageViewModel viewModel = new WhereToBuyPageViewModel()
            {
                Banners = ImageHelper.MapResponsiveImagesToViewModel(whereToBuyPage.Banners),
                Heading = whereToBuyPage.Heading,
                SubHeading = whereToBuyPage.SubHeading,
                Retailers = WhereToBuyHelper.RandomiseOrder(retailers),
                MetaTitle = whereToBuyPage.MetaData.Title,
                MetaDescription = whereToBuyPage.MetaData.MetaDescription
            };

            SetLayout(viewModel);

            return View(viewModel);
        }
    }
}