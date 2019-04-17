using Services.Models.Products;
using Services.Models.Shared;

namespace Services.Data.Acoustic
{
    public class AcousticColourOptions
    {
        public static readonly ColourOptionModel mkoaPrimaryColour =
            new ColourOptionModel(
                "Koa",
                new ImageModel("Koa Option", "Products/Acoustics/MKOA/Small/detail-small-6.jpg"),
                new ImageModel[] {
                    new ImageModel("MKOA Koa Pickups Close Up","Products/Acoustics/MKOA/Large/detail-large-6.jpg"),
                    new ImageModel("MKOA Koa Rear Body Close Up","Products/Acoustics/MKOA/Large/detail-large-5.jpg"),
                    new ImageModel("MKOA Koa Front View","Products/Acoustics/MKOA/Large/detail-large-1.jpg"),
                    new ImageModel("MKOA Koa Back View","Products/Acoustics/MKOA/Large/detail-large-2.jpg"),
                    new ImageModel("MKOA Koa Front Elevation","Products/Acoustics/MKOA/Large/detail-large-3.jpg"),
                    new ImageModel("MKOA Koa Front Body Close Up","Products/Acoustics/MKOA/Large/detail-large-4.jpg")
                },
                new ImageModel[] {
                    new ImageModel("MKOA Koa Pickups Close Up","Products/Acoustics/MKOA/Small/detail-small-6.jpg"),
                    new ImageModel("MKOA Koa Rear Body Close Up","Products/Acoustics/MKOA/Small/detail-small-5.jpg"),
                    new ImageModel("MKOA Koa Front View","Products/Acoustics/MKOA/Small/detail-small-1.jpg"),
                    new ImageModel("MKOA Koa Back View","Products/Acoustics/MKOA/Small/detail-small-2.jpg"),
                    new ImageModel("MKOA Koa Front Elevation","Products/Acoustics/MKOA/Small/detail-small-3.jpg"),
                    new ImageModel("MKOA Koa Front Body Close Up","Products/Acoustics/MKOA/Small/detail-small-4.jpg")
                }
            );

        public static readonly ColourOptionModel mkoaePrimaryColour =
            new ColourOptionModel(
                "Koa",
                new ImageModel("Koa Option", "Products/Acoustics/MKOAE/Small/detail-small-6.jpg"),
                new ImageModel[] {
                    new ImageModel("MKOAE Koa Pickups Close Up","Products/Acoustics/MKOAE/Large/detail-large-6.jpg"),
                    new ImageModel("MKOAE Koa Rear Body Close Up","Products/Acoustics/MKOAE/Large/detail-large-5.jpg"),
                    new ImageModel("MKOAE Koa Front View","Products/Acoustics/MKOAE/Large/detail-large-1.jpg"),
                    new ImageModel("MKOAE Koa Back View","Products/Acoustics/MKOAE/Large/detail-large-2.jpg"),
                    new ImageModel("MKOAE Koa Front Elevation","Products/Acoustics/MKOAE/Large/detail-large-3.jpg"),
                    new ImageModel("MKOAE Koa Front Body Close Up","Products/Acoustics/MKOAE/Large/detail-large-4.jpg")
                },
                new ImageModel[] {
                    new ImageModel("MKOAE Koa Pickups Close Up","Products/Acoustics/MKOAE/Small/detail-small-6.jpg"),
                    new ImageModel("MKOAE Koa Rear Body Close Up","Products/Acoustics/MKOAE/Small/detail-small-5.jpg"),
                    new ImageModel("MKOAE Koa Front View","Products/Acoustics/MKOAE/Small/detail-small-1.jpg"),
                    new ImageModel("MKOAE Koa Back View","Products/Acoustics/MKOAE/Small/detail-small-2.jpg"),
                    new ImageModel("MKOAE Koa Front Elevation","Products/Acoustics/MKOAE/Small/detail-small-3.jpg"),
                    new ImageModel("MKOAE Koa Front Body Close Up","Products/Acoustics/MKOAE/Small/detail-small-4.jpg")
                }
            );
    }
}
