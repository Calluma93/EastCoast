using Services.Models.Products;
using Services.Models.Shared;

namespace Services.Data.Electric
{
    public class ElectricData
    {
        private static readonly ResponsiveImageModel[] banners = {
            new ResponsiveImageModel("Electric Page Banner", "Banners/electric-product-banner-1.jpg", "Mobile/electric-product-banner-1.jpg")
        };

        public static ProductModel gdt230 =
            new ProductModel(
                "gdt230",
                "EastCoast gdt230 electric guitar",
                "Products/Electrics/GDT230/Blue-Quilt/thumbnail.jpg",
                banners,
                new ContentModel[] {
                    new ParagraphModel("The EastCoast GDT230 is a stylish, versatile and highly affordable electric guitar finished in Grey Quilt and Blue Quilt. Based on ‘hot-rodded’ double cutaway guitars, this model features easy playability, a tremolo unit and a selection of pickup types. "),
                    new ParagraphModel("A full 24 fret Maple neck is bolted on to a Poplar body. The design is modern and comfortable, making playing easy and natural."),
                    new ParagraphModel("Two single coil pickups and a bridge position humbucker allow this guitar to perform any type of musical style with ease. A tremolo bridge unit increases this versatility further."),
                    new ParagraphModel("The EastCoast GDT230 is priced for beginners and students but will also suit the more experienced guitarist looking for value and performance.")
                },
                new SpecificationModel(
                    "Alder w/ Printed Quilted Maple Top",
                    "Maple",
                    "Purpleheart",
                    "Bolt On",
                    "One Humbucker and Two Single Coils",
                    "25.5''",
                    false
                ),
                ElectricColourOptions.gdt230PrimaryColour,
                new ColourOptionModel[] {
                    ElectricColourOptions.gdt230PrimaryColour,
                    ElectricColourOptions.gdt230GreyQuilt
                },
                new MetaDataModel("EastCoast Guitars | GDT230 Electric Guitar", "The EastCoast GDT230 Electric Guitar is an affordable and versatile model with 24 frets, an H-S-S pickup configuration and a Pearloid pickguard.")
            );

        public static ProductModel gdt320 =
            new ProductModel(
                "gdt320",
                "EastCoast gdt320 electric guitar",
                "Products/Electrics/GDT320/Black-Ice-Burst/thumbnail.jpg",
                banners,
                new ContentModel[] {
                    new ParagraphModel("The EastCoast GDT320 is a formidable and stylish Rock guitar. Packed with features and attitude, this model is designed for more aggressive musical styles. The EastCoast GDT320 has a solid, chunky body sculpted into a classic double cutaway style."),
                    new ParagraphModel("Its slim, playable neck is bolted on to the body and is adorned with sensational ‘shark tooth’ fingerboard inlays. Both the headstock and the body’s top enjoy a touch of luxury in the form of multiple-ply binding."),
                    new ParagraphModel("Two high-powered humbucker pickups give this affordable guitar a clear and ferocious voice, perfect for all types of Rock and Metal. More quality details include a through-body bridge."),
                    new ParagraphModel("Solid, handsome, eminently playable and bringing a full-throated roar, the EastCoast GDT320 is a phenomenal voice for the aspiring Rock Musician.")
                },
                new SpecificationModel(
                    "Okoume w/ Quilted Maple Top",
                    "Maple",
                    "Purpleheart",
                    "Bolt On",
                    "Humbuckers",
                    "25.5''",
                    false
                ),
                ElectricColourOptions.gdt320PrimaryColour,
                new ColourOptionModel[] {
                    ElectricColourOptions.gdt320PrimaryColour,
                    ElectricColourOptions.gdt320CherrySunburst,
                    ElectricColourOptions.gdt320DarkCherry
                },
                new MetaDataModel("EastCoast Guitars | GDT320 Electric Guitar", "The EastCoast GDT320 Electric Guitar is a double cutaway model with high output humbuckers for a great Rock tone. The GDT320 has a string - through - body bridge and Shark inlays.")
            );

        public static ProductModel gdt320lh =
            new ProductModel(
                "gdt320lh",
                "EastCoast gdt320lh electric guitar",
                "Products/Electrics/GDT320/LH-Cherry-Sunburst/thumbnail.jpg",
                banners,
                new ContentModel[] {
                    new ParagraphModel("The EastCoast GDT320 is a formidable and stylish Rock guitar. Packed with features and attitude, this model is designed for more aggressive musical styles. The EastCoast GDT320 has a solid, chunky body sculpted into a classic double cutaway style."),
                    new ParagraphModel("Its slim, playable neck is bolted on to the body and is adorned with sensational ‘shark tooth’ fingerboard inlays. Both the headstock and the body’s top enjoy a touch of luxury in the form of multiple-ply binding."),
                    new ParagraphModel("Two high-powered humbucker pickups give this affordable guitar a clear and ferocious voice, perfect for all types of Rock and Metal. More quality details include a through-body bridge."),
                    new ParagraphModel("Solid, handsome, eminently playable and bringing a full-throated roar, the EastCoast GDT320 is a phenomenal voice for the aspiring Rock Musician.")
                },
                new SpecificationModel(
                    "Okoume w/ Quilted Maple Top",
                    "Maple",
                    "Purpleheart",
                    "Bolt On",
                    "Humbuckers",
                    "25.5''",
                    false
                ),
                ElectricColourOptions.gdt320lhCherrySunburst,
                new ColourOptionModel[] {
                    ElectricColourOptions.gdt320lhCherrySunburst
                },
                new MetaDataModel("EastCoast Guitars | GDT320LH Electric Guitar", "The EastCoast GDT320LH Electric Guitar is a left-handed model with high output humbuckers for a great Rock tone. The GDT320LH has a string - through - body bridge and Shark inlays.")
            );

        public static ProductModel gk20 =
            new ProductModel(
                "gk20",
                "EastCoast gk20 electric guitar",
                "Products/Electrics/GK20/Black/thumbnail.jpg",
                banners,
                new ContentModel[] {
                    new ParagraphModel("The EastCoast GK20 is a mini electric guitar designed for beginners, students and smaller guitarists."),
                    new ParagraphModel("Made with a downsized Poplar body, the GK20 has a bolted-on neck with a 16.6” scale, suited perfectly for smaller hands."),
                    new ParagraphModel("The sound is anything but small though: this is a real electric guitar and has two single coil pickups installed for a range of authentic Rock guitar tones."),
                    new ParagraphModel("The EastCoast GK20 is ideal as a first electric guitar for the younger player but is also a wonderful travel guitar for adult players.")
                },
                new SpecificationModel(
                    "Poplar",
                    "Maple",
                    "Maple",
                    "Bolt-On",
                    "2 Single Coils",
                    "500mm",
                    false
                ),
                ElectricColourOptions.gk20PrimaryColour,
                new ColourOptionModel[] {
                    ElectricColourOptions.gk20PrimaryColour,
                    ElectricColourOptions.gk20Pink,
                    ElectricColourOptions.gk20Red
                },
                new MetaDataModel("EastCoast Guitars | GK20 Mini Electric Guitar", "The EastCoast GK20 Electric Guitar is a Mini guitar with a bolted-on neck and single coil pickups. This is suitable as both a beginners’ instrument and as a travel guitar for experienced players.")
            );

        public static ProductModel gl20 =
            new ProductModel(
                "gl20",
                "EastCoast gl20 electric guitar",
                "Products/Electrics/GL20/Cherry-Sunburst/thumbnail.jpg",
                banners,
                new ContentModel[] {
                    new ParagraphModel("The EastCoast GL20 is single cutaway electric guitar finished in Cherry Sunburst. This guitar is perfect for beginners and students looking for quality at a great price."),
                    new ParagraphModel("Two sets of volume and tone controls make the most of the two chrome-covered humbuckers, giving this guitar a wide range of Rock, Blues and Jazz tones."),
                    new ParagraphModel("Inspired by classic designs, the GL20 has a Poplar body with an attractive carved Maple top and a highly playable bolted-on Maple neck. This design incorporates many classic details like trapezoid fingerboard inlays, binding around the body and a distinctive pickguard."),
                    new ParagraphModel("The EastCoast GL20 blends tremendous value with great looks and easy playability.")
                },
                new SpecificationModel(
                    "Poplar w/ Maple Top",
                    "Maple",
                    "Purpleheart",
                    "Bolt On",
                    "Humbuckers",
                    "24 3/4''",
                    false
                ),
                ElectricColourOptions.gl20PrimaryColour,
                new ColourOptionModel[] {
                    ElectricColourOptions.gl20PrimaryColour,
                    ElectricColourOptions.gl20TobaccoSunburst,
                },
                new MetaDataModel("EastCoast Guitars | GL20 Electric Guitar", "The EastCoast GL20 Electric Guitar is an affordable single cutaway electric guitar with two humbucker pickups and vintage styling for Classic Rock and Blues tones.")
            );

        public static ProductModel gl130 =
            new ProductModel(
                "gl130",
                "EastCoast gl130 electric guitar",
                "Products/Electrics/GL130/Blue-Burst/thumbnail.jpg",
                banners,
                new ContentModel[] {
                    new ParagraphModel("The EastCoast GL130 is a single cutaway electric guitar finished in Heritage Cherry Sunburst, Blue Burst, and Trans Black. This guitar is perfect for beginners and students looking for quality at a great price. "),
                    new ParagraphModel("Inspired by classic designs, the GL130 has an Okoume body with an attractive carved Maple top. "),
                    new ParagraphModel("The neck is glued in to the body for an upmarket, enhanced feel. This design incorporates many classic details like trapezoid fingerboard inlays, binding around the body and a distinctive pickguard."),
                    new ParagraphModel("Two sets of volume and tone controls make the most of the two chrome-covered humbuckers, giving this guitar a wide range of Rock, Blues and Jazz tones. The EastCoast GL130 blends tremendous value with great looks, upgraded build quality and easy playability.")
                },
                new SpecificationModel(
                    "Okoume w/ Printed Quilted Maple Top",
                    "Okoume",
                    "Purpleheart",
                    "Set-In",
                    "Humbuckers",
                    "24 3/4''",
                    false
                ),
                ElectricColourOptions.gl130PrimaryColour,
                new ColourOptionModel[] {
                   ElectricColourOptions.gl130PrimaryColour,
                   ElectricColourOptions.gl130HeritageCherrySunburst,
                   ElectricColourOptions.gl130TransBlack
                },
                new MetaDataModel("EastCoast Guitars | GL130 Electric Guitar", "The EastCoast GL130 Electric Guitar is an affordable single cutaway electric guitar with a set - neck, two humbucker pickups and vintage styling for Classic Rock and Blues tones.")
            );

        public static ProductModel gs100h =
            new ProductModel(
                "gs100h",
                "EastCoast gs100h electric guitar",
                "Products/Electrics/GS100H/Arctic-White/thumbnail.jpg",
                banners,
                new ContentModel[] {
                    new ParagraphModel("The EastCoast GS100H is an extremely versatile model."),
                    new ParagraphModel("This solid body electric packs in plenty of features including a bolted-on Maple neck with a smooth, playable action, a vintage tremolo bridge and a pickup configuration that includes a powerful humbucker at the bridge and two single coils for a wide variety of tones."),
                    new ParagraphModel("This is perfect for practising all styles of music from Jazz and Blues to Hard Rock."),
                    new ParagraphModel("Whether you are a beginner, student or seasoned player, the EastCoast GS100H in Arctic White, Black Metallic, or Race Red is a great value performer.")
                },
                new SpecificationModel(
                    "Poplar",
                    "Maple",
                    "Maple",
                    "Bolt On",
                    "One Humbucker and Two Single Coils",
                    "25.5''",
                    false
                ),
                ElectricColourOptions.gs100hPrimaryColour,
                new ColourOptionModel[] {
                    ElectricColourOptions.gs100hPrimaryColour,
                    ElectricColourOptions.gs100hBlackMetallic,
                    ElectricColourOptions.gs100hRaceRed
                },
                new MetaDataModel("EastCoast Guitars | GS100H Electric Guitar", "The EastCoast GS100H Electric Guitar is a versatile model with both humbucking and single coil pickups. The GS100H is a contemporary design based on a timeless classic.")
            );

        public static ProductModel gs100hlh =
            new ProductModel(
                "gs100hlh",
                "EastCoast gs100hlh electric guitar",
                "Products/Electrics/GS100H/LH-Arctic-White/thumbnail.jpg",
                banners,
                new ContentModel[] {
                    new ParagraphModel("The EastCoast GS100HLH is an extremely versatile model."),
                    new ParagraphModel("This solid body electric packs in plenty of features including a bolted-on Maple neck with a smooth, playable action, a vintage tremolo bridge and a pickup configuration that includes a powerful humbucker at the bridge and two single coils for a wide variety of tones."),
                    new ParagraphModel("This is perfect for practising all styles of music from Jazz and Blues to Hard Rock."),
                    new ParagraphModel("Whether you are a beginner, student or seasoned player, the EastCoast GS100HLH in Arctic White is a great value performer.")
                },
                new SpecificationModel(
                    "Poplar",
                    "Maple",
                    "Maple",
                    "Bolt On",
                    "One Humbucker and Two Single Coils",
                    "25.5''",
                    false
                ),
                ElectricColourOptions.gs100hlhPrimaryColour,
                new ColourOptionModel[] {
                    ElectricColourOptions.gs100hlhPrimaryColour
                },
                new MetaDataModel("EastCoast Guitars | GS100HLH Left-Handed Electric Guitar", "The EastCoast GS100HLH Electric Guitar is a versatile left-handed guitar with both humbucking and single coil pickups. The GS100HLH has a contemporary design based on a timeless classic.")
            );

        public static ProductModel gt100 =
            new ProductModel(
                "gt100",
                "EastCoast gt100 electric guitar",
                "Products/Electrics/GT100/Black/thumbnail.jpg",
                banners,
                new ContentModel[] {
                    new ParagraphModel("The EastCoast GT100 is a unique guitar design based on a classic single cutaway style."),
                    new ParagraphModel("This solid body electric guitar packs in plenty of features including a bolted-on Maple neck with a smooth, playable action, a chrome control panel and two classic sounding single coil pickups."),
                    new ParagraphModel("This guitar is perfect for practising all styles of music from Indie and Blues to Rock and Country."),
                    new ParagraphModel("Whether you are a beginner, student or seasoned player, the EastCoast GT100 is a great value performer with a style of its own.")
                },
                new SpecificationModel(
                    "Poplar",
                    "Maple",
                    "Maple",
                    "Bolt On",
                    "Two Single Coils",
                    "25.5''",
                    false
                ),
                ElectricColourOptions.gt100PrimaryColour,
                new ColourOptionModel[] {
                    ElectricColourOptions.gt100PrimaryColour,
                    ElectricColourOptions.gt100GreyQuilt,
                    ElectricColourOptions.gt100LakePlacidBlue,
                    ElectricColourOptions.gt100VintageBlonde
                },
                new MetaDataModel("EastCoast Guitars | GT100 Electric Guitar", "The EastCoast GT100 Electric Guitar is a versatile model with an original design. This will appeal not only to beginners but also experienced Pop, Blues and Country players.")
            );

        public static ProductModel gvq230 =
            new ProductModel(
                "gvq230",
                "EastCoast gvq230 electric guitar",
                "Products/Electrics/GVQ230/Black-Quilt/thumbnail.jpg",
                banners,
                new ContentModel[] {
                    new ParagraphModel("The EastCoast GVQ230 is a stylish and versatile guitar. Packed with features and attitude, this model is designed for more aggressive musical styles."),
                    new ParagraphModel("The EastCoast GVQ230 utilises the popular H-S-S pickup configuration to allow access to a wide variety of tones. A vintage style tremolo bridge widens this guitar’s potential and makes it a perfect lead guitar for Rock and other styles."),
                    new ParagraphModel("The EastCoast GVQ230 has a solid, chunky body sculpted into a classic double cutaway style. Its slim, playable neck is bolted on to the body and is adorned with sensational ‘shark tooth’ fingerboard inlays. Both the headstock and the body’s top enjoy a touch of luxury in the form of multiple-ply binding, and the back of the body is routed for easy access to the upper frets."),
                    new ParagraphModel("For musicians on a budget, the EastCoast GVQ230 in Sunburst, Spalted Maple, and Black Quilt is terrific value.")
                },
                new SpecificationModel(
                    "Okoume w/ Printed Quilted Maple Top",
                    "Maple",
                    "Purpleheart",
                    "Bolt On",
                    "Humbucker and Two Single Coils",
                    "25.5''",
                    false
                ),
                ElectricColourOptions.gvq230PrimaryColour,
                new ColourOptionModel[] {
                   ElectricColourOptions.gvq230PrimaryColour,
                   ElectricColourOptions.gvq230SpaltedMaple,
                   ElectricColourOptions.gvq230Sunburst
                },
                new MetaDataModel("EastCoast Guitars | GVQ230 Electric Guitar", "The EastCoast GVQ230 Electric Guitar is a versatile and attractive guitar. Great for beginners and experienced players alike, the GVQ230 features a tremolo and a selection of pickup types for a wide range of sounds.")
            );
    }
}
