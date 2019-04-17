using Services.Models.Products;
using Services.Models.Shared;

namespace Services.Data.Amp
{
    public class AmpColourOptions
    {
        public static readonly ColourOptionModel ec10gPrimaryColour =
        new ColourOptionModel(
            "Black",
            new ImageModel("EC10G", "Products/Amps/EC10G/Small/detail-small-1.jpg"),
            new ImageModel[] {
                new ImageModel("EC10G Front View","Products/Amps/EC10G/Large/detail-large-1.jpg"),
                new ImageModel("EC10G Back View","Products/Amps/EC10G/Large/detail-large-2.jpg"),
                new ImageModel("EC10G Front Elevation","Products/Amps/EC10G/Large/detail-large-3.jpg"),
                new ImageModel("EC10G Front Body Close Up","Products/Amps/EC10G/Large/detail-large-4.jpg"),
                new ImageModel("EC10G Rear Body Close Up","Products/Amps/EC10G/Large/detail-large-5.jpg"),
                new ImageModel("EC10G Pickups Close Up","Products/Amps/EC10G/Large/detail-large-6.jpg"),
            },
            new ImageModel[] {
                new ImageModel("EC10G Front View","Products/Amps/EC10G/Small/detail-small-1.jpg"),
                new ImageModel("EC10G Back View","Products/Amps/EC10G/Small/detail-small-2.jpg"),
                new ImageModel("EC10G Front Elevation","Products/Amps/EC10G/Small/detail-small-3.jpg"),
                new ImageModel("EC10G Front Body Close Up","Products/Amps/EC10G/Small/detail-small-4.jpg"),
                new ImageModel("EC10G Rear Body Close Up","Products/Amps/EC10G/Small/detail-small-5.jpg"),
                new ImageModel("EC10G Pickups Close Up","Products/Amps/EC10G/Small/detail-small-6.jpg")
            }
        );
    }
}
