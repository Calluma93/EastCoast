using Eastcoast.Models.Shared.Content;
using Services.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eastcoast.Helpers
{
    public static class ContentHelper
    {
        private static ContentViewModel mapContentToViewModel(ContentModel content)
        {
            if (content is SubHeadingModel)
            {
                SubHeadingModel subHeading = (SubHeadingModel)content;
                return new SubHeadingViewModel((subHeading).Text);
            }
            if (content is ParagraphModel)
            {
                ParagraphModel paragraph = (ParagraphModel)content;
                return new ParagraphViewModel((paragraph).Text);
            }
            if (content is QuoteModel)
            {
                QuoteModel quote = (QuoteModel)content;
                return new QuoteViewModel((quote).Text, (quote).Author);
            }
            throw new Exception("Unknown ContentModel type");
        }

        public static IEnumerable<ContentViewModel> MapContentToViewModel(IEnumerable<ContentModel> contents)
        {
            return contents.Select(a => mapContentToViewModel(a));
        }
    }
}