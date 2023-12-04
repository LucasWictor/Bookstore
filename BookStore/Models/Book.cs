using BookStore.Interfaces;

namespace BookStore.Models
{
    public class Book : IBook, IProduct
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public string DisplayInfo()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}";
        }
    }
}