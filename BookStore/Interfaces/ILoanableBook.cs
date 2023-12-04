using BookStore.Models;

namespace BookStore.Interfaces
{
    public interface ILoanableBook : IProduct
    {
        int LoanPeriod { get; set; }
        string Borrower { get; set; }
    }
}