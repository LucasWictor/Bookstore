// Iaudiobook.cs
using BookStore.Models;

namespace BookStore.Interfaces
{
    public interface IAudiobook : IProduct
    {
        string Narrator { get; set; }
    }
}