using Eastcoast.Models.Shared;
using Services.Abstract;
using Services.Models.PageContent;
using Eastcoast.Helpers;
using System.Web.Mvc;
using System.Linq;
using System.Collections.Generic;
using Services.Models.Products;

namespace Eastcoast.Controllers
{
    public abstract class BaseController : Controller
    {
        protected readonly IPageContentService pageContentService;
        protected readonly IProductsService productsService;

        public BaseController(IPageContentService pageContentService, IProductsService productsService)
        {
            this.pageContentService = pageContentService;
            this.productsService = productsService;
        }

        public void SetLayout(LayoutViewModel layoutViewModel)
        {
            LayoutModel layout = pageContentService.Layout;

            IEnumerable<CategoryModel> categories = productsService.GetCategories();

            layoutViewModel.LogoImage = ImageHelper.MapImageToViewModel(layout.LogoImage);
            layoutViewModel.HamburgerImage = ImageHelper.MapImageToViewModel(layout.HamburgerImage);
            layoutViewModel.MainMenu =
                new MenuItemViewModel[]
                {
                    new MenuItemViewModel("Home", Url.Action("Index", "Home")),
                    new MenuItemViewModel("About", Url.Action("Index", "About")),
                    new MenuItemViewModel("Products", Url.Action("Index", "Products"), categories.Select(a => new MenuItemViewModel(a.Name, EastcoastUrlHelper.GetCategoryUrl(a.Name)))),
                    new MenuItemViewModel("Where To Buy", Url.Action("Index", "WhereToBuy"))
                };
        }

        protected ActionResult NotFoundResult()
        {
            LayoutViewModel layoutModel = new LayoutViewModel();
            SetLayout(layoutModel);
            Response.StatusCode = 404;
            return View("NotFound", layoutModel);
        }
    }
}