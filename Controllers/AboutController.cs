using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services.Abstract;
using Services.Models.PageContent;
using Eastcoast.Models.About;
using Eastcoast.Helpers;

namespace Eastcoast.Controllers
{
    public class AboutController : BaseController
    {
        public AboutController(IPageContentService pageContentService, IProductsService productsService) 
            : base(pageContentService, productsService)
        {
        }

        public ActionResult Index()
        {
            AboutPageModel aboutPageContent = pageContentService.AboutPage;

            AboutPageViewModel viewModel = new AboutPageViewModel()
            {
                Banners = ImageHelper.MapResponsiveImagesToViewModel(aboutPageContent.Banners),
                PageImages = aboutPageContent.PageImages.Select(b => ImageHelper.MapLinkImageToViewModel(b)),
                Heading = aboutPageContent.Heading,
                MetaTitle = aboutPageContent.MetaData.Title,
                MetaDescription = aboutPageContent.MetaData.MetaDescription,
                Content = ContentHelper.MapContentToViewModel(aboutPageContent.Content),
                EastCoastLogo = ImageHelper.MapImageToViewModel(aboutPageContent.EastCoastLogo) 
            };

            SetLayout(viewModel);

            return View(viewModel);
        }
    }
}