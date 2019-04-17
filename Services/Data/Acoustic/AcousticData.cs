using Services.Models.Products;
using Services.Models.Shared;

namespace Services.Data.Acoustic
{
    public class AcousticData
    {
        private static readonly ResponsiveImageModel[] banners = {
            new ResponsiveImageModel("Acoustic Page Banner", "Banners/acoustic-product-banner-1.jpg", "Mobile/acoustic-product-banner-1.jpg")
        };

        public static ProductModel mkoa =
            new ProductModel(
                "mkoa",
                "EastCoast mkoa acoustic guitar",
                "Products/Acoustics/mkoa/thumbnail.jpg",
                banners,
                new ContentModel[] {
                    new ParagraphModel("The EastCoast GSM-KOA is an acoustic travel-sized guitar made with premium woods. Travel guitars are more popular than ever: now you can carry around a distinctive, high quality acoustic for less than you’d expect!"),
                    new ParagraphModel("This beautiful guitar is made with a top of solid Koa. Koa is an exotic tone wood found only in the Hawaiian Islands. It is known for its thick, resonant tone and striking grain pattern."),
                    new ParagraphModel("The GSM-KOA has a smaller body and shorter neck to make it the perfect portable instrument."),
                    new ParagraphModel("Wherever you go, you’ll always have a musical companion with the EastCoast GSM-KOA.")
                },
                new SpecificationModel(
                    "Solid Koa Top, Back & Sides",
                    "Okoume",
                    "Rosewood ",
                    "Standard",
                    "None",
                    "23.5''",
                    false
                ),
                AcousticColourOptions.mkoaPrimaryColour,
                new ColourOptionModel[] {
                    AcousticColourOptions.mkoaPrimaryColour,
                },
                    new MetaDataModel("EastCoast Guitars | MKOA Acoustic Guitar", "The EastCoast MKOA Acoustic Guitar is a portable, travel-sized acoustic guitar made from Hawaiian Koa and featuring a solid Koa top.")
            );

        public static ProductModel mkoae =
            new ProductModel(
                "mkoae",
                "EastCoast mkoae acoustic guitar",
                "Products/Acoustics/mkoaE/thumbnail.jpg",
                banners,
                new ContentModel[] {
                    new ParagraphModel("The EastCoast GSM-KOA-E is an acoustic travel-sized guitar made with premium woods. Travel guitars are more popular than ever: now you can carry around a distinctive, high quality acoustic for less than you’d expect!"),
                    new ParagraphModel("This beautiful guitar is made with a top of solid Koa. Koa is an exotic tone wood found only in the Hawaiian Islands. It is known for its thick, resonant tone and striking grain pattern."),
                    new ParagraphModel("The GSM-KOA-E has a smaller body and shorter neck to make it the perfect portable instrument. This model also features a Fishman Presys II pickup system for plugging into amps or PA systems for live performance!"),
                    new ParagraphModel("Wherever you go, you’ll always have a musical companion with the EastCoast GSM-KOA-E.")
                },
                new SpecificationModel(
                    "Solid Koa Top, Back & Sides",
                    "Okoume",
                    "Rosewood ",
                    "Standard",
                    "Fishman Presys II Electronic Pickup",
                    "23.5''",
                    false
                ),
                AcousticColourOptions.mkoaePrimaryColour,
                new ColourOptionModel[] {
                    AcousticColourOptions.mkoaePrimaryColour,
                },
                    new MetaDataModel("EastCoast Guitars | MKOAE Electro-Acoustic Guitar", "The EastCoast MKOAE Acoustic Guitar is a portable, travel-sized electro acoustic guitar made from Hawaiian Koa and featuring a solid Koa top.")
            );
    }
}
