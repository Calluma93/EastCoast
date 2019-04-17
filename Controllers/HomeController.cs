using Eastcoast.Helpers;
using Services.Models.PageContent;
using System.Web.Mvc;
using Services.Abstract;
using System.Linq;
using System.Collections.Generic;
using Eastcoast.Models.WhereToBuy;
using Eastcoast.Models.Home;

namespace Eastcoast.Controllers
{
    public class HomeController : BaseController
    {

        public HomeController(IPageContentService pageContentService, IProductsService productsService) : 
            base(pageContentService, productsService)
        {
        }
        
        public ActionResult Index()
        {
            HomePageModel homePageContent = pageContentService.HomePage;

            HomePageViewModel viewModel =
                new HomePageViewModel()
                {
                    Banners = ImageHelper.MapResponsiveImagesToViewModel(homePageContent.Banners),
                    PageImages = homePageContent.PageImages.Select(b => ImageHelper.MapLinkImageToViewModel(b)),
                    Heading = homePageContent.Heading,
                    MetaTitle = homePageContent.MetaData.Title,
                    MetaDescription = homePageContent.MetaData.MetaDescription
                }
            ;

            SetLayout(viewModel);

            return View(viewModel);
        }
    }
}