namespace Eastcoast.Models.Shared.Content
{
    public class SubHeadingViewModel : ContentViewModel
    {
        public SubHeadingViewModel(string text)
        {
            Text = text;
        }

        public string Text { get; private set; }
    }
}