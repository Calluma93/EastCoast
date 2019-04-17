namespace Eastcoast.Helpers
{
    public static class EastcoastUrlHelper
    {
        public static string GetCategoryUrl(string name)
        {
            return ConfigHelper.RootUrl + name + '/';
        }

        public static string GetImageUrl(string imageRelativeUrl)
        {
            return ConfigHelper.RootUrl + "Images/" + imageRelativeUrl;
        }

        public static string GetProductUrl(string name)
        {
            return ConfigHelper.RootUrl + "product/" + name + "/";
        }

        public static string GetLinkImageUrl(string name)
        {
            return ConfigHelper.RootUrl + name + "/";
        }
    }
}