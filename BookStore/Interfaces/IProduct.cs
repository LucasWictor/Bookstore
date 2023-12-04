// Iproduct.cs
namespace BookStore.Models
{
    public interface IProduct
    {
        string Title { get; set; }
        string DisplayInfo();
    }
}