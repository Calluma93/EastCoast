using Services.Abstract;
using Services.Models.PageContent;
using Services.Models.Products;
using Services.Models.Shared;
using Services.Models.WhereToBuy;

namespace Services.Concrete
{
    public class PageContentService : IPageContentService
    {
        private readonly LayoutModel layout =
            new LayoutModel(
                new ImageModel("Eastcoast Logo", "Shared/eastcoast-logo.png"),
                new ImageModel("Hamburger Menu Icon", "Shared/hamburger-menu.png")
            );

        private readonly HomePageModel homePage = 
            new HomePageModel(
                new ResponsiveImageModel[] {
                    new ResponsiveImageModel("Home Page Banner","Banners/home-banner-1.jpg", "Mobile/home-banner-1.jpg"),
                    new ResponsiveImageModel("Home Page Banner","Banners/home-banner-2.jpg", "Mobile/home-banner-2.jpg"),
                    new ResponsiveImageModel("Home Page Banner","Banners/home-banner-3.jpg", "Mobile/home-banner-3.jpg"),
                    new ResponsiveImageModel("Home Page Banner","Banners/home-banner-4.jpg", "Mobile/home-banner-4.jpg"),
                    new ResponsiveImageModel("Home Page Banner","Banners/home-banner-5.jpg", "Mobile/home-banner-5.jpg"),
                    new ResponsiveImageModel("Home Page Banner","Banners/home-banner-6.jpg", "Mobile/home-banner-6.jpg")
                }, 
                "this year's players choice",
                new MetaDataModel("EastCoast Guitars | Home", "EastCoast Guitars are a brand of affordable instruments for beginner guitarists and bassists. EastCoast instruments are designed to be reliable, easy to play and exciting to learn on. Original designs mix with fresh takes on classics to make the EastCoast line - up one to watch."),
                new HomePageImageModel[] {
                    new HomePageImageModel("EC10G Lifestyle Image","Home/ec10g-lifestyle.jpg", "product/ec10g"),
                    new HomePageImageModel("GS100H Lifestyle Image","Home/gs100h-lifestyle.jpg", "product/gs100h"),
                    new HomePageImageModel("GDT320 Lifestyle Image","Home/gdt320-lifestyle.jpg", "product/gdt320"),
                    new HomePageImageModel("MKOA Lifestyle Image","About/about-thumb-1.jpg", "product/mkoa"),
                    new HomePageImageModel("GL130 Lifestyle Image","Home/gl130-lifestyle.jpg", "product/gl130"),
                    new HomePageImageModel("GTB005T Lifestyle Image","Home/gtb005t-lifestyle.jpg", "product/gtb005t"),
                    new HomePageImageModel("About Us Nav","Home/about-nav.jpg", "about"),
                    new HomePageImageModel("Products Nav","Home/products-nav.jpg", "products"),
                    new HomePageImageModel("Where To Buy Nav","Home/where-to-buy-nav.jpg", "where-to-buy")
                }
            );

        private readonly WhereToBuyPageModel whereToBuyPage = 
            new WhereToBuyPageModel(
                new ResponsiveImageModel[]
                {
                    new ResponsiveImageModel("Where To Buy Page Banner", "Banners/retailers-banner.jpg", "Mobile/retailers-banner.jpg")
                },
                "where to buy",
                "EastCoast guitars are available online and in store at these participating vendors",
                new MetaDataModel("EastCoast Guitars | Where to Buy", "Click to browse all official vendors of EastCoast guitars.")
            );

        private readonly PageModel productsPage = 
            new PageModel(
                new ResponsiveImageModel[] {
                    new ResponsiveImageModel("Products Page Banner", "Banners/products-banner.jpg", "Mobile/products-banner.jpg"),
                    new ResponsiveImageModel("Products Page Banner", "Banners/products-banner-2.jpg", "Mobile/products-banner-2.jpg")
                },
                "the EastCoast range",
                new MetaDataModel("EastCoast Guitars | Electric Guitars and Basses", "EastCoast guitars are a dynamic range of affordable electric guitars and basses with classic and contemporary models available. EastCoast put quality, playability and affordability first.")
            );

        private readonly AboutPageModel aboutPage =
            new AboutPageModel(
                new ResponsiveImageModel[] {
                    new ResponsiveImageModel("About Page Banner", "Banners/about-banner.jpg", "Mobile/about-banner.jpg")
                },
                "about EastCoast",
                new MetaDataModel("EastCoast Guitars | About Us", "Learn about EastCoast Guitars here."),
                new HomePageImageModel[] {
                    new HomePageImageModel("About Page Image 1","Home/gdt320-lifestyle.jpg", "product/gdt320"),
                    new HomePageImageModel("About Page Image 2","About/about-thumb-1.jpg", "product/mkoa"),
                    new HomePageImageModel("About Page Image 3","About/about-thumb-2.jpg", "product/gdt230"),
                    new HomePageImageModel("About Page Image 4","About/about-thumb-3.jpg", "product/gl130"),
                },
                new ContentModel[]
                {
                    new SubHeadingModel("EastCoast Guitars have been around since 1991, but the real story starts in 2018 when the entire range was overhauled by some of the most experienced guitar players in the UK. "),
                    new QuoteModel("'Absolutely stunning looking guitar for the money, plays well, sounds great, can’t believe how good this is for the price. I’m totally happy with it and love showing it off to my friends as it looks like it cost a lot more than it actually did'","ST, UK Dec 18"),
                    new ParagraphModel("The current range is focused on delivering exceptional value to guitar players & bass players, and includes a selection of popular shapes, styles & colours."),
                    new ParagraphModel("Every effort has been made to ensure that these guitars look and feel significantly better than their price tag might suggest. "),
                    new ParagraphModel("On top of this, every guitar & bass is inspected by a trained guitar technician when it arrives in the UK. Unlike any other budget brand that we know of this means you get a UK set up guitar straight out of the box – it even comes tuned! "),
                    new ParagraphModel("Whether you’re looking for your first guitar & amp starter pack or you want a great value guitar to add to your collection, we’d highly recommend you look at an EastCoast guitar.")
                },
                new ImageModel("Eastcoast Logo","Shared/eastcoast-logo.png")
            );

        public LayoutModel Layout
        {
            get
            {
                return layout;
            }
        }

        public HomePageModel HomePage
        {
            get
            {
                return homePage;
            }
        }

        public WhereToBuyPageModel WhereToBuyPage
        {
            get
            {
                return whereToBuyPage;
            }
        }

        public PageModel ProductsPage
        {
            get
            {
                return productsPage;
            }
        }

        public AboutPageModel AboutPage
        {
            get
            {
                return aboutPage;
            }
        }
    }
}
