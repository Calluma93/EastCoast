namespace Services.Models.Products
{
    public class QuoteModel : ContentModel
    {
        public QuoteModel(string text, string author)
        {
            Text = text;
            Author = author;
        }

        public string Text { get; private set; }

        public string Author { get; private set; }
    }
}
