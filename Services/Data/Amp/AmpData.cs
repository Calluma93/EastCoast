using Services.Models.Products;
using Services.Models.Shared;

namespace Services.Data.Amp
{
    public class AmpData
    {
        private static readonly ResponsiveImageModel[] banners = {
            new ResponsiveImageModel("Amp Page Banner", "Banners/amp-product-banner-1.jpg", "Mobile/amp-product-banner-1.jpg")
        };

        public static ProductModel ec10g =
            new ProductModel(
                "ec10g",
                "EastCoast ec10g amplifier",
                "Products/Amps/EC10G/thumbnail.jpg",
                banners,
                new ContentModel[] {
                    new ParagraphModel("EastCoast guitar amplifiers are designed to be a reliable and fun part of your electric guitar playing experience"),
                    new ParagraphModel("The EastCoast ethos of quality and value are both applied here with amplifier models that are portable, well-built and perfect for beginners. With authentically styled enclosures and simple control panels, our amps bring out the best in EastCoast guitars."),
                    new ParagraphModel("The EastCoast EC-G10R is a compact, portable guitar combo. Perfect for beginners and bedrooms players, the EC-G10R has 10 watts of power and uses a special design 8” speaker."),
                    new ParagraphModel("Features include a switchable boost for an overdrive sound and a classic reverb effect, with its own dedicated control knob. Private practice is possible via a built-in headphone output. Take your first steps in amplification with the EastCoast EC-G10R.")
                },
                new SpecificationModel(
                    "10 watt guitar amplifier with 8” special design speaker",
                    "Boost button for vintage overdrive sound",
                    "Built-in classic Reverb effect with dedicated control knob",
                    "1/4” headphone jack",
                    "1/4” speaker out jack",
                    "Heavy duty carry handle",
                    true
                ),
                AmpColourOptions.ec10gPrimaryColour,
                new ColourOptionModel[] {
                    AmpColourOptions.ec10gPrimaryColour,
                },
                    new MetaDataModel("EastCoast Guitars | EC10G Guitar Amplifier", "The EC10G Guitar Amplifier provides a fantastic solution for the beginner guitarist. This 10 watt combo has two special - design speakers and features onboard reverb and a switchable overdrive sound.Practise in style with the EastCoast EC - 10G.")
            );
    }
}
