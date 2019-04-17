using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services.Abstract;
using Services.Models.Products;
using Services.Exceptions;
using Eastcoast.Models.Product;
using Eastcoast.Helpers;

namespace Eastcoast.Controllers
{
    public class ProductController : BaseController
    {
        public ProductController(IPageContentService pageContentService, IProductsService productsService) 
            : base(pageContentService, productsService)
        {}
        
        public ActionResult Index(string productName)
        {
            CategoryModel category;
            try
            {
                category = productsService.GetCategoryByProduct(productName);
            }
            catch(ClientException)
            {
                return NotFoundResult();
            }

            ProductModel product = category.Products.Single(a => a.Name == productName);

            ProductPageViewModel viewModel = new ProductPageViewModel()
            {
                Banners = ImageHelper.MapResponsiveImagesToViewModel(product.Banners),
                Heading = product.Heading,
                MetaTitle = product.MetaData.Title,
                MetaDescription = product.MetaData.MetaDescription,
                Content = ContentHelper.MapContentToViewModel(product.Content),
                PrimaryColour = ColourOptionHelper.MapOptionToViewModel(product.PrimaryColour),
                ColourOptions = ColourOptionHelper.MapOptionsToViewModel(product.ColourOptions),
                Specs = SpecsHelper.MapSpecsToViewModel(product.Specs)
            };

            SetLayout(viewModel);

            return View(viewModel);
        }
    }
}