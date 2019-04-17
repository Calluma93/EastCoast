using Eastcoast.Models.Shared;

namespace Eastcoast.Models.Category
{
    public class CategoryViewModel
    {
        public string Title { get; set; }

        public string Name { get; set; }

        public ImageViewModel CategoryImage { get; set; }

        public string LinkUrl { get; set; }

        public string MetaTitle { get; set; }

        public string MetaDescription { get; set; }
    }
}