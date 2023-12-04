using BookStore.Interfaces;

namespace BookStore.Models
{
    public class Audiobook : IAudiobook
    {
        public string Title { get; set; }
        public string Narrator { get; set; }

        public string DisplayInfo()
        {
            return $"Audiobook: {Title} narrated by {Narrator}";
        }
    }
}