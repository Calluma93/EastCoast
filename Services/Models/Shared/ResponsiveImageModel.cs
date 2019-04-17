namespace Services.Models.Shared
{
    public class ResponsiveImageModel : ImageModel
    {
        public ResponsiveImageModel(string title, string imageRelativeUrl, string mobileImageRelativeUrl) 
            : base(title, imageRelativeUrl)
        {
            MobileImageRelativeUrl = mobileImageRelativeUrl;
        }

        public string MobileImageRelativeUrl { get; private set; }
    }
}
