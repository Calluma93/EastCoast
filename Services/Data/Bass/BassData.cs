using Services.Models.Products;
using Services.Models.Shared;

namespace Services.Data.Bass
{
    public class BassData
    {
        private static readonly ResponsiveImageModel[] banners = {
            new ResponsiveImageModel("Bass Page Banner", "Banners/bass-product-banner-1.jpg", "Mobile/bass-product-banner-1.jpg")
        };

        public static ProductModel b210 =
            new ProductModel(
                "b210",
                "EastCoast b210 bass guitar",
                "Products/Basses/B210/Grey-Quilt/thumbnail.jpg",
                banners,
                new ContentModel[] {
                    new ParagraphModel("The EastCoast B210 is an attractive, original design bass guitar with active electronics. It has been designed to offer solid and reliable performance at an extremely attractive price point."),
                    new ParagraphModel("The B210 has an original offset body design made from Poplar and is finished in Grey Quilt. A 34” scale length Maple neck is bolted on to the body and features a Purpleheart fingerboard."),
                    new ParagraphModel("Two humbucking pickups provide a powerful and versatile sound whilst an active 3 band EQ circuit allows the player to boost and cut treble, bass and middle frequencies with power and precision."),
                    new ParagraphModel("Individual volume controls for each pickup add to this model’s versatility. Much more than an entry-level bass, the EastCoast B210 is a distinctive and high-performance instrument for players of all styles and levels of experience.")
                },
                new SpecificationModel(
                    "Poplar w/ Printed Quilted Maple Top",
                    "Maple",
                    "Purpleheart",
                    "Bolt-On",
                    "2 x Humbucker",
                    "34''",
                    false
                ),
                BassColourOptions.b210PrimaryColour,
                new ColourOptionModel[] {
                    BassColourOptions.b210PrimaryColour
                },
                new MetaDataModel("EastCoast Guitars | B210 Bass Guitar", "The EastCoast B210 Bass Guitar is a stylish and affordable bass with a unique design. Active electronics make this a powerful and versatile choice for bassists of all styles and abilities.")
            );

        public static ProductModel b210fl =
            new ProductModel(
                "b210fl",
                "EastCoast b210 fretless bass guitar",
                "Products/Basses/B210/FL-Natural-Satin/thumbnail.jpg",
                banners,
                new ContentModel[] {
                    new ParagraphModel("The EastCoast B210FL is an original design fretless bass guitar with active electronics. It has been designed to offer solid and reliable performance at an extremely attractive price point."),
                    new ParagraphModel("The B210FL has an original offset body design made from Poplar and is finished in Natural Satin. A 34” scale length Maple neck is bolted on to the body and features a fretless Purpleheart fingerboard."),
                    new ParagraphModel("Two humbucking pickups provide a powerful and versatile sound whilst an active 3 band EQ circuit allows the player to boost and cut treble, bass and middle frequencies with power and precision."),
                    new ParagraphModel("Individual volume controls for each pickup add to this model’s versatility. Much more than an entry-level bass, the EastCoast B210FL is a distinctive and high-performance instrument for players of all styles and levels of experience.")
                },
                new SpecificationModel(
                   "Poplar w/ Printed Quilted Maple Top",
                    "Maple",
                    "Purpleheart",
                    "Bolt-On",
                    "2 x Humbucker",
                    "34''",
                    false
                ),
                BassColourOptions.b210flPrimaryColour,
                new ColourOptionModel[] {
                    BassColourOptions.b210flPrimaryColour
                },
                new MetaDataModel("EastCoast Guitars | B210FL Fretless Bass Guitar", "The EastCoast B210FL Bass Guitar is a feature-laden fretless bass. Stylish and affordable, the EastCoast B210FL has active electronics for added versatility and a highly playable design.")
            );

        public static ProductModel b210lh =
            new ProductModel(
                "b210lh",
                "EastCoast b210 left-handed bass guitar",
                "Products/Basses/B210/LH-2-Tone-Sunburst/thumbnail.jpg",
                banners,
                new ContentModel[] {
                    new ParagraphModel("The EastCoast B210LH is an attractive, left-handed bass guitar with active electronics. It has been designed to offer solid and reliable performance at an extremely attractive price point."),
                    new ParagraphModel("The B210 has an original offset body design made from Poplar and is finished in Two Tone Sunburst. A 34” scale length Maple neck is bolted on to the body and features a Purpleheart fingerboard."),
                    new ParagraphModel("Two humbucking pickups provide a powerful and versatile sound whilst an active 3 band EQ circuit allows the player to boost and cut treble, bass and middle frequencies with power and precision."),
                    new ParagraphModel("Individual volume controls for each pickup add to this model’s versatility. Much more than an entry-level bass, the EastCoast B210LH is a distinctive and high-performance instrument for left-handed players of all styles and levels of experience.")
                },
                new SpecificationModel(
                    "Poplar w/ Printed Quilted Maple Top",
                    "Maple",
                    "Purpleheart",
                    "Bolt-On",
                    "2 x Humbucker",
                    "34''",
                    false
                ),
                BassColourOptions.b210lhPrimaryColour,
                new ColourOptionModel[] {
                    BassColourOptions.b210lhPrimaryColour,
                },
                new MetaDataModel("EastCoast Guitars | B210LH Left Handed Bass Guitar", "The EastCoast B210LH Bass Guitar is a stylish and affordable left-handed bass. Active electronics make this a powerful and versatile choice for bassists of all styles and abilities.")
            );

        public static ProductModel gjb200m =
            new ProductModel(
                "gjb200m",
                "EastCoast gjb200m bass guitar",
                "Products/Basses/GJB200M/Black-Satin/thumbnail.jpg",
                banners,
                new ContentModel[] {
                    new ParagraphModel("The EastCoast GJB200 is designed to meet the needs of the musician looking for a stylish and affordable bass. Built using a quality Ash body and Maple bolt-on neck, the GJB200 brings quality and playability in at a low cost. "),
                    new ParagraphModel("This handsome bass has two single coil pickups, providing a classic sound. These can be blended together thanks to the individual volume controls."),
                    new ParagraphModel("Block inlay markers on the neck, a Black satin or Natural finish with a tortoiseshell pickguard make this a bass that really stands out."),
                    new ParagraphModel("Whether you are a beginner, student or experienced player, you can rely on the EastCoast GJB200 for performance and value.")
                },
                new SpecificationModel(
                    "Ash",
                    "Maple",
                    "Maple",
                    "Bolt-On",
                    "2 x JB Pickups",
                    "34''",
                    false
                ),
                BassColourOptions.gjb200mPrimaryColour,
                new ColourOptionModel[] {
                    BassColourOptions.gjb200mPrimaryColour,
                    BassColourOptions.gjb200mNatural
                },
                new MetaDataModel("EastCoast Guitars | GJB200M Bass Guitar", "The GJB200M Bass Guitar is an extremely affordable model. based on a classic design, this will appeal to beginners and experienced bassists alike. Easy playability and timeless styling create a truly satisfying bass.")
            );

        public static ProductModel gpb10 =
            new ProductModel(
                "gpb10",
                "EastCoast gpb10 bass guitar",
                "Products/Basses/GPB10/Arctic-White/thumbnail.jpg",
                banners,
                new ContentModel[] {
                    new ParagraphModel("The EastCoast GPB10 is a cost-effective solution for the musician seeking a reliable, attractive and effective bass. EastCoast has designed this bass to appeal to beginners, students and seasoned players alike."),
                    new ParagraphModel("A traditionally-styled Poplar body and bolt-on Maple neck provide the basis for the GPB10. This bass has a fingerboard made of Purpleheart and a 34” scale length for a comfortable, familiar feel."),
                    new ParagraphModel("A single split-coil pickup is all you need for a powerful sound that will suit any genre. The EastCoast GPB10 is easy to play and looks beautiful."),
                    new ParagraphModel("For all of your bass needs, begin here with the high quality, budget-friendly EastCoast GPB10.")
                },
                new SpecificationModel(
                    "poplar",
                    "maple",
                    "purpleheart",
                    "bolt-on",
                    "1 x split coil pickup",
                    "34''",
                    false
                ),
                BassColourOptions.gpb10PrimaryColour,
                new ColourOptionModel[]
                {
                    BassColourOptions.gpb10PrimaryColour,
                    BassColourOptions.gpb10Sunburst,
                },
                new MetaDataModel("EastCoast Guitars | GPB10 Bass Guitar", "The GPB10 Bass Guitar is an extremely affordable model based on a classic design. Beginners and experienced bassists will enjoy the easy playability and timeless styling available here.")
            );

        public static ProductModel gtb005t =
            new ProductModel(
                "gtb005t",
                "EastCoast gtb005t bass guitar",
                "Products/Basses/GTB005T/Natural/thumbnail.jpg",
                banners,
                new ContentModel[] {
                    new ParagraphModel("The EastCoast GTB005T is a richly detailed 4 string bass with active electronics. This instrument is loaded with high-performance features for the bassist on a budget. Neck-through construction lends this bass a premium look and feel."),
                    new ParagraphModel("The 5-piece Maple and Rosewood neck has a 34” scale and is topped with a fingerboard of Purpleheart. The beautiful offset body design features sculpted and contoured Okoume and Maple, topped with Rosewood."),
                    new ParagraphModel("The through neck is visible through the body for extra detail. The EastCoast GTB005T has a pair of powerful humbucking pickups for a smooth and powerful tone."),
                    new ParagraphModel("An active 3 band EQ circuit, powered by a 9v battery, lets the player boost and cut treble, middle and bass frequencies dramatically, increasing versatility. The EastCoast GTB005T is an excellent choice for bass players of all styles and tastes.")
                },
                new SpecificationModel(
                    "Okoume w/ Maple and Rosewood Top",
	                "Maple w/ 2 Ply Rosewood Inlay",
                    "Purpleheart",
	                "Neck Through",
                    "2 x Humbucker",
	                "34''",
                    false
                ),
                BassColourOptions.gtb005tPrimaryColour,
                new ColourOptionModel[] {
                    BassColourOptions.gtb005tPrimaryColour
                },
                new MetaDataModel("EastCoast Guitars | GTB005T Bass Guitar", "The EastCoast GTB005T Bass Guitar is a fantastic through-neck design bass with beautiful multiple wood detailing.Twin humbucking pickups and active EQ circuitry make this a very versatile and expressive instrument for all bassists.")
            );

        public static ProductModel gtb055t =
            new ProductModel(
                "gtb055t",
                "EastCoast gtb055t bass guitar",
                "Products/Basses/GTB055T/Natural/thumbnail.jpg",
                banners,
                new ContentModel[] {
                            new ParagraphModel("The EastCoast GTB055T is a richly detailed 5 string bass with active electronics. This instrument is loaded with high-performance features for the bassist on a budget. Neck-through construction lends this bass a premium look and feel."),
                            new ParagraphModel("The EastCoast GTB055T has a pair of powerful humbucking pickups for a smooth and powerful tone."),
                            new ParagraphModel("The 5-piece Maple and Rosewood neck has a 34” scale and is topped with a fingerboard of Purpleheart. The beautiful offset body design features sculpted and contoured Okoume and Maple, topped with Rosewood. The through neck is visible through the body for extra detail."),
                            new ParagraphModel("An active 3 band EQ circuit, powered by a 9v battery, lets the player boost and cut treble, middle and bass frequencies dramatically, increasing versatility.")
                },
                new SpecificationModel(
                    "Okoume w/ Maple and Rosewood Top",
                    "Maple w/ 2 Ply Rosewood Inlay",
                    "Purpleheart",
                    "Neck Through",
                    "2 x Humbucker",
                    "34''",
                    false
                ),
                BassColourOptions.gtb055tPrimaryColour,
                new ColourOptionModel[] {
                    BassColourOptions.gtb055tPrimaryColour
                },
                new MetaDataModel("EastCoast Guitars | GTB055T 5 String Bass Guitar", "The GTB055T Bass Guitar is a fantastic through-neck design 5 string bass with beautiful multiple wood detailing.Twin humbucking pickups and active EQ circuitry make this a very versatile and expressive instrument for all bassists.")
            );
    }
}
