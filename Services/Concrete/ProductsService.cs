using Services.Abstract;
using Services.Exceptions;
using Services.Models.Products;
using Services.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using Services.Data.Bass;
using Services.Data.Electric;
using Services.Data.Acoustic;
using Services.Data.Amp;

namespace Services.Concrete
{
    public class ProductsService : IProductsService
    {

        private static CategoryModel[] categories = new CategoryModel[]
        {
            new CategoryModel(
                "electric",
                "electric guitars",
                "EastCoast electric guitars",
                new ResponsiveImageModel[]
                {
                    new ResponsiveImageModel("Electric Category Banner", "Banners/electric-category-banner-1.jpg", "Mobile/electric-category-banner-1.jpg"),
                    new ResponsiveImageModel("Electric Category Banner", "Banners/electric-category-banner-2.jpg", "Mobile/electric-category-banner-2.jpg"),
                },
                new ImageModel("Electric Category Image","Products/Categories/electric-category.jpg"),
                new ProductModel[] {
                    ElectricData.gdt230,
                    ElectricData.gdt320,
                    ElectricData.gdt320lh,
                    ElectricData.gk20,
                    ElectricData.gl130,
                    ElectricData.gl20,
                    ElectricData.gs100h,
                    ElectricData.gs100hlh,
                    ElectricData.gt100,
                    ElectricData.gvq230
                },
                new MetaDataModel("EastCoast Guitars | Electric Guitars","EastCoast Electric guitars are a dynamic range of affordable electric guitars with classic and contemporary models available. EastCoast put quality, playability and affordability first.")
            ),
            new CategoryModel(
                "bass",
                "bass guitars",
                "EastCoast bass guitars",
                new ResponsiveImageModel[]
                {
                    new ResponsiveImageModel("Bass Category Banner", "Banners/bass-category-banner-1.jpg", "Mobile/bass-category-banner-1.jpg"),
                    new ResponsiveImageModel("Bass Category Banner", "Banners/bass-category-banner-2.jpg", "Mobile/bass-category-banner-2.jpg"),
                },
                new ImageModel("Bass Category Image","Products/Categories/bass-category.jpg"),
                new ProductModel[] {
                    BassData.gjb200m,
                    BassData.b210,
                    BassData.b210fl,
                    BassData.b210lh,
                    BassData.gpb10,
                    BassData.gtb005t,
                    BassData.gtb055t
                },
                new MetaDataModel("EastCoast Guitars | Bass Guitars","EastCoast Bass Guitars Are the perfect affordable choice. Reliable and stylish, EastCoast basses are designed for beginners and seasoned players alike. With a model to suit every player.")
            ),
            new CategoryModel(
                "acoustic",
                "acoustic guitars",
                "EastCoast acoustic guitars",
                new ResponsiveImageModel[]
                {
                    new ResponsiveImageModel("Acoustic Category Banner", "Banners/acoustic-category-banner-1.jpg", "Mobile/acoustic-category-banner-1.jpg")
                },
                new ImageModel("Acoustic Category Image","Products/Categories/acoustic-category.jpg"),
                new ProductModel[] {
                    AcousticData.mkoa,
                    AcousticData.mkoae
                }, 
                new MetaDataModel("EastCoast Guitars | Acoustic Guitars","The EastCoast acoustic guitar range includes affordable and highly playable acoustic guitars with quality features and stylish designs.")
            ),
            new CategoryModel(
                "amp",
                "amplifiers",
                "EastCoast guitar amplifiers",
                new ResponsiveImageModel[]
                {
                    new ResponsiveImageModel("Amp Category Banner", "Banners/amp-category-banner-1.jpg", "Mobile/amp-category-banner-1.jpg"),
                    new ResponsiveImageModel("Amp Category Banner", "Banners/amp-category-banner-2.jpg", "Mobile/amp-category-banner-2.jpg"),
                },
                new ImageModel("Amp Category Image","Products/Categories/amp-category.jpg"),
                new ProductModel[] {
                    AmpData.ec10g
                },
                new MetaDataModel("EastCoast Guitars | Amplification","EastCoast Amps Are designed to bring features and value to beginners and home players. Build quality, reliability and great sounds can be expected from EastCoast amplifiers along with superb value for value.")
            )
        };

        private IEnumerable<ProductModel> products = new ProductModel[]
        {
            AcousticData.mkoa,
            AcousticData.mkoae,
            AmpData.ec10g,
            BassData.gjb200m,
            BassData.b210,
            BassData.b210fl,
            BassData.b210lh,
            BassData.gpb10,
            BassData.gtb005t,
            BassData.gtb055t,
            ElectricData.gdt230,
            ElectricData.gdt320,
            ElectricData.gdt320lh,
            ElectricData.gk20,
            ElectricData.gl130,
            ElectricData.gl20,
            ElectricData.gs100h,
            ElectricData.gs100hlh,
            ElectricData.gt100,
            ElectricData.gvq230
        };

        public IEnumerable<CategoryModel> GetCategories()
        {
            return categories;
        }

        public CategoryModel GetCategory(string categoryName)
        {
            try
            {
                return categories.Single(a => a.Name == categoryName);
            }
            catch(InvalidOperationException)
            {
                throw new ClientException();
            }
        }

        public CategoryModel GetCategoryByProduct(string productName)
        {
            try
            {
                return categories.Single(a => a.Products.Any(b => b.Name == productName));
            }
            catch (InvalidOperationException)
            {
                throw new ClientException();
            }
        }

        public ProductModel GetProduct(string productName)
        {
            try
            {
                return products.Single(a => a.Name == productName);
            }
            catch(InvalidOperationException)
            {
                throw new ClientException();
            }
        }
    }
}
