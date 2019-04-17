using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services.Abstract;
using Services.Models.Products;
using Services.Exceptions;
using Eastcoast.Models.Category;
using Eastcoast.Helpers;
using Services.Models.PageContent;

namespace Eastcoast.Controllers
{
    public class CategoryController : BaseController
    {
        public CategoryController(IPageContentService pageContentService, IProductsService productsService) 
            : base(pageContentService, productsService)
        {}
        
        public ActionResult Index(string categoryName)
        {
            CategoryModel category;
            try
            {
                category = productsService.GetCategory(categoryName);
            }
            catch(ClientException)
            {
                return NotFoundResult();
            }

            CategoryPageViewModel viewModel = new CategoryPageViewModel()
            {
                Banners = ImageHelper.MapResponsiveImagesToViewModel(category.Banners),
                Heading = category.Heading,
                MetaTitle = category.MetaData.Title,
                MetaDescription = category.MetaData.MetaDescription,
                Products = ProductHelper.MapProductsToViewModel(category.Products)
            };

            SetLayout(viewModel);

            return View(viewModel);
        }
    }
}