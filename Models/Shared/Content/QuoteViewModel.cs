namespace Eastcoast.Models.Shared.Content
{
    public class QuoteViewModel : ContentViewModel
    {
        public QuoteViewModel(string text, string author)
        {
            Text = text;
            Author = author;
        }

        public string Text { get; private set; }

        public string Author { get; private set; }
    }
}