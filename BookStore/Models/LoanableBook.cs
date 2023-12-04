using BookStore.Interfaces;

namespace BookStore.Models
{
    public class LoanableBook : ILoanableBook, IProduct
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int LoanPeriod { get; set; }
        public string Borrower { get; set; }

        public string DisplayInfo()
        {
            string bookInfo = $"Title: {Title}, Author: {Author}, ISBN: {ISBN}";
            string loanInfo = $"Loan Period: {LoanPeriod} days, Borrower: {Borrower}";

            return $"{bookInfo}\n{loanInfo}";
        }
    }
}