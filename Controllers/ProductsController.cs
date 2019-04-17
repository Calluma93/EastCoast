using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services.Abstract;
using Eastcoast.Models.Category;
using Services.Models.PageContent;
using Eastcoast.Models.Products;
using Eastcoast.Helpers;

namespace Eastcoast.Controllers
{
    public class ProductsController : BaseController
    {
        public ProductsController(IPageContentService pageContentService, IProductsService productsService) 
            : base(pageContentService, productsService)
        {}
        
        public ActionResult Index()
        {
            IEnumerable<CategoryViewModel> categories =
                productsService.GetCategories().Select(a =>
                    new CategoryViewModel()
                    {
                        Title = a.Title,
                        Name = a.Name,
                        CategoryImage = ImageHelper.MapImageToViewModel(a.CategoryImage),
                        LinkUrl = EastcoastUrlHelper.GetCategoryUrl(a.Name),
                    }
                );

            PageModel productsPageContent = pageContentService.ProductsPage;

            ProductsPageViewModel viewModel = new ProductsPageViewModel()
            {
                Banners = ImageHelper.MapResponsiveImagesToViewModel(productsPageContent.Banners),
                Heading = productsPageContent.Heading,
                MetaTitle = productsPageContent.MetaData.Title,
                MetaDescription = productsPageContent.MetaData.MetaDescription,
                Categories = categories
            };

            SetLayout(viewModel);

            return View(viewModel);
        }
    }
}