namespace Services.Models.Products
{
    public class SpecificationModel
    {
        public SpecificationModel(string body, string neck, string fingerboard, string contruction, string pickups, string scaleLength, bool isAmp)
        {
            Body = body;
            Neck = neck;
            Fingerboard = fingerboard;
            Contruction = contruction;
            Pickups = pickups;
            ScaleLength = scaleLength;
            IsAmp = isAmp;
        }

        public string Body { get; private set; }

        public string Neck { get; private set; }

        public string Fingerboard { get; private set; }

        public string Contruction { get; private set; }

        public string Pickups { get; private set; }

        public string ScaleLength { get; private set; }

        public bool IsAmp { get; private set; }
    }
}
