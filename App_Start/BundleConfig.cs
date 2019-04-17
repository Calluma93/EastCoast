using System.Web.Optimization;

namespace Eastcoast
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Main").Include(
                "~/Scripts/main.js"
            ));
        }
    }
}