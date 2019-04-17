using System.Configuration;

namespace Eastcoast.Helpers
{
    public static class ConfigHelper
    {
        public static string RootUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["RootUrl"];
            }
        }
    }
}