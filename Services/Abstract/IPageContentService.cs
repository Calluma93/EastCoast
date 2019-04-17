using Services.Models.PageContent;
using Services.Models.WhereToBuy;

namespace Services.Abstract
{
    public interface IPageContentService
    {
        LayoutModel Layout
        {
            get;
        }

        HomePageModel HomePage
        {
            get;
        }

        WhereToBuyPageModel WhereToBuyPage
        {
            get;
        }

        PageModel ProductsPage
        {
            get;
        }

        AboutPageModel AboutPage
        {
            get;
        }
    }
}
